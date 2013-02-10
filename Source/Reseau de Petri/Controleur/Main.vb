#Region "Importations namespaces"
Imports System
Imports System.ComponentModel 'Importation necessaire à l'utilisation des bindingList
Imports System.Collections.Generic
Imports System.IO
Imports System.Runtime.Serialization
Imports System.Xml
#End Region
''' <summary>
''' Cette classe réalise à la fois la vue et le controleur principal de l'application.
''' </summary>
''' <remarks></remarks>
Public Class Main
#Region "Attributs privés" 'déclaration des attributs privés de la classe main
    Public WithEvents ReseauDePetri As New Reseau()
#End Region
#Region "Gestion du log" 'Gestion de l'affichage des évènements sur la console
    Private Sub AffichageRTB(ByVal sender As Object, ByVal e As ChangementReseauEventArgs) Handles ReseauDePetri.ReseauChange
        RTB_Console.SelectionColor = e.Couleur
        RTB_Console.AppendText(e.Text)
    End Sub
#End Region
#Region "Gestion Treeview" 'méthode permettant la mise à jour et l'affichage de l'arborescence après chaque entrée de données (si on check affichage des données dans l'intérface)
    Private Sub Maj_Treeview() Handles ChB_verbose.CheckedChanged
        TV_Donnée.Nodes.Clear()
        TV_Donnée.Nodes.Add(ReseauDePetri.RetournerEquivalenceTreeNode())
        TV_Donnée.ExpandAll()
    End Sub
