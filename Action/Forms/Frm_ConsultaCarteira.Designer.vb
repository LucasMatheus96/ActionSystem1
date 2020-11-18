<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Frm_ConsultaCarteira
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ConsultaCarteira))
        Me.Grb_ConsultaCarteira = New System.Windows.Forms.GroupBox()
        Me.Lbl_a = New System.Windows.Forms.Label()
        Me.txt_busca2 = New System.Windows.Forms.TextBox()
        Me.txt_busca1 = New System.Windows.Forms.TextBox()
        Me.Cmb_Filtro = New System.Windows.Forms.ComboBox()
        Me.lbl_Filtro = New System.Windows.Forms.Label()
        Me.Lsw_VerCarteira = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Grb_ConsultaCarteira.SuspendLayout()
        Me.SuspendLayout()
        '
        'Grb_ConsultaCarteira
        '
        Me.Grb_ConsultaCarteira.Controls.Add(Me.Lbl_a)
        Me.Grb_ConsultaCarteira.Controls.Add(Me.txt_busca2)
        Me.Grb_ConsultaCarteira.Controls.Add(Me.txt_busca1)
        Me.Grb_ConsultaCarteira.Controls.Add(Me.Cmb_Filtro)
        Me.Grb_ConsultaCarteira.Controls.Add(Me.lbl_Filtro)
        Me.Grb_ConsultaCarteira.Location = New System.Drawing.Point(12, 12)
        Me.Grb_ConsultaCarteira.Name = "Grb_ConsultaCarteira"
        Me.Grb_ConsultaCarteira.Size = New System.Drawing.Size(503, 100)
        Me.Grb_ConsultaCarteira.TabIndex = 1
        Me.Grb_ConsultaCarteira.TabStop = False
        Me.Grb_ConsultaCarteira.Text = "GroupBox1"
        '
        'Lbl_a
        '
        Me.Lbl_a.AutoSize = True
        Me.Lbl_a.Location = New System.Drawing.Point(298, 47)
        Me.Lbl_a.Name = "Lbl_a"
        Me.Lbl_a.Size = New System.Drawing.Size(13, 13)
        Me.Lbl_a.TabIndex = 4
        Me.Lbl_a.Text = "a"
        '
        'txt_busca2
        '
        Me.txt_busca2.Location = New System.Drawing.Point(321, 43)
        Me.txt_busca2.Name = "txt_busca2"
        Me.txt_busca2.Size = New System.Drawing.Size(100, 20)
        Me.txt_busca2.TabIndex = 3
        '
        'txt_busca1
        '
        Me.txt_busca1.Location = New System.Drawing.Point(185, 43)
        Me.txt_busca1.Name = "txt_busca1"
        Me.txt_busca1.Size = New System.Drawing.Size(100, 20)
        Me.txt_busca1.TabIndex = 2
        '
        'Cmb_Filtro
        '
        Me.Cmb_Filtro.FormattingEnabled = True
        Me.Cmb_Filtro.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Cmb_Filtro.Items.AddRange(New Object() {"Selecione", "Data", "Nome da Carteira"})
        Me.Cmb_Filtro.Location = New System.Drawing.Point(28, 42)
        Me.Cmb_Filtro.Name = "Cmb_Filtro"
        Me.Cmb_Filtro.Size = New System.Drawing.Size(135, 21)
        Me.Cmb_Filtro.TabIndex = 1
        '
        'lbl_Filtro
        '
        Me.lbl_Filtro.AutoSize = True
        Me.lbl_Filtro.Location = New System.Drawing.Point(25, 26)
        Me.lbl_Filtro.Name = "lbl_Filtro"
        Me.lbl_Filtro.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Filtro.TabIndex = 0
        Me.lbl_Filtro.Text = "Filtros"
        '
        'Lsw_VerCarteira
        '
        Me.Lsw_VerCarteira.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.Lsw_VerCarteira.FullRowSelect = True
        Me.Lsw_VerCarteira.GridLines = True
        Me.Lsw_VerCarteira.HideSelection = False
        Me.Lsw_VerCarteira.Location = New System.Drawing.Point(12, 118)
        Me.Lsw_VerCarteira.MultiSelect = False
        Me.Lsw_VerCarteira.Name = "Lsw_VerCarteira"
        Me.Lsw_VerCarteira.Size = New System.Drawing.Size(503, 316)
        Me.Lsw_VerCarteira.TabIndex = 2
        Me.Lsw_VerCarteira.UseCompatibleStateImageBehavior = False
        Me.Lsw_VerCarteira.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Codigo"
        Me.ColumnHeader1.Width = 74
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Nome da carteira"
        Me.ColumnHeader2.Width = 226
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Data de cadastro"
        Me.ColumnHeader3.Width = 116
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Operador"
        Me.ColumnHeader4.Width = 65
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 448)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Alterar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(197, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(142, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Excluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(363, 448)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(152, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Cancelar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Frm_ConsultaCarteira
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 508)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Lsw_VerCarteira)
        Me.Controls.Add(Me.Grb_ConsultaCarteira)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Frm_ConsultaCarteira"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Frm_ConsultaCarteira"
        Me.Grb_ConsultaCarteira.ResumeLayout(False)
        Me.Grb_ConsultaCarteira.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Grb_ConsultaCarteira As GroupBox
    Friend WithEvents Cmb_Filtro As ComboBox
    Friend WithEvents lbl_Filtro As Label
    Friend WithEvents Lsw_VerCarteira As ListView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents txt_busca2 As TextBox
    Friend WithEvents txt_busca1 As TextBox
    Friend WithEvents Lbl_a As Label
End Class
