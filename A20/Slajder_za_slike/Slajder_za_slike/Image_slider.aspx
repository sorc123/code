<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Image_slider.aspx.cs" Inherits="Slajder_za_slike.Image_slider" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Css/index.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="slike">
            <img src="Slike/001.jpeg" />
            <img src="Slike/002.jpeg" />
            <img src="Slike/003.jpeg" />
            <img src="Slike/004.jpeg" />
            <img src="Slike/005.jpeg" />
            <div id="indikatori">
                <div class="kvadrat prvi"></div>
                <div class="kvadrat drugi"></div>
                <div class="kvadrat treci"></div>
                <div class="kvadrat cetvrti"></div>
                <div class="kvadrat peti"></div>
            </div>
        </div>
    </form>

    <a href="O_aplikaciji.aspx">Informacije o autoru i aplikaciji</a>

    <script src="Js/index.js" type="text/javascript"></script>
</body>
</html>
