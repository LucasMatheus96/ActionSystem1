Imports Action.Controller
Imports Action.DAO

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
                Dim controle As New Controle
                controle.CadastrarRendaFixa(Titulo)
            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Sub AlterarRendaFixa(Titulo As RendaFixa)
            Try
                Dim controle As New Controle
                controle.CadastrarRendaFixa(Titulo)
            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Sub

        Public Function ConsultarTipoRendaFixa() As DataTable
            Try
                Dim controle As New Controle
                Return controle.ConsultarTipoRendaFixa()

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Function ConsultarRendaFixa() As DataTable
            Try
                Dim controle As New Controle

                Return controle.ConsultarRendaFixa
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Function

        Public Sub ExcluirRendaFixa(IdRendaFixa As Integer)
            Try
                Dim controle As New Controle
                controle.ExcluirRendaFixa(IdRendaFixa)
            Catch ex As Exception
                Throw New Exception(ex.Message)
            End Try

        End Sub
#End Region


    End Class
End Namespace

