Imports Action.DAO
Imports Action.classes


Namespace Controller
    Public Class ControladorRendaFixa

#Region "Classe Renda Fixa"
        Public Sub CadastrarRendaFixa(Titulo As RendaFixa)

            Try
                RendaFixaDAO.CadastrarRendaFixa(Titulo)
            Catch ex As Exception
                Throw ex
            End Try
        End Sub


        Public Sub AlterarRendaFixa(Titulo As RendaFixa)
            Try
                RendaFixaDAO.AlterarRendaFixa(Titulo)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoRendaFixa() As DataTable
            Try
                Return RendaFixaDAO.ConsultarTipoRendaFixa()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function ConsultarRendaFixa() As DataTable
            Try
                Return RendaFixaDAO.ConsultarRendaFixa
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirRendaFixa(IdRendaFixa As Integer)
            Try
                RendaFixaDAO.ExcluirRendaFixa(IdRendaFixa)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub
#End Region

    End Class
End Namespace