#End Region
#Region "Mise à jour"
    Public Delegate Sub MajDataBindingEventHandler(ByVal sender As Object, ByVal e As MajDataBindingEventArgs)
    Public Event MajDataBinding As MajDataBindingEventHandler
    Private Sub MAJ_DataBindingList(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load, B_AddPlace.Click, B_AddTrans.Click, Me.MajDataBinding
        Me.CB_place.DataSource = ReseauDePetri.TableauPlace
        Me.CB_trans.DataSource = ReseauDePetri.TableauTransition
    End Sub
    Private Sub Maj_Treeview(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_verbose.CheckedChanged

    End Sub
#End Region
#Region "Entrée des paramètres" 'méthode permettant de gérer la relation entre les composants de l'intérface et l'entrée des données de la simulation
    Private Sub B_AddPlace_Click(ByVal sender As Object, ByVal e As EventArgs) Handles B_AddPlace.Click 'ajout d'une place et des attributs relatifs à celle ci, gestion des évenements, et mise à jour du treeview
        ReseauDePetri.TableauPlace.Add(New Place(CUInt(TB_Place_Nombre.Text), TB_Place_Nom.Text))
        ReseauDePetri.EnvoyerReseauChange("La place '" & TB_Place_Nom.Text & "' contenant " & TB_Place_Nombre.Text & " jeton(s) a été ajoutée au réseau." & vbCrLf)
        Maj_Treeview()
    End Sub
    Private Sub B_AddTrans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_AddTrans.Click 'ajout d'une transition et des attributs relatifs à celle ci, gestion des évenements, et mise à jour du treeview
        ReseauDePetri.TableauTransition.Add(New Transition(TB_Trans_Nom.Text))
        ReseauDePetri.EnvoyerReseauChange("La transition '" & TB_Trans_Nom.Text & "' a été ajoutée au réseau." & vbCrLf)
        Maj_Treeview()
    End Sub
    Private Sub B_AddArc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_AddArc.Click 'ajout d'un arc et des attributs relatifs à ce dérnier, gestion des évenements, et mise à jour du treeview
        Dim sens As Arc.E_Sens
        If CB_sens.SelectedItem.ToString = "P -> T" Then
            sens = Arc.E_Sens.PlaceVersTransition
            ReseauDePetri.EnvoyerReseauChange("L'arc de multiplicité " & TB_mult.Text & " reliant la place '" & CType(CB_place.SelectedItem, Place).nom & "' à la transition '" & CType(CB_trans.SelectedItem, Transition).nom & "' a été ajoutée au réseau." & vbCrLf, Color.Black)
        ElseIf CB_sens.SelectedItem.ToString = "T -> P" Then
            sens = Arc.E_Sens.TransitionVersPlace
            ReseauDePetri.EnvoyerReseauChange("L'arc de multiplicité " & TB_mult.Text & "reliant la transition '" & CType(CB_trans.SelectedItem, Transition).nom & "' à la place '" & CType(CB_place.SelectedItem, Place).nom & "' a été ajoutée au réseau." & vbCrLf, Color.Black)
        End If
        If CUInt(TB_mult.Text) > 1 Then
            ReseauDePetri.TableauArc.Add(New Arc(CType(CB_place.SelectedItem, Place), CType(CB_trans.SelectedItem, Transition), sens, CUInt(TB_mult.Text)))

        Else
            ReseauDePetri.TableauArc.Add(New Arc(CType(CB_place.SelectedItem, Place), CType(CB_trans.SelectedItem, Transition), sens))
        End If
        Maj_Treeview()
    End Sub
    Private Sub ChB_Timer_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Timer.CheckedChanged
        If ChB_Timer.Checked = True Then
            TBK.Visible = True
            Label8.Visible = True
        Else
            TBK.Visible = False
            Label8.Visible = False
        End If
    End Sub

    Private Sub TBK_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TBK.Scroll
        If Int(TBK.Value) = 1 Then
            Label8.Text = CStr(Int(TBK.Value)) & " milliseconde"
        Else
            Label8.Text = CStr(Int(TBK.Value)) & " millisecondes"
        End If
    End Sub
#End Region
#Region "Simulation"
    Private Sub B_Go_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Go.Click, LancerLaSimulationToolStripMenuItem.Click
        RTB_Console.AppendText(vbCrLf & "**** Début de la simulation ****" & vbCrLf)
        ReseauDePetri.GenererEtat("Initial")
        ReseauDePetri.EnregistrerDot()
        RTB_Console.AppendText(vbCrLf)
        RTB_Console.SelectionIndent = 20
        ReseauDePetri.Maj_TransitionValidable()
        Dim index As Integer = 1
        If ChB_Timer.Checked = True Then
            Timer.Interval = TBK.Value
            Timer.Start()
            While ReseauDePetri.TableauTransitionValidable.Count > 0 And index < CInt(TB_etapeMax.Text) + 1
                'Case d'attente
            End While
            Timer.Stop()
        Else
            While ReseauDePetri.TableauTransitionValidable.Count > 0 And index < CInt(TB_etapeMax.Text) + 1
                Simulation()
                index += 1
            End While
        End If
        RTB_Console.AppendText("La simulation a effectué " & CStr(index - 1) & " étapes" & vbCrLf)
        RTB_Console.SelectionIndent = 0
        RTB_Console.AppendText(vbCrLf)
        ReseauDePetri.GenererEtat("Final")
        RTB_Console.AppendText("**** Fin de Simulation ****" & vbCrLf)
    End Sub
    Public Sub Simulation() Handles Timer.Tick
        ReseauDePetri.ValiderTransition(ReseauDePetri.ChoixHasard_TransitionValidable())
        ReseauDePetri.Maj_TransitionValidable()
    End Sub
#End Region
#Region "Evenement fenetre"
    Private Sub On_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        ReseauDePetri = New Reseau()
        RTB_Console.Clear()
        ReseauDePetri.EnvoyerReseauChange("Le réseau a été remis à zéro." & vbCrLf, Color.LimeGreen)
        Maj_Treeview()
        TV_Donnée.ExpandAll()
    End Sub
#End Region
#Region "Interface menu" 'gestion de l'intérface menu
    Private Sub QuitterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitterToolStripMenuItem.Click 'quitter l'intérface
        Me.Close()
    End Sub

    Private Sub NouvelleSimulationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouvelleSimulationToolStripMenuItem.Click 'réinitialiser le contenu du reseau, pour commencer une nouvelle simulation
        ReseauDePetri = New Reseau()
        RTB_Console.Clear()
        ReseauDePetri.EnvoyerReseauChange("Le réseau a été remis à zéro." & vbCrLf, Color.LimeGreen)
        Maj_Treeview()

        CB_place.DataSource = Nothing
        CB_place.Items.Clear()
        CB_place.DataSource = ReseauDePetri.TableauPlace
        CB_trans.DataSource = Nothing
        CB_trans.Items.Clear()
        CB_trans.DataSource = ReseauDePetri.TableauTransition
        RaiseEvent MajDataBinding(Me, New MajDataBindingEventArgs())
    End Sub
    Private Sub SauvegarderLaSimulationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SauvegarderLaSimulationToolStripMenuItem.Click 'sauvegarder la simulationion
        SFD_enregistrement.ShowDialog()
        Dim Path As String = SFD_enregistrement.InitialDirectory + SFD_enregistrement.FileName
        If Path <> "" Then
            Serialisation(Path)
            ReseauDePetri.EnvoyerReseauChange("Le fichier " & Path & " a été convenablement sauvegardé." & vbCrLf)
        Else
            ReseauDePetri.EnvoyerReseauChange("Sauvegarde annulée." & vbCrLf, Color.Maroon)
        End If
    End Sub

    Private Sub ChargerSimulationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargerSimulationToolStripMenuItem.Click 'charger la simulation
        OFD_chargement.ShowDialog()
        Dim Path As String = OFD_chargement.InitialDirectory + OFD_chargement.FileName
        If Path <> "" Then
            DeSerialisation(Path)
            Maj_Treeview()
            ReseauDePetri.EnvoyerReseauChange("Le fichier " & Path & " a été convenablement chargé." & vbCrLf, Color.Maroon)
            ReseauDePetri.GenererEtat()
            ReseauDePetri.EnvoyerReseauChange("**** Fin de l'importation ****" & vbCrLf, Color.Maroon)
            RaiseEvent MajDataBinding(Me, New MajDataBindingEventArgs())
        Else
            ReseauDePetri.EnvoyerReseauChange("Importation annulée." & vbCrLf, Color.Maroon)
        End If
    End Sub
    Private Sub SauvegarderLesDonnéesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SauvegarderLesDonnéesToolStripMenuItem.Click

    End Sub
#End Region
#Region "Serialisation et déserialisation"
    Public Sub Serialisation(ByVal _path As String)
        Dim pref As New XmlWriterSettings()
        pref.Indent = True
        pref.IndentChars = vbTab
        pref.NamespaceHandling = NamespaceHandling.OmitDuplicates
        pref.OmitXmlDeclaration = False
        Dim xmlFichier As XmlWriter = XmlWriter.Create(_path, pref)
        Dim bf_reseau As DataContractSerializer = New DataContractSerializer(GetType(Reseau))
        bf_reseau.WriteObject(xmlFichier, ReseauDePetri)
        xmlFichier.Close()
    End Sub
    Public Sub DeSerialisation(ByVal _path As String)
        Dim bf_reseau As DataContractSerializer = New DataContractSerializer(GetType(Reseau))
        Try
            Dim xmlFichier As FileStream = New FileStream(_path, FileMode.Open, FileAccess.Read)
            xmlFichier.Seek(0, IO.SeekOrigin.Begin)
            ReseauDePetri = CType(bf_reseau.ReadObject(xmlFichier), Reseau)
            xmlFichier.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        ReseauDePetri.Maj_TransitionValidable()
    End Sub
#End Region
#Region "Graphviz"
    Private Sub ChB_Graph_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChB_Graph.CheckedChanged 'afficher le reseau sur Graphviz si voulu, ou un message indiquant que l'on doit installer graphviz pour visualiser la simulation
        If Directory.Exists(Environ("ProgramFiles(x86)") & "\Graphviz 2.28") Then
            Graphe_Fenetre.Show(Me)
        ElseIf ChB_Graph.Checked = True Then
            MsgBox("Merci d'installer Graphviz 2.8 dans ProgramFiles", MsgBoxStyle.Critical)
            ChB_Graph.Checked = False
        End If
    End Sub
    Public Sub LienGraphe() Handles ReseauDePetri.ReseauChange
        If ChB_Graph.Checked = True Then
            Graphe_Fenetre.ExecuterDot()
        End If
    End Sub
#End Region
End Class