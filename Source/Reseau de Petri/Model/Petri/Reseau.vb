Imports System.ComponentModel 'Importation necessaire à l'utilisation des bindingList
Imports System.Runtime.Serialization 'Afin de mettre en place une sérialisation avancée
Imports System.IO

''' <summary>
''' La classe réseau rassemble les différents éléments du réseau. Elle comprend donc les listes de place, de transition et d'arc ainsi que les différentes méthodes permettant de mettre à jour le réseau, de selectionner une transition au hasard et de la valider.
''' Elle comprend également la gestion des évenements pour afficher le processus de simulation.
''' </summary>
''' <remarks>Pour plus d'information sur la partie théorique : http://fr.wikipedia.org/wiki/R%C3%A9seau_de_Petri </remarks>
<DataContract(Name:="Reseau")> _
Public Class Reseau
#Region "Attributs privés" 'déclaration des attributs privés de la classe reseau, ne necessitant pas une Maj
    ''' <remarks>L'utilisation de BindingList se justifie pour syncroniser la liste des places avec le combobox de la fenètre principale</remarks>
    Private T_Place As New BindingList(Of Place)
    ''' <remarks>L'utilisation de BindingList se justifie pour syncroniser la liste des transition avec le combobox de la fenètre principale</remarks>
    Private T_Transition As New BindingList(Of Transition)
    Private T_Arc As New List(Of Arc)

#Region "Attributs necessitant une fonction de mise à jour" 'déclaration des attributs privés de la classe reseau, necessitant une Maj
    Private T_TransitionValidable As New List(Of Transition)
    Private T_ArcRentrant As New List(Of Arc)
    Private T_ArcSortant As New List(Of Arc)
#End Region
#End Region
#Region "Constructeur" 'mise en place du constructeur lié à cette classe, qui permettra d'initialiser l'instanciation des objets liés à cette classe.
    Public Sub New()

    End Sub
#End Region
#Region "Gestion évenements" 'méthode permettant de gérer la création des évenements lors de la simulation du reseau
    Public Delegate Sub ReseauChangeEventHandler(ByVal sender As Object, ByVal e As ChangementReseauEventArgs)
    Public Event ReseauChange As ReseauChangeEventHandler
    Public Sub EnvoyerReseauChange(ByVal texte As String, ByVal couleur As Color)
        Dim e As ChangementReseauEventArgs = New ChangementReseauEventArgs(texte, couleur)
        If Not (e Is Nothing) Then
            'L'évenement est envoyé
            RaiseEvent ReseauChange(Me, e)
        End If
    End Sub
    Public Sub EnvoyerReseauChange(ByVal texte As String)
        Dim black As Color = Color.Black
        Dim e As ChangementReseauEventArgs = New ChangementReseauEventArgs(texte, black)
        If Not (e Is Nothing) Then
            'L'évenement est envoyé
            RaiseEvent ReseauChange(Me, e)
        End If
    End Sub
#End Region
#Region "Properties" 'mise en place des méthodes (get et set)qui gèrent les attributs de la classe hors de celle ci, en utilisant Property
    <DataMember(Name:="Tableau_des_places", Order:=1)>
    Public Property TableauPlace() As BindingList(Of Place)
        Get
            Return T_Place
        End Get
        Set(ByVal value As BindingList(Of Place))
            T_Place = value
        End Set
    End Property
    <DataMember(Name:="Tableau_des_transitions", Order:=2)>
    Public Property TableauTransition() As BindingList(Of Transition)
        Get
            Return T_Transition
        End Get
        Set(ByVal value As BindingList(Of Transition))
            T_Transition = value
        End Set
    End Property
    <DataMember(Name:="Tableau_des_arcs", Order:=3)>
    Public Property TableauArc() As List(Of Arc)
        Get
            Return T_Arc
        End Get
        Set(ByVal value As List(Of Arc))
            T_Arc = value
        End Set
    End Property
    <DataMember(EmitDefaultValue:=True, IsRequired:=False, Name:="TableauTransitionValidable")>
    Public Property TableauTransitionValidable() As List(Of Transition)
        Get
            Return T_TransitionValidable
        End Get
        Set(ByVal value As List(Of Transition))

        End Set
    End Property
    <DataMember(EmitDefaultValue:=True, IsRequired:=False, Name:="TableauArcRentrant")>
    Public Property TableauArcRentrant() As List(Of Arc)
        Get
            Return T_ArcRentrant
        End Get
        Set(ByVal value As List(Of Arc))

        End Set
    End Property
    <DataMember(EmitDefaultValue:=True, IsRequired:=False, Name:="TableauArcSortant")>
    Public Property TableauArcSortant() As List(Of Arc)
        Get
            Return T_ArcSortant
        End Get
        Set(ByVal value As List(Of Arc))

        End Set
    End Property
#End Region
#Region "Check" 'méthode permettant d'initialiser les transitions validables,et les arcs entrants et sortants relatifs à celle ci
    Private Sub CheckInitialisation()
        If T_TransitionValidable Is Nothing Then
            T_TransitionValidable = New List(Of Transition)
        End If
        If T_ArcRentrant Is Nothing Then
            T_ArcRentrant = New List(Of Arc)
        End If
        If T_ArcSortant Is Nothing Then
            T_ArcSortant = New List(Of Arc)
        End If
    End Sub
#End Region
#Region "Fonctions de mises à jour" 'méthodes permettant de mettre à jour les transitions validables, et les arcs relatifs à celles-ci
    Private Sub Maj_ArcRentrant(ByVal trans As Transition) 'Maj des arcs rentrants
        If T_ArcRentrant IsNot Nothing Then
            T_ArcRentrant.Clear()
        End If
        'Gestion des évenements
        If Main.ChB_verbose.Checked Then
            EnvoyerReseauChange("Mise à jour des arcs rentrants dans la transition d'hashcode " & CStr(trans.GetHashCode) & " et de nom '" & trans.nom & "'." & vbCrLf, Color.DarkMagenta)
        End If
        CheckInitialisation()
        'On parcourt les élements de T_Arc
        For Each _arc As Arc In T_Arc
            'Utilisation de Is pour comparer deux instances d'objet, ici la transition relative à un arc rentrant et la transition qu'on spécifie dans notre méthode
            If _arc.transition Is trans And _arc.sens = Arc.E_Sens.PlaceVersTransition Then
                T_ArcRentrant.Add(_arc)
            End If
        Next
    End Sub
    Private Sub Maj_ArcSortant(ByVal trans As Transition) 'Maj des arcs sortants
        If T_ArcSortant IsNot Nothing Then
            T_ArcSortant.Clear()
        End If
        'Gestion des évenements
        If Main.ChB_verbose.Checked Then
            EnvoyerReseauChange("Mise à jour des arcs sortants dans la transition d'hashcode " & CStr(trans.GetHashCode) & " et de nom '" & trans.nom & "'." & vbCrLf, Color.DarkMagenta)
        End If

        'On parcourt les élements de T_Arc
        For Each _arc As Arc In T_Arc
            'Utilisation de Is pour comparer deux instances d'objet, ici la transition relative à un arc sortant et la transition qu'on spécifie dans notre méthode
            If _arc.transition Is trans And _arc.sens = Arc.E_Sens.TransitionVersPlace Then
                T_ArcSortant.Add(_arc)
            End If
        Next
    End Sub
    Public Sub Maj_TransitionValidable() 'Maj des transitions validables
        If T_TransitionValidable IsNot Nothing Then
            T_TransitionValidable.Clear()
        End If
        Dim is_validable As Boolean

        'Gestion des évenements
        If Main.ChB_verbose.Checked Then
            EnvoyerReseauChange("Mise à jour des transitions validables dans la transition." & vbCrLf)
            EnvoyerReseauChange(vbCrLf)
        End If

        'On parcourt les élements de T_Transition
        For Each _trans As Transition In T_Transition
            is_validable = True
            Me.Maj_ArcRentrant(_trans)
            For Each _arc As Arc In T_ArcRentrant
                If _arc.place.nombreJeton < _arc.multiplicite Or is_validable = False Then
                    is_validable = False
                End If
            Next
            If is_validable = True Then
                T_TransitionValidable.Add(_trans)
            End If
        Next
    End Sub
#End Region
#Region "Fonctions de validation" 'méthodes qui permettent de choisir une transition validable au hasard, et d'effectuer le passage des jetons des places amont aux places aval liées à cette transition
    Public Function ChoixHasard_TransitionValidable() As Transition 'choix au hasard d'une transition validable
        Me.Maj_TransitionValidable()
        Dim rand As New Random()
        Dim numTrans As Integer = CInt(rand.Next(0, T_TransitionValidable.Count)) 'choix aléatoire de l'entier pair le plus proche d'un nombre aléatoire choisi entre 0 et le nombre de transitions validables comptées
        'Gestion des évenements
        If Main.ChB_verbose.Checked Then
            EnvoyerReseauChange("Choix au hasard d'une transition dans les transitions validables." & vbCrLf & "Il y'a " & CStr(T_TransitionValidable.Count) & " transition(s) validable(s) et je choisis la " & CStr(numTrans + 1) & " eme (ière)." & vbCrLf & "Il s'agit de la transition d'hashcode " & CStr(T_TransitionValidable.Item(numTrans).GetHashCode) & " et de nom '" & T_TransitionValidable.Item(numTrans).nom & "'." & vbCrLf, Color.DarkRed)
        End If
        Return T_TransitionValidable.Item(numTrans)
    End Function
    Public Sub ValiderTransition(ByVal trans As Transition) 'validation de la transition validable choisie (incrémentation des places aval en jetons, décrémentation des places amont)
        Me.Maj_ArcRentrant(trans)
        For Each _arcRentrant As Arc In T_ArcRentrant
            _arcRentrant.place.DiminuerDeN(_arcRentrant.multiplicite)
            If Main.ChB_verbose.Checked Then
                EnvoyerReseauChange("J'enlève " & CStr(_arcRentrant.multiplicite) & " jeton(s) à la place d'hashcode " & CStr(_arcRentrant.place.GetHashCode) & " et de nom '" & _arcRentrant.place.nom & "'." & vbCrLf, Color.DarkOliveGreen)
            End If
        Next

        Me.Maj_ArcSortant(trans)
        For Each _arcSortant As Arc In T_ArcSortant
            _arcSortant.place.AugmenterDeN(_arcSortant.multiplicite)
            If Main.ChB_verbose.Checked Then
                EnvoyerReseauChange("Je rajoute " & CStr(_arcSortant.multiplicite) & " jeton(s) à la place d'hashcode " & CStr(_arcSortant.place.GetHashCode) & " et de nom '" & _arcSortant.place.nom & "'." & vbCrLf, Color.DarkOliveGreen)
            End If
        Next
        If Main.ChB_verbose.Checked Then
            EnvoyerReseauChange(vbCrLf)
        End If
    End Sub
#End Region
#Region "Fonction d'affichage et de retour" ' méthodes permettant de génerer l'arborescence liée à la simulation
    Public Function RetournerEquivalenceTreeNode() As TreeNode
        Dim tree As New TreeNode()
        tree.Text = "Données"
        tree.Nodes.Add("Places", "Places")
        tree.Nodes.Add("Transitions", "Transitions")
        tree.Nodes.Add("Arc", "Arc")
        'Maj des nodes destinés aux places
        For Each _place In T_Place
            Dim hash As String
            If Main.ChB_verbose.Checked Then
                hash = " [" & _place.GetHashCode & "]"
            Else
                hash = ""
            End If
            tree.Nodes("Places").Nodes.Add(CStr(_place.GetHashCode), "'" & _place.nom & "' (" & _place.nombreJeton & " jetons)" & hash)
        Next
        'Maj des nodes destinés aux transitions
        For Each _trans In T_Transition
            Dim hash As String
            If Main.ChB_verbose.Checked Then
                hash = " [" & _trans.GetHashCode & "]"
            Else
                hash = ""
            End If
            tree.Nodes("Transitions").Nodes.Add(CStr(_trans.GetHashCode), "'" & _trans.nom & "' " & hash)
        Next
        'Maj des nodes destinés aux arcs
        For Each _arc In T_Arc
            Dim hasharc, hashplace, hashtrans As String
            If Main.ChB_verbose.Checked Then
                hasharc = " [" & _arc.GetHashCode & "]"
                hashplace = " [" & _arc.place.GetHashCode & "]"
                hashtrans = " [" & _arc.transition.GetHashCode & "]"
            Else
                hasharc = ""
                hashplace = ""
                hashtrans = ""
            End If
            If _arc.sens = Arc.E_Sens.PlaceVersTransition Then

                tree.Nodes("Arc").Nodes.Add(CStr(_arc.GetHashCode), _arc.place.nom & hashplace & " -> " & _arc.transition.nom & hashtrans & " [x" & _arc.multiplicite & "]" & hasharc)
            Else
                tree.Nodes("Arc").Nodes.Add(CStr(_arc.GetHashCode), _arc.transition.nom & hashtrans & " -> " & _arc.place.nom & hashplace & " [x" & _arc.multiplicite & "]" & hasharc)
            End If
        Next
        Return tree
    End Function
    Public Sub GenererEtat(Optional ByVal Etat As String = "") 'générer l'état des places (spécifier leur nombre de jetons après simulation)
        If Etat <> "" Then
            EnvoyerReseauChange("****** Etat " & Etat & " : *******" & vbCrLf, Color.DarkOrange)
        End If
        For Each _place In T_Place
            If _place.nombreJeton = 0 Then
                EnvoyerReseauChange("Il ne reste plus de jeton dans la place " & _place.nom & "." & vbCrLf, Color.DarkOrange)
            ElseIf _place.nombreJeton = 1 Then
                EnvoyerReseauChange("Il y a un unique jeton dans la place " & _place.nom & "." & vbCrLf, Color.DarkOrange)
            Else
                EnvoyerReseauChange("Il y a " & CStr(_place.nombreJeton) & " jetons dans la place " & _place.nom & "." & vbCrLf, Color.DarkOrange)
            End If
        Next
    End Sub
#End Region
#Region "Graphviz" ' Code nécessaire àl'affichage du reseau de petri sur Graphviz
    Public Sub EnregistrerDot()
        Dim pathGraphviz As String
        Dim path As String
        If Directory.Exists(Environ("ProgramFiles(x86)") & "\Graphviz 2.28") Then
            pathGraphviz = Environ("ProgramFiles(x86)") & "\Graphviz 2.28\bin\"
            path = Environ("TMP") & "\RDP.dot"
            If File.Exists(path) Then
                File.Delete(path)
            End If
            Dim fichier As New FileStream(path, FileMode.CreateNew)
            Dim Writer As New StreamWriter(fichier)
            Writer.Write(GenererDot())
            Writer.Close()
        End If
    End Sub
    Public Function GenererDot() As String
        Dim dot As String = ""
        dot = dot & "digraph ReseauPetri{" & vbCrLf
        dot = dot & "size=""105,10""" & vbCrLf & "spline=true; rankdir=LR;" & vbCrLf & "node[fontsize=9]" & vbCrLf
        For Each trans In TableauTransition
            If TableauTransitionValidable.Contains(trans) Then
                dot = dot & CStr(trans.GetHashCode) & " [shape = box, color = red, label = """ & trans.nom & "\n validable""];" & vbCrLf
            Else
                dot = dot & CStr(trans.GetHashCode) & " [shape = box, color = black, label = """ & trans.nom & "\n non validable""];" & vbCrLf
            End If
        Next
        For Each place In TableauPlace
            dot = dot & CStr(place.GetHashCode) & " [shape = ellipse, color = black, label = """ & place.nom & "\n " & CStr(place.nombreJeton) & """];" & vbCrLf
        Next
        For Each Arc In TableauArc
            If Arc.sens = RDP.Arc.E_Sens.PlaceVersTransition Then
                dot = dot & CStr(Arc.place.GetHashCode) & "->" & CStr(Arc.transition.GetHashCode) & "[label=""" & CStr(Arc.multiplicite) & """]" & ";" & vbCrLf
            Else
                dot = dot & CStr(Arc.transition.GetHashCode) & "->" & CStr(Arc.place.GetHashCode) & "[label=""" & CStr(Arc.multiplicite) & """]" & ";" & vbCrLf
            End If
        Next
        dot = dot & "overlap= false" & vbCrLf & "}"
        Return dot
    End Function
#End Region
End Class