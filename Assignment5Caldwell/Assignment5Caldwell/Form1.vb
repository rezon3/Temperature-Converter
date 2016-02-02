Public Class Form1
    Dim currentTemp As Decimal
    Dim tempFahrenheit As Decimal
    Dim tempCelsius As Decimal
    Dim tempKelvin As Decimal
    Dim tempRankine As Decimal

    Private Sub rdoCelsius_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCelsius.CheckedChanged
        'Label displays for Current Temp entry and calculation outputs when Celsius is checked
        If rdoCelsius.Checked = True Then
            lblTemp.Text = "Celsius"
            lblCelFahr.Text = "Fahrenheit"
            lblKelvin.Text = "Kelvin"
            lblRankine.Text = "Rankine"
            CalculateTemp()
        End If
    End Sub

    Private Sub rdoFahrenheit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoFahrenheit.CheckedChanged
        'Label displays for Current Temp entry and calculation outputs when Fahrenheit is checked
        If rdoFahrenheit.Checked = True Then
            lblTemp.Text = "Fahrenheit"
            lblCelFahr.Text = "Celsius"
            lblKelvin.Text = "Kelvin"
            lblRankine.Text = "Rankine"
            CalculateTemp()
        End If
    End Sub

    Private Sub rdoKelvin_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKelvin.CheckedChanged
        'Label displays for Current Temp entry and calculation outputs when Kelvin is checked
        If rdoKelvin.Checked = True Then
            lblTemp.Text = "Kelvin"
            lblCelFahr.Text = "Celsius"
            lblKelvin.Text = "Fahrenheit"
            lblRankine.Text = "Rankine"
            CalculateTemp()
        End If
    End Sub

    Private Sub rdoRankine_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRankine.CheckedChanged
        'Label displays for Current Temp entry and calculation outputs when Rankine is checked
        If rdoRankine.Checked = True Then
            lblTemp.Text = "Rankine"
            lblCelFahr.Text = "Celsius"
            lblKelvin.Text = "Fahrenheit"
            lblRankine.Text = "Kelvin"
            CalculateTemp()
        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateTemp()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtBoxCurrent.Clear()
        lblOutput1.Text = ""
        lblOutput2.Text = ""
        lblOutput3.Text = ""
    End Sub

    Private Sub CalculateTemp()
        Try
            'Assign value for text in Current Temp text box
            currentTemp = Decimal.Parse(txtBoxCurrent.Text)
            If rdoCelsius.Checked = True Then
                'Fahrenheit calculation
                tempFahrenheit = (currentTemp * 9 / 5) + 32
                'Kelvin calculation
                tempKelvin = currentTemp + 273.15
                'Rankine calculation
                tempRankine = currentTemp * 1.8 + 491.67
                'Output
                lblOutput1.Text = tempFahrenheit.ToString("n") & "°"
                lblOutput2.Text = tempKelvin.ToString("n") & "°"
                lblOutput3.Text = tempRankine.ToString("n") & "°"
            End If
            If rdoFahrenheit.Checked = True Then
                'Celsius calculation
                tempCelsius = (currentTemp - 32) * 5 / 9
                'Kelvin calculation
                tempKelvin = ((currentTemp - 32) / 1.8) + 273.15
                'Rankine calculation
                tempRankine = (currentTemp - 32) + 491.67
                'Output
                lblOutput1.Text = tempCelsius.ToString("n") & "°"
                lblOutput2.Text = tempKelvin.ToString("n") & "°"
                lblOutput3.Text = tempRankine.ToString("n") & "°"
            End If
            If rdoKelvin.Checked = True Then
                'Celsius calculation
                tempCelsius = currentTemp - 273.15
                'Fahrenheit calculation
                tempFahrenheit = ((currentTemp - 273.15) * 1.8) + 32
                'Rankine calculation
                tempRankine = ((currentTemp - 273.15) * 1.8) + 491.67
                'Output
                lblOutput1.Text = tempCelsius.ToString("n") & "°"
                lblOutput2.Text = tempFahrenheit.ToString("n") & "°"
                lblOutput3.Text = tempRankine.ToString("n") & "°"
            End If
            If rdoRankine.Checked = True Then
                'Celsius calculation
                tempCelsius = (currentTemp - 491.67) / 1.8
                'Fahrenheit calculation
                tempFahrenheit = (currentTemp - 491.67) + 32
                'Kelvin calculation
                tempKelvin = ((currentTemp - 491.67) / 1.8) + 273.15
                'Output
                lblOutput1.Text = tempCelsius.ToString("n") & "°"
                lblOutput2.Text = tempFahrenheit.ToString("n") & "°"
                lblOutput3.Text = tempKelvin.ToString("n") & "°"
            End If
        Catch ex As Exception
            MessageBox.Show("Please enter a numeric value for current temperature")
        End Try
    End Sub
End Class