Imports Action.Conexao
Imports Action.Controller
Imports Action.DAO

Namespace classes
    Public Class Carteira

#Region "Propriedades"
        Public Property Id As Integer
        Public Property NomeCarteira As String
        Public Property DataCadastro As DateTime
        Public Property operador As Integer
#End Region
#Region "Construtores"

#End Region
#Region "Funções"

        Public Function ConsultarCarteira() As DataTable

            Try
                Dim Controle As New Controle
                Return Controle.ConsultarCarteira()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try


        End Function

        Public Function CadastrarCarteira(carteira As Carteira) As String

            Try
                Dim Controle As New Controle
                Controle.CadastrarCarteira(carteira)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Cadastro Efetuado com sucesso.")
        End Function

        Public Function AtualizarCarteira(carteira As Carteira) As String
            Try
                Dim Controle As New Controle
                Controle.AtualizarCarteira(carteira)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return MsgBox("Carteira Alterada com Sucesso.")
        End Function

        Public Function ExcluirCarteira(IdCliente As Integer, Optional NomeCarteira As String = "") As String

            Try
                Dim Controle As New Controle
                Controle.ExcluirCarteira(IdCliente, NomeCarteira)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Carteira Excluida com sucesso.")
        End Function
#End Region
    End Class

End Namespace
