<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCalculadora.aspx.cs" Inherits="ProyectoCalculadora.FrmCalculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
    .auto-style2 {
        font-size: x-large;
    }
    .auto-style3 {
        font-size: medium;
        margin-bottom: 0px;
    }
    .auto-style4 {
        font-size: xx-large;
    }
    .auto-style5 {
        font-size: medium;
    }
    .btn-calculadora { 
        width: 50px; /* Establece el ancho deseado para los botones */
        height: 50px; /* Establece la altura deseada para los botones */
        margin-right: 2px; 
        margin-bottom: -5px;
    }
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <p>
            <strong>
            <asp:Label ID="CALCULADORA" runat="server" BackColor="#006699" BorderStyle="None" CssClass="btn-calculadora" Text="CALCULADORA" Width="215px" style="padding-left: 60px;" height= "25px"> </asp:Label>
            </strong>
        </p>
        <p>
            <asp:TextBox ID="txtPrincipal" runat="server" BackColor="#FFFFEA" Height="50px" Width="260px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnRaiz" runat="server" Text="R" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick=" btnRaiz_Click" />
            <asp:Button ID="btnborratodo" runat="server" Text="C" BackColor="#A9C6E2" CssClass="btn-calculadora"    OnClick="btnBorrarTodo_Click"/>
            <asp:Button ID="btnborrar" runat="server" Text="borrar" BackColor="#A9C6E2" CssClass="btn-calculadora"   OnClick=" btnBorrar_Click" />
            <asp:Button ID="Button13" runat="server" Text="n!" BackColor="#A9C6E2" CssClass="btn-calculadora" OnClick="Button13_Click"   />
            <asp:Button ID="btnDiv" runat="server" Text="/" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="  btnDiv_Click"  />
        </p>
        <p>
            <asp:Button ID="btnelevaranumero" runat="server" Text="x^y" BackColor="#A9C6E2" CssClass="btn-calculadora" OnClick="btnPotencia_Click" />    
            <asp:Button ID="btn7" runat="server" Text="7" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn7_Click"  />
            <asp:Button ID="btn8" runat="server" Text="8" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn8_Click"  />
            <asp:Button ID="btn9" runat="server" Text="9" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn9_Click"  />
           <asp:Button ID="btnPor" runat="server" Text="X" BackColor="#A9C6E2" CssClass="btn-calculadora" OnClick= "btnPor_Click" />
            <asp:Button ID="BtnElev" runat="server" Text="^" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="  btnElev_Click"  />

            <br />
            <asp:Button ID="Button12" runat="server" Text="10^x" BackColor="#A9C6E2" CssClass="btn-calculadora" OnClick="Button12_Click"  />
            <asp:Button ID="btn4" runat="server" Text="4" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn4_Click"  />
            <asp:Button ID="btn5" runat="server" Text="5" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn5_Click"  />
            <asp:Button ID="btn6" runat="server" Text="6" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn6_Click"  />
            <asp:Button ID="btnMenos" runat="server" Text="-" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="btnMenos_Click" />
        </p>
        <asp:Button ID="Button16" runat="server" Text="log" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="btnLog_Click"  />
        <asp:Button ID="btn1" runat="server" Text="1" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn1_Click"  />
        <asp:Button ID="btn2" runat="server" Text="2" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn2_Click" />
        <asp:Button ID="btn3" runat="server" Text="3" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="btn3_Click"  />
        <asp:Button ID="btnMas" runat="server" Text="+" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="  btnMas_Click"  />
        <p>
            <asp:Button ID="btnelevar" runat="server" Text="x^2" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="btnCuadrado_Click"  />
            <asp:Button ID="Button22" runat="server" Text="+/-" BackColor="#A9C6E2" CssClass="btn-calculadora" OnClick="Button22_Click"   />
            <asp:Button ID="btn0_Click" runat="server" Text="0" BackColor="#E7F3FE" CssClass="btn-calculadora"  OnClick="Button_Click"  />
            <asp:Button ID="btnComa" runat="server" Text="," BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="btnComa_Click"  />
            <asp:Button ID="btnIgual" runat="server" Text="=" BackColor="#A9C6E2" CssClass="btn-calculadora"  OnClick="  btnIgual_Click"  />
             
        </p>

</body>
</html>
</form>
