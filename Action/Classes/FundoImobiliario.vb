Imports Action.Controller

Namespace classes
    Public Class FundoImobiliario


#Region "PROPRIEDADES"

        Public Property ID As Integer
        Public Property NomeAtivo As String
        Public Property SiglaAtivo As String
        Public Property IdTipoFundoImobiliario As Integer

#End Region

#Region "Construtores"

#End Region

#Region "Métodos e Funções"

        Public Sub CadastrarFundoImobiliario(ObjFundoImobiliario As FundoImobiliario)

            Try

                Dim Controle As New Controle
                Controle.CadastrarFundoImobiliario(ObjFundoImobiliario)

            Catch ex As Exception
                Throw ex
            End Try
        End Sub

        Public Sub AlterarFundoImobliario(ObjFundoImobiliario As FundoImobiliario)

            Try

                Dim Controle As New Controle
                Controle.AlterarFundoImobiliario(ObjFundoImobiliario)

            Catch ex As Exception
                Throw ex
            End Try


        End Sub

        Public Sub ExcluirFundoImobiliario(IdFundoImobiliario As Integer)

            Try

                Dim Controle As New Controle
                Controle.ExcluirFundoImobiliario(IdFundoImobiliario)

            Catch ex As Exception
                Throw ex
            End Try

        End Sub

        Public Function ConsultarFundoImobiliario() As DataTable
            Try
                Dim controle As New Controle
                Return controle.ConsultarFundoImobiliario
            Catch ex As Exception
                Throw ex
            End Try
        End Function

        Public Function ConsultarTipoFundoImobiliario() As DataTable
            Try
                Dim controle As New Controle
                Return controle.ConsultarTipoFundoImobiliario

            Catch ex As Exception
                Throw ex
            End Try

        End Function
#End Region
    End Class
End Namespace

