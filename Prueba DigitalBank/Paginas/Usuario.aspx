<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Prueba_DigitalBank.Paginas.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-left: 351px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Navegacion" runat="server" Height="54px">
                <asp:LinkButton ID="LbInicio" runat="server" BorderStyle="Outset" Width="47px" href="~/" BorderColor="#00CC99" BorderWidth="3px">Inicio</asp:LinkButton>
                <asp:LinkButton ID="LbVer" runat="server" BorderStyle="Outset" Width="84px" href="Consultas.aspx" BorderColor="#00CC99" BorderWidth="3px">Ver Usuarios</asp:LinkButton>
            </asp:Panel>
            <br/>
            <br/>
            <br/>
            <asp:Panel ID="Pform" runat="server" CssClass="auto-style1" Height="280px" Width="500px">
                <asp:Label ID="LbNombres" runat="server" Text="Nombres completos: " Font-Bold="True" Font-Italic="False" Font-Names="Century Gothic"></asp:Label>
            <br />
                <asp:TextBox ID="txtNombre" PlaceHolder="NOMBRES COMPLETOS" runat="server" MaxLength="100" Width="334px" required></asp:TextBox>
            <br/>
            <br/>
                <asp:Label ID="LbFecha" runat="server" Text="Fecha de nacimiento: " Font-Bold="True" Font-Italic="False" Font-Names="Century Gothic"></asp:Label>
            <br/>
                <asp:TextBox ID="txtFecha" runat="server" MaxLength="100" Width="193px" TextMode="Date"></asp:TextBox>
            <br/>
            <br/>
                <asp:Label ID="LbGenero" runat="server" Text="Genero: " Font-Bold="True" Font-Italic="False" Font-Names="Century Gothic"></asp:Label>
            <br/>
            <asp:DropDownList ID="ddlSexo" runat="server" Height="18px" Width="135px">
                <asp:ListItem Text=""></asp:ListItem>
                <asp:ListItem Text="Masculino" Value="M"></asp:ListItem>
                <asp:ListItem Text="Femenino" Value="F"></asp:ListItem>
            </asp:DropDownList>
            <br/>
            <br/>
                <asp:Button ID="Bguardar" runat="server" Text="Guardar" BorderStyle="Double" Font-Bold="False" Font-Names="Century Gothic" Width="85px" OnClick="Bguardar_Click" />
                <br />
                <asp:Label ID="lbError" runat="server" Text="mensaje de error" Visible="False"></asp:Label>
            </asp:Panel>

            

        </div>
    </form>
</body>
</html>
