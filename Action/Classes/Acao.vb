Imports Action.DAO

Namespace classes
    Public Class Acao


#Region "Propriedades"

        Public Property Id As Integer
        Public Property NomeAtivo As String
        Public Property SiglaAtivo As String
        Public Property SetorAtivo As String
        Public Property IdTipoAcao As Integer

#End Region

#Region "Construtores"

#End Region

#Region "Métodos e funções"

        Public Sub CadastrarAcao(objAcao As Acao)

            Try
                AcaoDAO.CadastrarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

#End Region
    End Class
End Namespace

