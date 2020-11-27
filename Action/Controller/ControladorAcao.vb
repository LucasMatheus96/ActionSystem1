Imports Action.DAO
Imports Action.classes

Namespace Controller
    Public Class ControladorAcao
#Region "Classe Ação"

        Public Sub CadastrarAcao(objAcao As Acao)

            Try
                AcaoDAO.CadastrarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Sub AlterarAcao(objAcao As Acao)

            Try
                AcaoDAO.AlterarAcao(objAcao)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarAcao() As DataTable

            Try
                Return AcaoDAO.ConsultarAcao()
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirAcao(IdAcao As Integer)

            Try
                AcaoDAO.ExcluirAcao(IdAcao)

            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoAcao() As DataTable
            Try
                Return AcaoDAO.ConsultarTipoAcao()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

#End Region
    End Class
End Namespace

