Imports Action.Controller
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
                Dim controle As New Controle
                controle.CadastrarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Sub AlterarAcao(objAcao As Acao)

            Try
                Dim controle As New Controle
                controle.AlterarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Sub ExcluirAcao(IDAcao As Integer)

            Try
                Dim controle As New Controle
                controle.ExcluirAcao(IDAcao)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Function ConsultarAcao() As DataTable
            Try
                Dim controle As New Controle
                Return controle.ConsultarAcao()

            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ConsultarTipoAcao() As DataTable

            Try
                Dim Controle As New Controle
                Return Controle.ConsultarTipoAcao
            Catch ex As Exception
                Throw ex
            End Try
        End Function


#End Region
    End Class
End Namespace

