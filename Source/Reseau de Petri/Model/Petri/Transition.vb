Imports System.Runtime.Serialization
''' <summary>
''' La classe transition représente les transitions dans un réseau de pétri.
''' Elle ne comporte qu'un seul attribut privé, son nom.
''' </summary>
''' <remarks>Pour plus d'information sur la partie théorique : http://fr.wikipedia.org/wiki/R%C3%A9seau_de_Petri </remarks>
<DataContract(IsReference:=True, Name:="Transition")> _
Public Class Transition
#Region "Attribut Privé" 'déclaration des attributs privés de la classe transition
    Private _nom As String
#End Region
#Region "Constructeur" 'mise en place des constructeurs liés à cette classe, qui permettront d'initialiser l'instanciation des objets liés à la classe.
    Public Sub New()

    End Sub
    Public Sub New(ByVal p_nom As String)
        _nom = p_nom
    End Sub
#End Region
#Region "Property" 'mise en place des méthodes (get et set)qui gèrent les attributs de la classe hors de celle ci, en utilisant Property
    <DataMember(Name:="Nom_de_la_transition", Order:=1, EmitDefaultValue:=True)>
    Public Property nom() As String
        Get
            Return _nom
        End Get
        Set(ByVal p_nom As String)
            _nom = p_nom
        End Set
    End Property
#End Region
#Region "Surcharge de ToString()"
    Public Overrides Function ToString() As String
        Dim hash As String
        If Main.ChB_verbose.Checked Then
            hash = " [" & MyBase.GetHashCode & "]"
        Else
            hash = ""
        End If
        Return _nom & hash
    End Function
#End Region
End Class