Imports Action.classes
Imports Action.DAO

Namespace Controller
    Public Class ControladorCarteira
#Region "Classe Carteira"


        Public Function ConsultarCarteira() As DataTable

            Try

                Return CarteiraDAO.DbConsultarUsuario()
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try


        End Function

        Public Function CadastrarCarteira(carteira As Carteira) As String

            Try
                CarteiraDAO.DBCadastrarCarteira(carteira)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Cadastro Efetuado com sucesso.")
        End Function

        Public Function AtualizarCarteira(carteira As Carteira) As String
            Try
                CarteiraDAO.DBAtualizaCarteira(carteira)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

            Return MsgBox("Carteira Alterada com Sucesso.")
        End Function

        Public Function ExcluirCarteira(IdCliente As Integer, Optional NomeCarteira As String = "") As String

            Try
                CarteiraDAO.DBExcluirCarteira(IdCliente, NomeCarteira)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try
            Return MsgBox("Carteira Excluida com sucesso.")
        End Function
#End Region
    End Class
End Namespace

