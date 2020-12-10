Imports Action.Classes

Imports Action.DAO

Namespace Controller
    Public Class ControladorInvestimento


        Shared Sub InsereInvestimento(objInvestimento As Investimento)
            Try

                InvestimentoDAO.InsereInvestimento(objInvestimento)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Sub

        Shared Sub AlteraInvestimento(objInvestimento As Investimento)
            Try

                InvestimentoDAO.AlteraInvestimento(objInvestimento)

            Catch ex As Exception

                Throw New Exception(ex.Message)
            End Try
        End Sub

    End Class

End Namespace

