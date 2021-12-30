<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="movaero.aspx.vb" Inherits="SistemaAtencion.movaero" %>

<%@ Register src="Pantallaprincipal/filtros.ascx" tagname="filtros" tagprefix="uc1" %>
<%@ Register src="Pantallaprincipal/grilla.ascx" tagname="grilla" tagprefix="uc2" %>

<%@ Register assembly="DevExpress.Web.v16.2, Version=16.2.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            height: 33px;
        }
        #grad1 {
                height: 84px;
                background: red; /* For browsers that do not support gradients */
                background: -webkit-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Safari 5.1 to 6.0 */
                background: -o-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Opera 11.1 to 12.0 */
                background: -moz-linear-gradient(top, rgba(250,250,250,1) 0%, rgba(230,230,230,1) 51%, rgba(242,242,242,1) 76%, rgba(255,255,255,1) 100%); /* For Firefox 3.6 to 15 */
                background: red; /* Standard syntax (must be last) */
        }
    </style>
</head>
<body >
    <form id="form1" runat="server">
    <div  id="grad1">
 
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:ScriptManager ID="ScriptManager1" runat="server">
                    </asp:ScriptManager>
                </td>
            </tr>
            </table>
                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/logo_header_dgac.png" />
        <br />
        </div>
        <uc1:filtros ID="filtros1" runat="server"  />
        <uc2:grilla ID="grilla1" runat="server"  />
        <br />
        <br />
        <br />
    </form>
</body>
</html>
