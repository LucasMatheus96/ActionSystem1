﻿Imports Action.Classes
Imports Action.Controller

Public Class Frm_CadastraRendaFixa


    Dim NovaRendaFixa As New RendaFixa
    Dim controlRendaFixa As New ControladorRendaFixa
    Dim Dt As New DataTable

    Public idRendaFixa As Integer


    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().
        Me.Text = "Cadastrando Titulo"
        Dt = controlRendaFixa.ConsultarTipoRendaFixa
        Cmb_TipoTitulo.Items.Clear()
        Cmb_TipoTitulo.DropDownStyle = ComboBoxStyle.DropDownList

        For i As Integer = 0 To Dt.Rows.Count - 1
            Cmb_TipoTitulo.Items.Add(Dt.Rows(i)("SIGLA"))
        Next


    End Sub

    Private Sub Btn_Cancelar_Click(sender As Object, e As EventArgs) Handles Btn_Cancelar.Click
        Me.Close()

    End Sub

    Private Sub Btn_Limpar_Click(sender As Object, e As EventArgs) Handles Btn_Limpar.Click
        LimparCampo()
    End Sub

    Private Sub Btn_Cadastrar_Click(sender As Object, e As EventArgs) Handles Btn_Cadastrar.Click

        Try
            If ValidaCampos() = False Then

                If idRendaFixa > 0 Then
                    NovaRendaFixa.Id = idRendaFixa
                    NovaRendaFixa.NomeAtivo = txt_titulo.Text
                    NovaRendaFixa.IdTipoRendaFixa = Cmb_TipoTitulo.SelectedIndex + 1
                    NovaRendaFixa.Rendimento = Val(TxT_RentabilidadeTitulo.Text)
                    controlRendaFixa.AlterarRendaFixa(NovaRendaFixa)
                    MessageBox.Show("Titulo alterado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.Close()

                Else
                    NovaRendaFixa.NomeAtivo = txt_titulo.Text
                    NovaRendaFixa.IdTipoRendaFixa = Cmb_TipoTitulo.SelectedIndex + 1
                    NovaRendaFixa.Rendimento = Val(TxT_RentabilidadeTitulo.Text)
                    controlRendaFixa.CadastrarRendaFixa(NovaRendaFixa)

                    MessageBox.Show("Titulo cadastrado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimparCampo()
                End If

            End If
        Catch ex As Exception

            Throw ex
        End Try


    End Sub

    Private Function ValidaCampos() As Boolean
        Try
            Dim vRetorno As Boolean

            If txt_titulo.Text = String.Empty Then

                MessageBox.Show("O nome do titulo não foi preenchido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                txt_titulo.Focus()
                vRetorno = True
            ElseIf Cmb_TipoTitulo.SelectedItem = Nothing Then
                MessageBox.Show("Selecione o tipo Do titulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Cmb_TipoTitulo.Focus()
                vRetorno = True

            ElseIf TxT_RentabilidadeTitulo.Text = String.Empty Then

                MessageBox.Show("Informe a rentabilidade do titulo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TxT_RentabilidadeTitulo.Focus()
                vRetorno = True

            Else
                vRetorno = False
            End If


            Return vRetorno
        Catch ex As Exception

            Throw ex
        End Try


    End Function

    Private Sub LimparCampo()
        Try
            txt_titulo.Text = String.Empty
            TxT_RentabilidadeTitulo.Text = String.Empty
            Cmb_TipoTitulo.SelectedIndex = -1
        Catch ex As Exception
            Throw ex
        End Try


    End Sub


End Class