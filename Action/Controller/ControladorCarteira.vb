Imports Action.classes
Imports Action.DAO

Namespace Controller
    Public Class ControladorCarteira
#Region "Classe Carteira"


        Public Function ConsultarCarteira() As DataTable

            Try

                Return CarteiraDAO.DBConsultarCarteira()
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
            Return MessageBox.Show("Cadastro Efetuado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
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

        Public Function PesquisarCarteira(nome As String) As DataTable
            Try
                Return CarteiraDAO.DbPesquisaNomeCarteira(nome)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function PesquisarCarteiraData(dataInicial As Date, dataFinal As Date) As DataTable
            Try
                Return CarteiraDAO.DbPesquisaCarteiraPorData(dataInicial, dataFinal)
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function FiltrarCarteiraPorOperadorLogado(idOperador As Integer)
            Try
                Return CarteiraDAO.DbFiltraCarteiraPorUsuario(idOperador)
            Catch ex As Exception
                Throw ex
            End Try
        End Function
#End Region
    End Class
End Namespace

