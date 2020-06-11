<%@ Page Title="" Language="C#" MasterPageFile="~/master.Master" AutoEventWireup="true" CodeBehind="Pocetna.aspx.cs" Inherits="Knjiga_utisaka.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="Large" Font-Underline="False" style="z-index: 1; left: 130px; top: 77px; position: absolute; height: 24px; width: 201px" Text="Knjiga utisaka:"></asp:Label>
<p style="height: 471px; width: 579px">
    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxIme" ErrorMessage="Obavezno polje" ForeColor="Red" style="z-index: 1; left: 455px; top: 121px; position: absolute; height: 19px; width: 42px;">*</asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxEmail" ErrorMessage="Obavezno polje" ForeColor="Red" style="z-index: 1; left: 455px; top: 161px; position: absolute; height: 18px; width: 29px">*</asp:RequiredFieldValidator>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxKomentar" ErrorMessage="Obavezno polje" ForeColor="Red" style="z-index: 1; left: 456px; top: 202px; position: absolute; height: 18px; width: 28px">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Email nije napisan u ispravnom obliku" ForeColor="Red" style="z-index: 1; left: 480px; top: 158px; position: absolute; height: 18px; width: 33px" ControlToValidate="TextBoxEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
</p>
        <asp:TextBox ID="TextBoxIme" runat="server" style="z-index: 1; left: 131px; top: 126px; position: absolute; width: 279px; height: 18px;" CssClass="textbox"></asp:TextBox>
        <asp:TextBox ID="TextBoxEmail" runat="server" style="z-index: 1; left: 132px; top: 159px; position: absolute; width: 278px" CssClass="textbox"></asp:TextBox>
        <asp:TextBox ID="TextBoxKomentar" runat="server" style="z-index: 1; left: 131px; top: 200px; position: absolute; height: 111px; width: 290px" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
<asp:Label ID="Label2" runat="server" style="z-index: 1; left: 74px; top: 122px; position: absolute; height: 15px; width: 38px" Text="Ime:"></asp:Label>
<asp:Label ID="Label3" runat="server" style="z-index: 1; left: 66px; top: 158px; position: absolute" Text="Email:"></asp:Label>
<asp:Label ID="Label4" runat="server" style="z-index: 1; left: 39px; top: 198px; position: absolute" Text="Komentar:"></asp:Label>
<asp:Button ID="ButtonDodaj" runat="server" style="z-index: 1; left: 185px; top: 343px; position: absolute" Text="Dodaj komentar" CssClass="button" OnClick="ButtonDodaj_Click" />
<asp:ValidationSummary ID="ValidationSummary1" runat="server" style="z-index: 1; left: 27px; top: 411px; position: absolute; height: 109px; width: 239px" DisplayMode="List" />
</asp:Content>