Public Class frmAccCalc
    Dim intPerf As Integer
    Public intGreat As Integer
    Dim intGood As Integer
    Dim intBad As Integer
    Dim intMiss As Integer
    Dim intCombo As Integer
    Dim intScore As Integer
    Dim decAcc As Decimal = 0D
    Public intPerfGrt, intCMax As Integer
    Private Sub FrmAccCalc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPerf.Text = 0
        txtGrt.Text = 0
        txtGood.Text = 0
        txtBad.Text = 0
        txtMiss.Text = 0
        chkBGM.Checked = True
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        frmAbout.Show()
    End Sub

    Private Sub BtnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        intPerf = Integer.Parse(txtPerf.Text)
        intGreat = Integer.Parse(txtGrt.Text)
        intGood = Integer.Parse(txtGood.Text)
        intBad = Integer.Parse(txtBad.Text)
        intMiss = Integer.Parse(txtMiss.Text)
        intCombo = Integer.Parse(txtCombo.Text)

        If emptychk() = True Then
            'Score=(p*perfect index)+(G*great index)+(g*good index)+(b*bad index)+(m*miss index)
            intScore = (intPerf * 4) + (intGreat * 3) + (intGood * 2) + (intBad * 1) + (intMiss * 0)
            'Accuracy = Score/(Max Combo*Perfect Index Multiplication)
            intCMax = intPerf + intGreat + intGood + intBad + intMiss
            decAcc = intScore / (intCMax * 4)
            intPerfGrt = intPerf + intGreat
            If intPerfGrt = intCMax Then
                frmResult.Show()
            End If
            lblTSG.Text = intScore.ToString
            lblAcc.Text = FormatPercent(decAcc.ToString, 2)
        End If
    End Sub

    Private Function emptychk()
        Dim bFlag As Boolean = False
        If txtPerf.Text = "" Then
            MsgBox("Please enter a value!", MsgBoxStyle.Information, "Error")
            Return bFlag
        ElseIf txtCombo.Text = "" Then
            MsgBox("Please enter combo value!", MsgBoxStyle.Information, "Error")
            Return bFlag
        Else
            bFlag = True
            Return bFlag
        End If
    End Function
    Private Sub TxtPerf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPerf.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub
    Private Sub TxtGrt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGrt.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub

    Private Sub TxtGood_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtGood.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub

    Private Sub TxtBad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBad.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub

    Private Sub TxtMiss_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMiss.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub

    Private Sub TxtCombo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCombo.KeyPress
        e.Handled = e.KeyChar <> ChrW(Keys.Back) And Not Char.IsLetter(e.KeyChar) And Not Char.IsDigit(e.KeyChar)
        If e.Handled Then
            Beep()
        End If
    End Sub

    Private Sub ChkBGM_CheckedChanged(sender As Object, e As EventArgs) Handles chkBGM.CheckedChanged

        If chkBGM.Checked = True Then
            My.Computer.Audio.Play(My.Resources.original, AudioPlayMode.BackgroundLoop)
        Else
            My.Computer.Audio.Stop()
        End If
    End Sub
    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPerf.Text = ""
        txtGrt.Text = ""
        txtGood.Text = ""
        txtBad.Text = ""
        txtMiss.Text = ""
        lblAcc.Text = ""
        lblTSG.Text = ""

        txtPerf.Text = 0
        txtGrt.Text = 0
        txtGood.Text = 0
        txtBad.Text = 0
        txtMiss.Text = 0
        txtCombo.Text = 0
    End Sub
End Class
