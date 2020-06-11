<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Kontakt.aspx.cs" Inherits="Red_Voznje.Kontakt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 10px; top: 35px; position: absolute" Text="Ime:"></asp:Label>
    <asp:Label ID="Label2" runat="server" style="z-index: 1; left: 9px; top: 68px; position: absolute" Text="E-mail:"></asp:Label>
    <asp:Label ID="Label3" runat="server" style="z-index: 1; left: 10px; top: 108px; position: absolute" Text="Naslov poruke:"></asp:Label>
    <asp:Label ID="Label4" runat="server" style="z-index: 1; left: 11px; top: 151px; position: absolute; right: 474px" Text="Sadrzaj poruke:"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" style="z-index: 1; left: 136px; top: 35px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Unesite e-mail" style="z-index: 1; left: 326px; top: 66px; position: absolute; width: 14px; height: 15px">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Pogresan format" style="z-index: 1; left: 327px; top: 66px; position: absolute; height: 11px; width: 14px" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
    <asp:TextBox ID="TextBox2" runat="server" style="z-index: 1; left: 137px; top: 68px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Unesite naslov" style="z-index: 1; left: 328px; top: 100px; position: absolute; width: 18px; height: 19px">*</asp:RequiredFieldValidator>
    <asp:TextBox ID="TextBox3" runat="server" style="z-index: 1; left: 138px; top: 103px; position: absolute"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Unesite poruku" style="z-index: 1; left: 120px; top: 152px; position: absolute">*</asp:RequiredFieldValidator>
    <asp:ValidationSummary ID="ValidationSummary1" runat="server" style="z-index: 1; left: 378px; top: 45px; position: absolute; height: 86px; width: 169px" />
    <asp:TextBox ID="TextBox4" runat="server" style="z-index: 1; left: 14px; top: 182px; position: absolute; height: 172px; width: 311px" TextMode="MultiLine"></asp:TextBox>
    <asp:Button ID="Button1" runat="server" style="z-index: 1; left: 143px; top: 382px; position: absolute" Text="Posalji" />
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Unesite ime" SetFocusOnError="True" style="z-index: 1; left: 329px; top: 37px; position: absolute; height: 14px; width: 14px">*</asp:RequiredFieldValidator>
</asp:Content>
