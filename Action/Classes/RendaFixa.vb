Imports Action.Dao

Namespace classes
    Public Class RendaFixa

#Region "Propriedades"
        Public Property Id As Integer
        Public Property NomeAtivo As String
        Public Property IdTipoRendaFixa As Integer
        Public Property Rendimento As Double

#End Region

#Region "Construtores"

#End Region

#Region "Métodos e funções"

        Public Sub CadastrarRendaFixa(Titulo As RendaFixa)
            Try
                RendaFixaDAO.CadastrarRendaFixa(Titulo)
            Catch ex As Exception

            End Try

        End Sub

        Public Sub AlterarRendaFixa(Titulo As RendaFixa)
            Try
                'RendaFixaDAO.CadastrarRendafixa
            Catch ex As Exception

            End Try

        End Sub

        Public Function ConsultarTipoRendaFixa() As DataTable
            Try
                Return RendaFixaDAO.ConsultarTipoRendaFixa()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function ConsultarRendaFixa(Titulo As RendaFixa) As DataTable
            Try
                'RendaFixaDAO.CadastrarRendafixa
            Catch ex As Exception

            End Try

        End Function

        Public Sub ExcluirRendaFixa(IdRendaFixa As Integer)
            Try
                'RendaFixaDAO.CadastrarRendafixa
            Catch ex As Exception

            End Try

        End Sub
#End Region


    End Class
End Namespace

