/*
               File: Gx00Q2
        Description: Selection List Signos Vitales
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:46.90
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class gx00q2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00q2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00q2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           int aP1_pConsultaId ,
                           out short aP2_pSignoLinea )
      {
         this.AV11pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV12pConsultaId = aP1_pConsultaId;
         this.AV13pSignoLinea = 0 ;
         executePrivate();
         aP2_pSignoLinea=this.AV13pSignoLinea;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCsignoestaturaen = new GXCombobox();
         cmbavCsignopesoen = new GXCombobox();
         cmbSignoEstaturaEn = new GXCombobox();
         cmbSignoPesoEn = new GXCombobox();
         cmbSignoTemperaturaDe = new GXCombobox();
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
            entryPointCalled = false ;
            gxfirstwebparm = GetNextPar( ) ;
            gxfirstwebparm_bkp = gxfirstwebparm ;
            gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
            if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               dyncall( GetNextPar( )) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
            {
               setAjaxEventMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = GetNextPar( ) ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_41_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_41_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_41_idx, sGXsfl_41_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               cmbavCsignoestaturaen.Name = "vCSIGNOESTATURAEN" ;
               cmbavCsignoestaturaen.WebTags = "" ;
               cmbavCsignoestaturaen.addItem("CM", "Centímetros", 0);
               cmbavCsignoestaturaen.addItem("ME", "Metros", 0);
               if ( ( cmbavCsignoestaturaen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8cSignoEstaturaEn)) )
               {
                  AV8cSignoEstaturaEn = cmbavCsignoestaturaen.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
               }
               cmbavCsignopesoen.Name = "vCSIGNOPESOEN" ;
               cmbavCsignopesoen.WebTags = "" ;
               cmbavCsignopesoen.addItem("Lb", "Libras", 0);
               cmbavCsignopesoen.addItem("Gr", "Gramos", 0);
               cmbavCsignopesoen.addItem("Kg", "KGramos", 0);
               if ( ( cmbavCsignopesoen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10cSignoPesoEn)) )
               {
                  AV10cSignoPesoEn = cmbavCsignopesoen.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
               }
               GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_41_idx ;
               cmbSignoEstaturaEn.Name = GXCCtl ;
               cmbSignoEstaturaEn.WebTags = "" ;
               cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
               cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
               if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
               {
                  A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
               }
               GXCCtl = "SIGNOPESOEN_" + sGXsfl_41_idx ;
               cmbSignoPesoEn.Name = GXCCtl ;
               cmbSignoPesoEn.WebTags = "" ;
               cmbSignoPesoEn.addItem("Lb", "Libras", 0);
               cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
               cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
               if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
               {
                  A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
               }
               GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_41_idx ;
               cmbSignoTemperaturaDe.Name = GXCCtl ;
               cmbSignoTemperaturaDe.WebTags = "" ;
               cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
               cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
               cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
               cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
               if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
               {
                  A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
               }
               Grid1_PageSize41 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cSignoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSignoLinea), 4, 0)));
               AV7cSignoEstatura = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSignoEstatura", StringUtil.LTrim( StringUtil.Str( AV7cSignoEstatura, 8, 2)));
               AV8cSignoEstaturaEn = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
               AV9cSignoPeso = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cSignoPeso", StringUtil.LTrim( StringUtil.Str( AV9cSignoPeso, 8, 2)));
               AV10cSignoPesoEn = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
               AV11pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
               AV12pConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pConsultaId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize41, AV6cSignoLinea, AV7cSignoEstatura, AV8cSignoEstaturaEn, AV9cSignoPeso, AV10cSignoPesoEn, AV11pClinicaCodigo, AV12pConsultaId) ;
               return  ;
            }
            else
            {
               if ( ! IsValidAjaxCall( false) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxfirstwebparm = gxfirstwebparm_bkp ;
            }
            if ( ! entryPointCalled )
            {
               AV11pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12pConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pConsultaId), 9, 0)));
                  AV13pSignoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pSignoLinea), 4, 0)));
               }
            }
         }
         context.SetTheme("Fantastic");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      public override short ExecuteStartEvent( )
      {
         PA0W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0W2( ) ;
         }
         return gxajaxcallmode ;
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?58720");
            context.AddJavascriptSource("gxfxSD.js", "?58720");
            context.AddJavascriptSource("gxtypesSD.js", "?58720");
            context.AddJavascriptSource("gxpopupSD.js", "?58720");
            context.AddJavascriptSource("gxfrmutlSD.js", "?58720");
            context.AddJavascriptSource("gxgridSD.js", "?58720");
            context.AddJavascriptSource("JavaScripTableSD.js", "?58720");
            context.AddJavascriptSource("rijndaelSD.js", "?58720");
            context.AddJavascriptSource("gxgralSD.js", "?58720");
            context.AddJavascriptSource("gxcfg.js", "?58720");
         }
         context.AddJavascriptSource("calendar.js", "?58720");
         context.AddJavascriptSource("calendar-setup.js", "?58720");
         context.AddJavascriptSource("calendar-es.js", "?58720");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00q2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pClinicaCodigo)) + "," + UrlEncode("" +AV12pConsultaId) + "," + UrlEncode("" +AV13pSignoLinea)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCSIGNOLINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSignoLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSIGNOESTATURA", StringUtil.LTrim( StringUtil.NToC( AV7cSignoEstatura, 8, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSIGNOESTATURAEN", StringUtil.RTrim( AV8cSignoEstaturaEn));
         GxWebStd.gx_hidden_field( context, "GXH_vCSIGNOPESO", StringUtil.LTrim( StringUtil.NToC( AV9cSignoPeso, 8, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSIGNOPESOEN", StringUtil.RTrim( AV10cSignoPesoEn));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV11pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCONSULTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPSIGNOLINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pSignoLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE0W2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0W2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00Q2" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Signos Vitales" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00q2.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV11pClinicaCodigo)) + "," + UrlEncode("" +AV12pConsultaId) + "," + UrlEncode("" +AV13pSignoLinea) ;
      }

      protected void WB0W0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_0W2( true) ;
         }
         else
         {
            wb_table1_2_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0W2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Signos Vitales", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0W0( ) ;
      }

      protected void WS0W2( )
      {
         START0W2( ) ;
         EVT0W2( ) ;
      }

      protected void EVT0W2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOLINEA"), ".", ",") != Convert.ToDecimal( AV6cSignoLinea )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOESTATURA"), ".", ",") != AV7cSignoEstatura )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCSIGNOESTATURAEN"), AV8cSignoEstaturaEn) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOPESO"), ".", ",") != AV9cSignoPeso )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCSIGNOPESOEN"), AV10cSignoPesoEn) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_41_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
                              edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
                              edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
                              cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
                              edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
                              cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
                              edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
                              cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
                              edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
                              edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
                              edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
                              edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
                              edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A96SignoLinea = (short)(context.localUtil.CToN( cgiGet( edtSignoLinea_Internalname), ".", ",")) ;
                              A97SignoEstatura = context.localUtil.CToN( cgiGet( edtSignoEstatura_Internalname), ".", ",") ;
                              cmbSignoEstaturaEn.Name = cmbSignoEstaturaEn_Internalname ;
                              cmbSignoEstaturaEn.CurrentValue = cgiGet( cmbSignoEstaturaEn_Internalname) ;
                              A98SignoEstaturaEn = cgiGet( cmbSignoEstaturaEn_Internalname) ;
                              A99SignoPeso = context.localUtil.CToN( cgiGet( edtSignoPeso_Internalname), ".", ",") ;
                              cmbSignoPesoEn.Name = cmbSignoPesoEn_Internalname ;
                              cmbSignoPesoEn.CurrentValue = cgiGet( cmbSignoPesoEn_Internalname) ;
                              A100SignoPesoEn = cgiGet( cmbSignoPesoEn_Internalname) ;
                              A101SignoTemperatura = context.localUtil.CToN( cgiGet( edtSignoTemperatura_Internalname), ".", ",") ;
                              cmbSignoTemperaturaDe.Name = cmbSignoTemperaturaDe_Internalname ;
                              cmbSignoTemperaturaDe.CurrentValue = cgiGet( cmbSignoTemperaturaDe_Internalname) ;
                              A102SignoTemperaturaDe = cgiGet( cmbSignoTemperaturaDe_Internalname) ;
                              A103SignoPresionArterial = cgiGet( edtSignoPresionArterial_Internalname) ;
                              A104SignoFrecCardiaca = context.localUtil.CToN( cgiGet( edtSignoFrecCardiaca_Internalname), ".", ",") ;
                              A106SignoFecha = context.localUtil.CToD( cgiGet( edtSignoFecha_Internalname), 2) ;
                              A107SignoHora = cgiGet( edtSignoHora_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110W2 */
                                    E110W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120W2 */
                                    E120W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Csignolinea Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOLINEA"), ".", ",") != Convert.ToDecimal( AV6cSignoLinea )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csignoestatura Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOESTATURA"), ".", ",") != AV7cSignoEstatura )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csignoestaturaen Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSIGNOESTATURAEN"), AV8cSignoEstaturaEn) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csignopeso Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCSIGNOPESO"), ".", ",") != AV9cSignoPeso )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csignopesoen Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCSIGNOPESOEN"), AV10cSignoPesoEn) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130W2 */
                                          E130W2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE0W2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0W2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCsignoestaturaen.Name = "vCSIGNOESTATURAEN" ;
            cmbavCsignoestaturaen.WebTags = "" ;
            cmbavCsignoestaturaen.addItem("CM", "Centímetros", 0);
            cmbavCsignoestaturaen.addItem("ME", "Metros", 0);
            if ( ( cmbavCsignoestaturaen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV8cSignoEstaturaEn)) )
            {
               AV8cSignoEstaturaEn = cmbavCsignoestaturaen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
            }
            cmbavCsignopesoen.Name = "vCSIGNOPESOEN" ;
            cmbavCsignopesoen.WebTags = "" ;
            cmbavCsignopesoen.addItem("Lb", "Libras", 0);
            cmbavCsignopesoen.addItem("Gr", "Gramos", 0);
            cmbavCsignopesoen.addItem("Kg", "KGramos", 0);
            if ( ( cmbavCsignopesoen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV10cSignoPesoEn)) )
            {
               AV10cSignoPesoEn = cmbavCsignopesoen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
            }
            GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_41_idx ;
            cmbSignoEstaturaEn.Name = GXCCtl ;
            cmbSignoEstaturaEn.WebTags = "" ;
            cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
            cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
            if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
            {
               A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
            }
            GXCCtl = "SIGNOPESOEN_" + sGXsfl_41_idx ;
            cmbSignoPesoEn.Name = GXCCtl ;
            cmbSignoPesoEn.WebTags = "" ;
            cmbSignoPesoEn.addItem("Lb", "Libras", 0);
            cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
            cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
            if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
            {
               A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
            }
            GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_41_idx ;
            cmbSignoTemperaturaDe.Name = GXCCtl ;
            cmbSignoTemperaturaDe.WebTags = "" ;
            cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
            cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
            cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
            cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
            if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
            {
               A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
            }
            GX_FocusControl = edtavCsignolinea_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_41_idx ,
                                       String sGXsfl_41_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
         edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
         while ( nGXsfl_41_idx <= nRC_Grid1 )
         {
            sendrow_412( ) ;
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
            edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
            cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
            edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
            cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
            edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
            cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
            edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
            edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
            edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
            edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize41 ,
                                        short AV6cSignoLinea ,
                                        decimal AV7cSignoEstatura ,
                                        String AV8cSignoEstaturaEn ,
                                        decimal AV9cSignoPeso ,
                                        String AV10cSignoPesoEn ,
                                        String AV11pClinicaCodigo ,
                                        int AV12pConsultaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize41) ;
         RF0W2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0W2( ) ;
         /* End function Refresh */
      }

      protected void RF0W2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 41 ;
         nGXsfl_41_idx = 1 ;
         sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
         edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
         cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
         edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
         cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
         edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
         cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
         edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
         edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
         edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
         edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
         edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
            edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
            cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
            edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
            cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
            edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
            cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
            edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
            edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
            edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
            edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
            lV8cSignoEstaturaEn = StringUtil.PadR( StringUtil.RTrim( AV8cSignoEstaturaEn), 2, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
            lV10cSignoPesoEn = StringUtil.PadR( StringUtil.RTrim( AV10cSignoPesoEn), 2, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
            /* Using cursor H000W2 */
            pr_default.execute(0, new Object[] {AV11pClinicaCodigo, AV12pConsultaId, AV6cSignoLinea, AV7cSignoEstatura, lV8cSignoEstaturaEn, AV9cSignoPeso, lV10cSignoPesoEn});
            nGXsfl_41_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A91ConsultaId = H000W2_A91ConsultaId[0] ;
               A41ClinicaCodigo = H000W2_A41ClinicaCodigo[0] ;
               A107SignoHora = H000W2_A107SignoHora[0] ;
               A106SignoFecha = H000W2_A106SignoFecha[0] ;
               A104SignoFrecCardiaca = H000W2_A104SignoFrecCardiaca[0] ;
               A103SignoPresionArterial = H000W2_A103SignoPresionArterial[0] ;
               A102SignoTemperaturaDe = H000W2_A102SignoTemperaturaDe[0] ;
               A101SignoTemperatura = H000W2_A101SignoTemperatura[0] ;
               A100SignoPesoEn = H000W2_A100SignoPesoEn[0] ;
               A99SignoPeso = H000W2_A99SignoPeso[0] ;
               A98SignoEstaturaEn = H000W2_A98SignoEstaturaEn[0] ;
               A97SignoEstatura = H000W2_A97SignoEstatura[0] ;
               A96SignoLinea = H000W2_A96SignoLinea[0] ;
               /* Execute user event: E120W2 */
               E120W2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 41 ;
            WB0W0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV8cSignoEstaturaEn = StringUtil.PadR( StringUtil.RTrim( AV8cSignoEstaturaEn), 2, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
         lV10cSignoPesoEn = StringUtil.PadR( StringUtil.RTrim( AV10cSignoPesoEn), 2, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
         /* Using cursor H000W3 */
         pr_default.execute(1, new Object[] {AV11pClinicaCodigo, AV12pConsultaId, AV6cSignoLinea, AV7cSignoEstatura, lV8cSignoEstaturaEn, AV9cSignoPeso, lV10cSignoPesoEn});
         GRID1_nRecordCount = H000W3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP0W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110W2 */
         E110W2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsignolinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsignolinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSIGNOLINEA");
               GX_FocusControl = edtavCsignolinea_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cSignoLinea = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSignoLinea), 4, 0)));
            }
            else
            {
               AV6cSignoLinea = (short)(context.localUtil.CToN( cgiGet( edtavCsignolinea_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSignoLinea), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsignoestatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsignoestatura_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSIGNOESTATURA");
               GX_FocusControl = edtavCsignoestatura_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cSignoEstatura = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSignoEstatura", StringUtil.LTrim( StringUtil.Str( AV7cSignoEstatura, 8, 2)));
            }
            else
            {
               AV7cSignoEstatura = context.localUtil.CToN( cgiGet( edtavCsignoestatura_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSignoEstatura", StringUtil.LTrim( StringUtil.Str( AV7cSignoEstatura, 8, 2)));
            }
            cmbavCsignoestaturaen.Name = cmbavCsignoestaturaen_Internalname ;
            cmbavCsignoestaturaen.CurrentValue = cgiGet( cmbavCsignoestaturaen_Internalname) ;
            AV8cSignoEstaturaEn = cgiGet( cmbavCsignoestaturaen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsignopeso_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsignopeso_Internalname), ".", ",") > 99999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCSIGNOPESO");
               GX_FocusControl = edtavCsignopeso_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cSignoPeso = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cSignoPeso", StringUtil.LTrim( StringUtil.Str( AV9cSignoPeso, 8, 2)));
            }
            else
            {
               AV9cSignoPeso = context.localUtil.CToN( cgiGet( edtavCsignopeso_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cSignoPeso", StringUtil.LTrim( StringUtil.Str( AV9cSignoPeso, 8, 2)));
            }
            cmbavCsignopesoen.Name = cmbavCsignopesoen_Internalname ;
            cmbavCsignopesoen.CurrentValue = cgiGet( cmbavCsignopesoen_Internalname) ;
            AV10cSignoPesoEn = cgiGet( cmbavCsignopesoen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV11pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV12pConsultaId = (int)(context.localUtil.CToN( cgiGet( "vPCONSULTAID"), ".", ",")) ;
            AV13pSignoLinea = (short)(context.localUtil.CToN( cgiGet( "vPSIGNOLINEA"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E110W2 */
         E110W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110W2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Signos Vitales", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120W2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_412( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130W2 */
         E130W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130W2( )
      {
         /* Enter Routine */
         AV13pSignoLinea = A96SignoLinea ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pSignoLinea), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pSignoLinea});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_0W2( true) ;
         }
         else
         {
            wb_table2_9_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_38_0W2( true) ;
         }
         else
         {
            wb_table3_38_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table3_38_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0W2e( true) ;
         }
         else
         {
            wb_table1_2_0W2e( false) ;
         }
      }

      protected void wb_table3_38_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"41\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Linea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estatura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "En") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Peso") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "En") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Temperatura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "De") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Arterial") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cardiaca") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Hora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Consulta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtSignoEstatura_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A98SignoEstaturaEn));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A100SignoPesoEn));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A102SignoTemperaturaDe));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A103SignoPresionArterial));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A106SignoFecha, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A107SignoHora));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 41 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_41_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_58_0W2( true) ;
         }
         else
         {
            wb_table4_58_0W2( false) ;
         }
         return  ;
      }

      protected void wb_table4_58_0W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_38_0W2e( true) ;
         }
         else
         {
            wb_table3_38_0W2e( false) ;
         }
      }

      protected void wb_table4_58_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(41), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_58_0W2e( true) ;
         }
         else
         {
            wb_table4_58_0W2e( false) ;
         }
      }

      protected void wb_table2_9_0W2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksignolinea_Internalname, "Signo Linea", "", "", lblTextblocksignolinea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cSignoLinea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsignolinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cSignoLinea), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV6cSignoLinea), "ZZZ9")) : context.localUtil.Format( (decimal)(AV6cSignoLinea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCsignolinea_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksignoestatura_Internalname, "Estatura", "", "", lblTextblocksignoestatura_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cSignoEstatura", StringUtil.LTrim( StringUtil.Str( AV7cSignoEstatura, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsignoestatura_Internalname, StringUtil.LTrim( StringUtil.NToC( AV7cSignoEstatura, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV7cSignoEstatura, "ZZZZ9.99")) : context.localUtil.Format( AV7cSignoEstatura, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCsignoestatura_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksignoestaturaen_Internalname, "Estatura_En", "", "", lblTextblocksignoestaturaen_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cSignoEstaturaEn", AV8cSignoEstaturaEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCsignoestaturaen, cmbavCsignoestaturaen_Internalname, AV8cSignoEstaturaEn, 1, cmbavCsignoestaturaen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", true, "HLP_Gx00Q2.htm");
            cmbavCsignoestaturaen.CurrentValue = AV8cSignoEstaturaEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsignoestaturaen_Internalname, "Values", (String)(cmbavCsignoestaturaen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksignopeso_Internalname, "Peso", "", "", lblTextblocksignopeso_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cSignoPeso", StringUtil.LTrim( StringUtil.Str( AV9cSignoPeso, 8, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsignopeso_Internalname, StringUtil.LTrim( StringUtil.NToC( AV9cSignoPeso, 8, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV9cSignoPeso, "ZZZZ9.99")) : context.localUtil.Format( AV9cSignoPeso, "ZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCsignopeso_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksignopesoen_Internalname, "Peso_En", "", "", lblTextblocksignopesoen_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Q2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSignoPesoEn", AV10cSignoPesoEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCsignopesoen, cmbavCsignopesoen_Internalname, AV10cSignoPesoEn, 1, cmbavCsignopesoen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", true, "HLP_Gx00Q2.htm");
            cmbavCsignopesoen.CurrentValue = AV10cSignoPesoEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCsignopesoen_Internalname, "Values", (String)(cmbavCsignopesoen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0W2e( true) ;
         }
         else
         {
            wb_table2_9_0W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pClinicaCodigo", AV11pClinicaCodigo);
         AV12pConsultaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pConsultaId), 9, 0)));
         AV13pSignoLinea = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pSignoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pSignoLinea), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA0W2( ) ;
         WS0W2( ) ;
         WE0W2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?75080");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1584774");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx00q2.js", "?1584775");
         /* End function include_jscripts */
      }

      protected void sendrow_412( )
      {
         WB0W0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_41_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xFFFFFF) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_41_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xFFFFFF) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_41_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")))+"'"+"]);" ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)AV5LinkSelection,(String)edtavLinkselection_Link,(String)"",(String)"",(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A96SignoLinea), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtSignoEstatura_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A96SignoLinea), 4, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoEstatura_Internalname,StringUtil.LTrim( StringUtil.NToC( A97SignoEstatura, 8, 2, ".", "")),context.localUtil.Format( A97SignoEstatura, "ZZZZ9.99"),(String)"",(String)"",(String)edtSignoEstatura_Link,(String)"",(String)"Seleccionar",(String)edtSignoEstatura_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_41_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SIGNOESTATURAEN_" + sGXsfl_41_idx ;
               cmbSignoEstaturaEn.Name = GXCCtl ;
               cmbSignoEstaturaEn.WebTags = "" ;
               cmbSignoEstaturaEn.addItem("CM", "Centímetros", 0);
               cmbSignoEstaturaEn.addItem("ME", "Metros", 0);
               if ( ( cmbSignoEstaturaEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A98SignoEstaturaEn)) )
               {
                  A98SignoEstaturaEn = cmbSignoEstaturaEn.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoEstaturaEn,(String)cmbSignoEstaturaEn_Internalname,(String)A98SignoEstaturaEn,(short)1,(String)cmbSignoEstaturaEn_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbSignoEstaturaEn.CurrentValue = A98SignoEstaturaEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoEstaturaEn_Internalname, "Values", (String)(cmbSignoEstaturaEn.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoPeso_Internalname,StringUtil.LTrim( StringUtil.NToC( A99SignoPeso, 8, 2, ".", "")),context.localUtil.Format( A99SignoPeso, "ZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoPeso_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_41_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SIGNOPESOEN_" + sGXsfl_41_idx ;
               cmbSignoPesoEn.Name = GXCCtl ;
               cmbSignoPesoEn.WebTags = "" ;
               cmbSignoPesoEn.addItem("Lb", "Libras", 0);
               cmbSignoPesoEn.addItem("Gr", "Gramos", 0);
               cmbSignoPesoEn.addItem("Kg", "KGramos", 0);
               if ( ( cmbSignoPesoEn.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A100SignoPesoEn)) )
               {
                  A100SignoPesoEn = cmbSignoPesoEn.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoPesoEn,(String)cmbSignoPesoEn_Internalname,(String)A100SignoPesoEn,(short)1,(String)cmbSignoPesoEn_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbSignoPesoEn.CurrentValue = A100SignoPesoEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoPesoEn_Internalname, "Values", (String)(cmbSignoPesoEn.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoTemperatura_Internalname,StringUtil.LTrim( StringUtil.NToC( A101SignoTemperatura, 8, 2, ".", "")),context.localUtil.Format( A101SignoTemperatura, "ZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoTemperatura_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_41_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "SIGNOTEMPERATURADE_" + sGXsfl_41_idx ;
               cmbSignoTemperaturaDe.Name = GXCCtl ;
               cmbSignoTemperaturaDe.WebTags = "" ;
               cmbSignoTemperaturaDe.addItem("Or", "Oral", 0);
               cmbSignoTemperaturaDe.addItem("Ax", "Axilar", 0);
               cmbSignoTemperaturaDe.addItem("Re", "Rectal", 0);
               cmbSignoTemperaturaDe.addItem("Fr", "Frontal", 0);
               if ( ( cmbSignoTemperaturaDe.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A102SignoTemperaturaDe)) )
               {
                  A102SignoTemperaturaDe = cmbSignoTemperaturaDe.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbSignoTemperaturaDe,(String)cmbSignoTemperaturaDe_Internalname,(String)A102SignoTemperaturaDe,(short)1,(String)cmbSignoTemperaturaDe_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbSignoTemperaturaDe.CurrentValue = A102SignoTemperaturaDe ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbSignoTemperaturaDe_Internalname, "Values", (String)(cmbSignoTemperaturaDe.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoPresionArterial_Internalname,StringUtil.RTrim( A103SignoPresionArterial),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoPresionArterial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)6,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoFrecCardiaca_Internalname,StringUtil.LTrim( StringUtil.NToC( A104SignoFrecCardiaca, 8, 2, ".", "")),context.localUtil.Format( A104SignoFrecCardiaca, "ZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoFrecCardiaca_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoFecha_Internalname,context.localUtil.Format(A106SignoFecha, "99/99/99"),context.localUtil.Format( A106SignoFecha, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSignoHora_Internalname,StringUtil.RTrim( A107SignoHora),StringUtil.RTrim( context.localUtil.Format( A107SignoHora, "XXXXXXXX")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSignoHora_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtSignoLinea_Internalname = "SIGNOLINEA_"+sGXsfl_41_idx ;
            edtSignoEstatura_Internalname = "SIGNOESTATURA_"+sGXsfl_41_idx ;
            cmbSignoEstaturaEn_Internalname = "SIGNOESTATURAEN_"+sGXsfl_41_idx ;
            edtSignoPeso_Internalname = "SIGNOPESO_"+sGXsfl_41_idx ;
            cmbSignoPesoEn_Internalname = "SIGNOPESOEN_"+sGXsfl_41_idx ;
            edtSignoTemperatura_Internalname = "SIGNOTEMPERATURA_"+sGXsfl_41_idx ;
            cmbSignoTemperaturaDe_Internalname = "SIGNOTEMPERATURADE_"+sGXsfl_41_idx ;
            edtSignoPresionArterial_Internalname = "SIGNOPRESIONARTERIAL_"+sGXsfl_41_idx ;
            edtSignoFrecCardiaca_Internalname = "SIGNOFRECCARDIACA_"+sGXsfl_41_idx ;
            edtSignoFecha_Internalname = "SIGNOFECHA_"+sGXsfl_41_idx ;
            edtSignoHora_Internalname = "SIGNOHORA_"+sGXsfl_41_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_41_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_41_idx ;
         }
         /* End function sendrow_412 */
      }

      protected void init_default_properties( )
      {
         lblTextblocksignolinea_Internalname = "TEXTBLOCKSIGNOLINEA" ;
         edtavCsignolinea_Internalname = "vCSIGNOLINEA" ;
         lblTextblocksignoestatura_Internalname = "TEXTBLOCKSIGNOESTATURA" ;
         edtavCsignoestatura_Internalname = "vCSIGNOESTATURA" ;
         lblTextblocksignoestaturaen_Internalname = "TEXTBLOCKSIGNOESTATURAEN" ;
         cmbavCsignoestaturaen_Internalname = "vCSIGNOESTATURAEN" ;
         lblTextblocksignopeso_Internalname = "TEXTBLOCKSIGNOPESO" ;
         edtavCsignopeso_Internalname = "vCSIGNOPESO" ;
         lblTextblocksignopesoen_Internalname = "TEXTBLOCKSIGNOPESOEN" ;
         cmbavCsignopesoen_Internalname = "vCSIGNOPESOEN" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtConsultaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtSignoHora_Jsonclick = "" ;
         edtSignoFecha_Jsonclick = "" ;
         edtSignoFrecCardiaca_Jsonclick = "" ;
         edtSignoPresionArterial_Jsonclick = "" ;
         cmbSignoTemperaturaDe_Jsonclick = "" ;
         edtSignoTemperatura_Jsonclick = "" ;
         cmbSignoPesoEn_Jsonclick = "" ;
         edtSignoPeso_Jsonclick = "" ;
         cmbSignoEstaturaEn_Jsonclick = "" ;
         edtSignoEstatura_Jsonclick = "" ;
         edtSignoLinea_Jsonclick = "" ;
         cmbavCsignopesoen_Jsonclick = "" ;
         edtavCsignopeso_Jsonclick = "" ;
         cmbavCsignoestaturaen_Jsonclick = "" ;
         edtavCsignoestatura_Jsonclick = "" ;
         edtavCsignolinea_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtSignoEstatura_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Signos Vitales" ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         wcpOAV11pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV8cSignoEstaturaEn = "" ;
         AV10cSignoPesoEn = "" ;
         GXCCtl = "" ;
         A98SignoEstaturaEn = "" ;
         A100SignoPesoEn = "" ;
         A102SignoTemperaturaDe = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtSignoLinea_Internalname = "" ;
         edtSignoEstatura_Internalname = "" ;
         cmbSignoEstaturaEn_Internalname = "" ;
         edtSignoPeso_Internalname = "" ;
         cmbSignoPesoEn_Internalname = "" ;
         edtSignoTemperatura_Internalname = "" ;
         cmbSignoTemperaturaDe_Internalname = "" ;
         edtSignoPresionArterial_Internalname = "" ;
         edtSignoFrecCardiaca_Internalname = "" ;
         edtSignoFecha_Internalname = "" ;
         edtSignoHora_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtConsultaId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A103SignoPresionArterial = "" ;
         A106SignoFecha = DateTime.MinValue ;
         A107SignoHora = "" ;
         A41ClinicaCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV8cSignoEstaturaEn = "" ;
         lV10cSignoPesoEn = "" ;
         H000W2_A91ConsultaId = new int[1] ;
         H000W2_A41ClinicaCodigo = new String[] {""} ;
         H000W2_A107SignoHora = new String[] {""} ;
         H000W2_A106SignoFecha = new DateTime[] {DateTime.MinValue} ;
         H000W2_A104SignoFrecCardiaca = new decimal[1] ;
         H000W2_A103SignoPresionArterial = new String[] {""} ;
         H000W2_A102SignoTemperaturaDe = new String[] {""} ;
         H000W2_A101SignoTemperatura = new decimal[1] ;
         H000W2_A100SignoPesoEn = new String[] {""} ;
         H000W2_A99SignoPeso = new decimal[1] ;
         H000W2_A98SignoEstaturaEn = new String[] {""} ;
         H000W2_A97SignoEstatura = new decimal[1] ;
         H000W2_A96SignoLinea = new short[1] ;
         H000W3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char13 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblocksignolinea_Jsonclick = "" ;
         lblTextblocksignoestatura_Jsonclick = "" ;
         lblTextblocksignoestaturaen_Jsonclick = "" ;
         lblTextblocksignopeso_Jsonclick = "" ;
         lblTextblocksignopesoen_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char14 = "" ;
         ROClassString = "" ;
         GXt_char15 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00q2__default(),
            new Object[][] {
                new Object[] {
               H000W2_A91ConsultaId, H000W2_A41ClinicaCodigo, H000W2_A107SignoHora, H000W2_A106SignoFecha, H000W2_A104SignoFrecCardiaca, H000W2_A103SignoPresionArterial, H000W2_A102SignoTemperaturaDe, H000W2_A101SignoTemperatura, H000W2_A100SignoPesoEn, H000W2_A99SignoPeso,
               H000W2_A98SignoEstaturaEn, H000W2_A97SignoEstatura, H000W2_A96SignoLinea
               }
               , new Object[] {
               H000W3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_41_idx=1 ;
      private short AV6cSignoLinea ;
      private short AV13pSignoLinea ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A96SignoLinea ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV12pConsultaId ;
      private int wcpOAV12pConsultaId ;
      private int Grid1_PageSize41 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A91ConsultaId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV7cSignoEstatura ;
      private decimal AV9cSignoPeso ;
      private decimal A97SignoEstatura ;
      private decimal A99SignoPeso ;
      private decimal A101SignoTemperatura ;
      private decimal A104SignoFrecCardiaca ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_41_idx="0001" ;
      private String GXCCtl ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtSignoLinea_Internalname ;
      private String edtSignoEstatura_Internalname ;
      private String cmbSignoEstaturaEn_Internalname ;
      private String edtSignoPeso_Internalname ;
      private String cmbSignoPesoEn_Internalname ;
      private String edtSignoTemperatura_Internalname ;
      private String cmbSignoTemperaturaDe_Internalname ;
      private String edtSignoPresionArterial_Internalname ;
      private String edtSignoFrecCardiaca_Internalname ;
      private String edtSignoFecha_Internalname ;
      private String edtSignoHora_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtConsultaId_Internalname ;
      private String A107SignoHora ;
      private String edtavCsignolinea_Internalname ;
      private String scmdbuf ;
      private String edtavCsignoestatura_Internalname ;
      private String cmbavCsignoestaturaen_Internalname ;
      private String edtavCsignopeso_Internalname ;
      private String cmbavCsignopesoen_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String edtavLinkselection_Link ;
      private String edtSignoEstatura_Link ;
      private String GXt_char13 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblocksignolinea_Internalname ;
      private String lblTextblocksignolinea_Jsonclick ;
      private String edtavCsignolinea_Jsonclick ;
      private String lblTextblocksignoestatura_Internalname ;
      private String lblTextblocksignoestatura_Jsonclick ;
      private String edtavCsignoestatura_Jsonclick ;
      private String lblTextblocksignoestaturaen_Internalname ;
      private String lblTextblocksignoestaturaen_Jsonclick ;
      private String cmbavCsignoestaturaen_Jsonclick ;
      private String lblTextblocksignopeso_Internalname ;
      private String lblTextblocksignopeso_Jsonclick ;
      private String edtavCsignopeso_Jsonclick ;
      private String lblTextblocksignopesoen_Internalname ;
      private String lblTextblocksignopesoen_Jsonclick ;
      private String cmbavCsignopesoen_Jsonclick ;
      private String GXt_char14 ;
      private String ROClassString ;
      private String edtSignoLinea_Jsonclick ;
      private String edtSignoEstatura_Jsonclick ;
      private String cmbSignoEstaturaEn_Jsonclick ;
      private String edtSignoPeso_Jsonclick ;
      private String cmbSignoPesoEn_Jsonclick ;
      private String edtSignoTemperatura_Jsonclick ;
      private String cmbSignoTemperaturaDe_Jsonclick ;
      private String edtSignoPresionArterial_Jsonclick ;
      private String edtSignoFrecCardiaca_Jsonclick ;
      private String edtSignoFecha_Jsonclick ;
      private String edtSignoHora_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtConsultaId_Jsonclick ;
      private String GXt_char15 ;
      private DateTime A106SignoFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV11pClinicaCodigo ;
      private String wcpOAV11pClinicaCodigo ;
      private String AV8cSignoEstaturaEn ;
      private String AV10cSignoPesoEn ;
      private String A98SignoEstaturaEn ;
      private String A100SignoPesoEn ;
      private String A102SignoTemperaturaDe ;
      private String A103SignoPresionArterial ;
      private String A41ClinicaCodigo ;
      private String lV8cSignoEstaturaEn ;
      private String lV10cSignoPesoEn ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCsignoestaturaen ;
      private GXCombobox cmbavCsignopesoen ;
      private GXCombobox cmbSignoEstaturaEn ;
      private GXCombobox cmbSignoPesoEn ;
      private GXCombobox cmbSignoTemperaturaDe ;
      private IDataStoreProvider pr_default ;
      private int[] H000W2_A91ConsultaId ;
      private String[] H000W2_A41ClinicaCodigo ;
      private String[] H000W2_A107SignoHora ;
      private DateTime[] H000W2_A106SignoFecha ;
      private decimal[] H000W2_A104SignoFrecCardiaca ;
      private String[] H000W2_A103SignoPresionArterial ;
      private String[] H000W2_A102SignoTemperaturaDe ;
      private decimal[] H000W2_A101SignoTemperatura ;
      private String[] H000W2_A100SignoPesoEn ;
      private decimal[] H000W2_A99SignoPeso ;
      private String[] H000W2_A98SignoEstaturaEn ;
      private decimal[] H000W2_A97SignoEstatura ;
      private short[] H000W2_A96SignoLinea ;
      private int[] H000W3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP2_pSignoLinea ;
      private GXWebForm Form ;
   }

   public class gx00q2__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000W2 ;
          prmH000W2 = new Object[] {
          new Object[] {"@AV11pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cSignoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cSignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@lV8cSignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV9cSignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@lV10cSignoPesoEn",SqlDbType.VarChar,2,0}
          } ;
          Object[] prmH000W3 ;
          prmH000W3 = new Object[] {
          new Object[] {"@AV11pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV12pConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV6cSignoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cSignoEstatura",SqlDbType.Decimal,8,2} ,
          new Object[] {"@lV8cSignoEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV9cSignoPeso",SqlDbType.Decimal,8,2} ,
          new Object[] {"@lV10cSignoPesoEn",SqlDbType.VarChar,2,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000W2", "SELECT [ConsultaId], [ClinicaCodigo], [SignoHora], [SignoFecha], [SignoFrecCardiaca], [SignoPresionArterial], [SignoTemperaturaDe], [SignoTemperatura], [SignoPesoEn], [SignoPeso], [SignoEstaturaEn], [SignoEstatura], [SignoLinea] FROM [ConsultaSigno] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV11pClinicaCodigo and [ConsultaId] = @AV12pConsultaId and [SignoLinea] >= @AV6cSignoLinea) AND ([SignoEstatura] >= @AV7cSignoEstatura) AND ([SignoEstaturaEn] like @lV8cSignoEstaturaEn) AND ([SignoPeso] >= @AV9cSignoPeso) AND ([SignoPesoEn] like @lV10cSignoPesoEn) ORDER BY [ClinicaCodigo], [ConsultaId], [SignoLinea]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W2,11,0,false,false )
             ,new CursorDef("H000W3", "SELECT COUNT(*) FROM [ConsultaSigno] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV11pClinicaCodigo and [ConsultaId] = @AV12pConsultaId and [SignoLinea] >= @AV6cSignoLinea) AND ([SignoEstatura] >= @AV7cSignoEstatura) AND ([SignoEstaturaEn] like @lV8cSignoEstaturaEn) AND ([SignoPeso] >= @AV9cSignoPeso) AND ([SignoPesoEn] like @lV10cSignoPesoEn) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000W3,1,0,false,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((decimal[]) buf[4])[0] = rslt.getDecimal(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((decimal[]) buf[7])[0] = rslt.getDecimal(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((decimal[]) buf[9])[0] = rslt.getDecimal(10) ;
                ((String[]) buf[10])[0] = rslt.getVarchar(11) ;
                ((decimal[]) buf[11])[0] = rslt.getDecimal(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (decimal)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
