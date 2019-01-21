<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="slfexlubricants.com._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <%--    <div class="jumbotron">
        <h1>Salfex Lubricants</h1>
        <div class="row">
            <img src="Images/home.png" style="width: 100%" />
        </div>
    </div>--%>

    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <!-- Indicators -->
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
<%--            <li data-target="#myCarousel" data-slide-to="1"></li>
            <li data-target="#myCarousel" data-slide-to="2"></li>--%>
        </ol>

        <!-- Wrapper for slides -->
        <div class="carousel-inner" style="max-height: 400px; width: 100%">
            <div class="item active">
                <img src="images/home.png" alt="Salfex Lubricants" style="max-height: 100%; max-width: 100%">
            </div>

<%--            <div class="item">
                <img src="images/20W40_4StrokeMotorCycleEngineOil.png" alt="Chicago" style="max-height: 100% !important; max-width: 100% !important">
            </div>

            <div class="item">
                <img src="images/20W40_4StrokeMotorCycleEngineOil.png" alt="New York" style="max-height: 100%; max-width: 100%">
            </div>--%>
        </div>

        <!-- Left and right controls -->
        <a class="left carousel-control" href="#myCarousel" data-slide="prev">
            <span class="glyphicon glyphicon-chevron-left"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="right carousel-control" href="#myCarousel" data-slide="next">
            <span class="glyphicon glyphicon-chevron-right"></span>
            <span class="sr-only">Next</span>
        </a>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2><span style="background-color: #b01313; color: #ffffff; padding: 2px 10px 2px 10px; border-radius: 10px">20W40</span> 4 Stroke Motor Cycle Engine Oil</h2>
            <p>
                Salfex Advanced 4T 20W/40+ is a blend of Mineral and Synthetic base Stock and Blend of Selective high performance Additives, which protects Engine, Transmission and wet clutch of new generation 4-Stroke two wheelers.
            </p>
        </div>
        <div class="col-md-4">
            <h2><span style="background-color: #b01313; color: #ffffff; padding: 2px 10px 2px 10px; border-radius: 10px">20W40</span> 4 Stroke Motor Cycle Engine Oil</h2>
            <p>
                Salfex Advanced 4T 20W/40+ is a blend of Mineral and Synthetic base Stock and Blend of Selective high performance Additives, which protects Engine, Transmission and wet clutch of new generation 4-Stroke two wheelers.
            </p>
        </div>
        <div class="col-md-4">
            <h2><span style="background-color: #b01313; color: #ffffff; padding: 2px 10px 2px 10px; border-radius: 10px">20W40</span> 4 Stroke Motor Cycle Engine Oil</h2>
            <p>
                Salfex Advanced 4T 20W/40+ is a blend of Mineral and Synthetic base Stock and Blend of Selective high performance Additives, which protects Engine, Transmission and wet clutch of new generation 4-Stroke two wheelers.
            </p>
        </div>
    </div>
    <div class="row"><a class="btn" style="background-color: #b01313; color: white" href="products">View More Products...</a></div>

</asp:Content>
