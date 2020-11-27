Imports Action.classes
Imports Action.DAO

Namespace Controller
    Public Class ControladorFundoImobiliario
#Region "Classe Fundo imobiliario"

        Public Sub CadastrarFundoImobiliario(objFundoImobiliario As FundoImobiliario)
            Try
                Dim FundoImobiliarioDAO As New FundoImobiliarioDAO

                FundoImobiliarioDAO.CadastrarFundoImobiliario(objFundoImobiliario)
            Catch ex As Exception

                Throw ex
            End Try

        End Sub

        Public Sub AlterarFundoImobiliario(objFundoImobiliario As FundoImobiliario)

            Try
                FundoImobiliarioDAO.AlterarFundoImobiliario(objFundoImobiliario)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarFundoImobiliario() As DataTable

            Try
                Return FundoImobiliarioDAO.ConsultarFundoImobiliario()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirFundoImobiliario(IdFundoImobiliario As Integer)

            Try
                FundoImobiliarioDAO.ExcluirFundoImobiliario(IdFundoImobiliario)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoFundoImobiliario() As DataTable
            Try
                Return FundoImobiliarioDAO.ConsultarTipoFundoImobiliario()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function
#End Region
    End Class
End Namespace

