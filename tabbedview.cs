/*
               File: TabbedView
        Description: Tabbed View
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:3:27.15
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
using GeneXus.Http.Server;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class tabbedview : GXWebComponent, System.Web.SessionState.IRequiresSessionState
   {
      public tabbedview( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public tabbedview( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( IGxCollection aP0_Tabs ,
                           String aP1_TabCode )
      {
         this.AV18Tabs = aP0_Tabs;
         this.AV15TabCode = aP1_TabCode;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      public override void SetPrefix( String sPPrefix )
      {
         sPrefix = sPPrefix;
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( StringUtil.Len( (String)(sPrefix)) == 0 )
         {
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
               else if ( StringUtil.StrCmp(gxfirstwebparm, "dyncomponent") == 0 )
               {
                  setAjaxEventMode();
                  if ( ! IsValidAjaxCall( true) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  nDynComponent = 1 ;
                  sCompPrefix = GetNextPar( ) ;
                  sSFPrefix = GetNextPar( ) ;
                  ajax_req_read_hidden_sdt(GetNextPar( ), (Object)(AV18Tabs));
                  AV15TabCode = GetNextPar( ) ;
                  componentprepare(new Object[] {(String)sCompPrefix,(String)sSFPrefix,(IGxCollection)AV18Tabs,(String)AV15TabCode});
                  componentstart();
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix);
                  componentdraw();
                  context.httpAjaxContext.ajax_rspEndCmp();
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
               else
               {
                  if ( ! IsValidAjaxCall( false) )
                  {
                     GxWebError = 1 ;
                     return  ;
                  }
                  gxfirstwebparm = gxfirstwebparm_bkp ;
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
            PA2B2( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS2B2( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  if ( nDynComponent == 0 )
                  {
                     throw new System.Net.WebException("WebComponent is not allowed to run") ;
                  }
               }
            }
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

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.WriteHtmlText( "<title>") ;
            context.WriteHtmlText( "Tabbed View") ;
            context.WriteHtmlTextNl( "</title>") ;
            if ( StringUtil.Len( sDynURL) > 0 )
            {
               context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
            }
            define_styles( ) ;
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
         }
         context.AddJavascriptSource("HistoryManager/rsh/json2005.js", "");
         context.AddJavascriptSource("HistoryManager/rsh/rsh.js", "");
         context.AddJavascriptSource("HistoryManager/HistoryManagerCreate.js", "");
         context.AddJavascriptSource("HistoryManager/HistoryManager.js", "");
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            context.CloseHtmlHeader();
            FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
            context.WriteHtmlText( "<body") ;
            context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;white-space: nowrap;") ;
            context.WriteHtmlText( "\""+FormProcess+">") ;
            context.skipLines(1);
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV15TabCode)) ;
            context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("tabbedview.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
            GxWebStd.gx_hidden_field( context, "_EventName", "");
            GxWebStd.gx_hidden_field( context, "_EventGridId", "");
            GxWebStd.gx_hidden_field( context, "_EventRowId", "");
         }
      }

      protected void RenderHtmlCloseForm2B2( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, sPrefix+"wcpOAV15TabCode", StringUtil.RTrim( wcpOAV15TabCode));
         GxWebStd.gx_hidden_field( context, sPrefix+"HISTORYMANAGER_Hash", StringUtil.RTrim( Historymanager_Hash));
         if ( ( StringUtil.Len( sPrefix) != 0 ) && context.isAjaxRequest( ) )
         {
            context.AddJavascriptSource("tabbedview.js", "?1532718");
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"GX_FocusControl", GX_FocusControl);
         define_styles( ) ;
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            SendAjaxEncryptionKey();
            SendComponentObjects();
            SendServerCommands();
            SendState();
            context.WriteHtmlTextNl( "</form>") ;
            include_jscripts( ) ;
            if ( ! ( WebComp_Component == null ) )
            {
               WebComp_Component.componentjscripts();
            }
            context.WriteHtmlTextNl( "</body>") ;
            context.WriteHtmlTextNl( "</html>") ;
         }
      }

      protected void WB2B0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               RenderHtmlHeaders( ) ;
            }
            RenderHtmlOpenForm( ) ;
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               GxWebStd.gx_hidden_field( context, sPrefix+"_CMPPGM", "tabbedview.aspx");
               context.AddJavascriptSource("HistoryManager/rsh/json2005.js", "");
               context.AddJavascriptSource("HistoryManager/rsh/rsh.js", "");
               context.AddJavascriptSource("HistoryManager/HistoryManagerCreate.js", "");
               context.AddJavascriptSource("HistoryManager/HistoryManager.js", "");
            }
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", sPrefix, "false");
            wb_table1_2_2B2( true) ;
         }
         else
         {
            wb_table1_2_2B2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2B2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+sPrefix+"HISTORYMANAGERContainer"+"\"></div>") ;
         }
         wbLoad = true ;
      }

      protected void START2B2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         if ( StringUtil.Len( sPrefix) != 0 )
         {
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         }
         if ( StringUtil.Len( sPrefix) == 0 )
         {
            Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
            Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
            Form.Meta.addItem("Description", "Tabbed View", 0) ;
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
            context.wbHandled = 0 ;
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               sXEvt = cgiGet( "_EventName") ;
               if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
               {
                  OldComponent = cgiGet( sPrefix+"W0013") ;
                  if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Component_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldComponent)) )
                  {
                     WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", OldComponent, new Object[] {context} );
                     WebComp_Component.ComponentInit();
                     WebComp_Component.Name = "OldComponent";
                     WebComp_Component_Component = OldComponent ;
                     WebComp_Component.componentrestorestate(sPrefix+"W0013", "");
                  }
               }
            }
         }
         wbErr = false ;
         if ( ( StringUtil.Len( sPrefix) == 0 ) || ( nDraw == 1 ) )
         {
            if ( nDoneStart == 0 )
            {
               STRUP2B0( ) ;
            }
         }
      }

      protected void WS2B2( )
      {
         START2B2( ) ;
         EVT2B2( ) ;
      }

      protected void EVT2B2( )
      {
         sXEvt = cgiGet( "_EventName") ;
         if ( ( ( ( StringUtil.Len( sPrefix) == 0 ) ) || ( StringUtil.StringSearch( sXEvt, sPrefix, 1) > 0 ) ) && ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               if ( context.wbHandled == 0 )
               {
                  if ( StringUtil.Len( sPrefix) == 0 )
                  {
                     sEvt = cgiGet( "_EventName") ;
                     EvtGridId = cgiGet( "_EventGridId") ;
                     EvtRowId = cgiGet( "_EventRowId") ;
                  }
                  if ( StringUtil.Len( sEvt) > 0 )
                  {
                     sEvtType = StringUtil.Left( sEvt, 1) ;
                     sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "HISTORYMANAGER.URLCHANGED") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E112B2 */
                                    E112B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E122B2 */
                                    E122B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "REFRESH") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E132B2 */
                                    E132B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                    /* Execute user event: E142B2 */
                                    E142B2 ();
                                 }
                              }
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              if ( ( StringUtil.Len( sPrefix) != 0 ) && ( nDoneStart == 0 ) )
                              {
                                 STRUP2B0( ) ;
                              }
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
                              {
                                 context.wbHandled = 1 ;
                                 if ( ! wbErr )
                                 {
                                    dynload_actions( ) ;
                                 }
                              }
                           }
                        }
                        else
                        {
                        }
                     }
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 13 )
                        {
                           OldComponent = cgiGet( sPrefix+"W0013") ;
                           if ( ( StringUtil.Len( OldComponent) == 0 ) || ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 ) )
                           {
                              WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", OldComponent, new Object[] {context} );
                              WebComp_Component.ComponentInit();
                              WebComp_Component.Name = "OldComponent";
                              WebComp_Component_Component = OldComponent ;
                           }
                           if ( StringUtil.Len( WebComp_Component_Component) != 0 )
                           {
                              WebComp_Component.componentprocess(sPrefix+"W0013", "", sEvt);
                           }
                           WebComp_Component_Component = OldComponent ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE2B2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm2B2( ) ;
            }
         }
      }

      protected void PA2B2( )
      {
         if ( nDonePA == 0 )
         {
            if ( StringUtil.Len( sPrefix) != 0 )
            {
               initialize_properties( ) ;
            }
            if ( StringUtil.Len( sPrefix) == 0 )
            {
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
               {
                  GxWebError = 1 ;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
               }
               if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
               {
                  GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
                  GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
                  if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
                  {
                     SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
                  }
                  else
                  {
                     GxWebError = 1 ;
                     context.HttpContext.Response.StatusDescription = 403.ToString();
                     context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                     context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                     context.WriteHtmlText( "<p /><hr />") ;
                  }
               }
            }
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( StringUtil.Len( sPrefix) == 0 )
               {
                  if ( nGotPars == 0 )
                  {
                     entryPointCalled = false ;
                     gxfirstwebparm = GetNextPar( ) ;
                  }
               }
            }
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF2B2( ) ;
         /* End function Refresh */
      }

      protected void RF2B2( )
      {
         /* Execute user event: E132B2 */
         E132B2 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Component_Component) != 0 )
               {
                  WebComp_Component.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E142B2 */
            E142B2 ();
            WB2B0( ) ;
         }
      }

      protected void STRUP2B0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E122B2 */
         E122B2 ();
         context.wbGlbDoneStart = 1 ;
         nDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         sXEvt = cgiGet( "_EventName") ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            wcpOAV15TabCode = cgiGet( sPrefix+"wcpOAV15TabCode") ;
            OldComponent = cgiGet( sPrefix+"W0013") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Component_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldComponent)) )
            {
               WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", OldComponent, new Object[] {context} );
               WebComp_Component.ComponentInit();
               WebComp_Component.Name = "OldComponent";
               WebComp_Component_Component = OldComponent ;
               WebComp_Component.componentrestorestate(sPrefix+"W0013", "");
            }
            Historymanager_Hash = cgiGet( sPrefix+"HISTORYMANAGER_Hash") ;
            Historymanager_Url = cgiGet( sPrefix+"HISTORYMANAGER_Url") ;
            Historymanager_Querystring = cgiGet( sPrefix+"HISTORYMANAGER_Querystring") ;
            Historymanager_Visible = StringUtil.StrToBool( cgiGet( sPrefix+"HISTORYMANAGER_Visible")) ;
            Historymanager_Hash = cgiGet( sPrefix+"HISTORYMANAGER_Hash") ;
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
         /* Execute user event: E122B2 */
         E122B2 ();
         if (returnInSub) return;
      }

      protected void E122B2( )
      {
         /* Start Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
      }

      protected void E112B2( )
      {
         /* Historymanager_Urlchanged Routine */
         /* Execute user subroutine: S122 */
         S122 ();
         if (returnInSub) return;
         AV23URLChangedEvent = true ;
      }

      protected void E132B2( )
      {
         /* Refresh Routine */
         if ( ! AV23URLChangedEvent )
         {
            /* Execute user subroutine: S122 */
            S122 ();
            if (returnInSub) return;
         }
      }

      protected void S112( )
      {
         /* 'INIT' Routine */
         AV20TabTemplate = "<li class=\"%1\">" ;
         AV20TabTemplate = AV20TabTemplate + "<a id=\"%2Tab\" %3%7 class=\"%4\">" ;
         AV20TabTemplate = AV20TabTemplate + "<span class=\"%5\">" ;
         AV20TabTemplate = AV20TabTemplate + "<span class=\"TabBackground\">" ;
         AV20TabTemplate = AV20TabTemplate + "<span class=\"TabText\">%6</span>" ;
         AV20TabTemplate = AV20TabTemplate + "</span>" ;
         AV20TabTemplate = AV20TabTemplate + "</span>" ;
         AV20TabTemplate = AV20TabTemplate + "</a>" ;
         AV20TabTemplate = AV20TabTemplate + "</li>" ;
      }

      protected void S122( )
      {
         /* 'DRAW TABS' Routine */
         /* Execute user subroutine: S132 */
         S132 ();
         if (returnInSub) return;
         /* Execute user subroutine: S142 */
         S142 ();
         if (returnInSub) return;
         AV9IsFirstTab = true ;
         AV19TabsMarkup = "" ;
         AV8Index = AV5FirstTab ;
         while ( AV8Index <= AV11LastTab )
         {
            AV14Tab = ((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index)) ;
            /* Execute user subroutine: S152 */
            S152 ();
            if (returnInSub) return;
            AV9IsFirstTab = false ;
            AV8Index = (short)(AV8Index+1) ;
         }
         lblTabs_Caption = StringUtil.Format( "<ul class=\"Tabs\">%1</ul>", AV19TabsMarkup, "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, lblTabs_Internalname, "Caption", lblTabs_Caption);
      }

      protected void S132( )
      {
         /* 'FINDTABINDEX' Routine */
         AV6Found = false ;
         AV8Index = 1 ;
         while ( AV8Index <= AV18Tabs.Count )
         {
            if ( ( ( StringUtil.StrCmp(Historymanager_Hash, "") == 0 ) && ( ( StringUtil.StrCmp(((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index)).gxTpr_Code, AV15TabCode) == 0 ) ) ) || ( ( StringUtil.StrCmp(((SdtTabOptions_TabOptionsItem)AV18Tabs.Item(AV8Index)).gxTpr_Code, Historymanager_Hash) == 0 ) ) )
            {
               AV13SelectedTab = AV8Index ;
               AV6Found = true ;
               if (true) break;
            }
            AV8Index = (short)(AV8Index+1) ;
         }
         if ( ! AV6Found && ( AV18Tabs.Count > 0 ) )
         {
            AV13SelectedTab = 1 ;
         }
      }

      protected void S142( )
      {
         /* 'SCROLLTABS' Routine */
         AV5FirstTab = 1 ;
         AV11LastTab = (short)(AV18Tabs.Count) ;
         imgTabprevious_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgTabprevious_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgTabprevious_Visible), 5, 0)));
         imgTabnext_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop(sPrefix, false, imgTabnext_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgTabnext_Visible), 5, 0)));
      }

      protected void S152( )
      {
         /* 'LOADITEM' Routine */
         AV16TabLeftCls = "TabLeft" ;
         if ( AV8Index == AV5FirstTab )
         {
            AV16TabLeftCls = "TabFirst" ;
         }
         AV17TabRightCls = "TabRight" ;
         if ( AV8Index == AV11LastTab )
         {
            AV17TabRightCls = "TabLast" ;
         }
         if ( AV8Index == AV13SelectedTab )
         {
            AV19TabsMarkup = AV19TabsMarkup + StringUtil.Format( AV20TabTemplate, "Tab TabSelected", AV14Tab.gxTpr_Code, "", AV16TabLeftCls, AV17TabRightCls, AV14Tab.gxTpr_Description, "", "", "") ;
            AV21WebComponentUrl = AV14Tab.gxTpr_Webcomponent ;
            /* Object Property */
            gxDynCompUrl = AV21WebComponentUrl ;
            if ( ! IsSameComponent( WebComp_Component_Component, gxDynCompUrl) )
            {
               WebComp_Component = getWebComponent(GetType(), "GeneXus.Programs", gxDynCompUrl, new Object[] {context} );
               WebComp_Component.ComponentInit();
               WebComp_Component.Name = "gxDynCompUrl";
               WebComp_Component_Component = gxDynCompUrl ;
            }
            else
            {
               WebComp_Component.setparmsfromurl(gxDynCompUrl);
            }
            if ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 )
            {
               WebComp_Component.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Component_Component) != 0 )
            {
               WebComp_Component.componentprepare(new Object[] {(String)sPrefix+"W0013",(String)""});
               WebComp_Component.componentbind(new Object[] {});
            }
         }
         else
         {
            AV12OnClickTemplate = " onclick=\"return HistoryManager.AddHistoryPoint(" + "'%1'" + ")\"" ;
            AV19TabsMarkup = AV19TabsMarkup + StringUtil.Format( AV20TabTemplate, "Tab", AV14Tab.gxTpr_Code, StringUtil.Format( "href=\"%1\"", AV14Tab.gxTpr_Link, "", "", "", "", "", "", "", ""), AV16TabLeftCls, AV17TabRightCls, AV14Tab.gxTpr_Description, StringUtil.Format( AV12OnClickTemplate, AV14Tab.gxTpr_Code, "", "", "", "", "", "", "", ""), "", "") ;
         }
      }

      protected void nextLoad( )
      {
      }

      protected void E142B2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_2B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "ViewTable", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr valign=\"bottom\" >") ;
            context.WriteHtmlText( "<td valign=\"bottom\"  style=\"height:40px\">") ;
            context.WriteHtmlText( "<div class=\"TabContainer\" id=\"TabContainer\">") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTabs_Internalname, lblTabs_Caption, "", "", lblTabs_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 1, "HLP_TabbedView.htm");
            /* Static images/pictures */
            ClassString = "TabPagingPrevious" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgTabprevious_Internalname, context.GetImagePath( "23d403d6-d1e5-4c79-aab4-f073de218b70", "", "Fantastic"), "", "", "", "Fantastic", imgTabprevious_Visible, 1, "", "Previous Tab", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_TabbedView.htm");
            /* Static images/pictures */
            ClassString = "TabPagingNext" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgTabnext_Internalname, context.GetImagePath( "f12b6130-24bd-4bf1-be14-7f0779ca7d89", "", "Fantastic"), "", "", "", "Fantastic", imgTabnext_Visible, 1, "", "Next Tab", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_TabbedView.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\"  style=\"height:39px\">") ;
            wb_table2_10_2B2( true) ;
         }
         else
         {
            wb_table2_10_2B2( false) ;
         }
         return  ;
      }

      protected void wb_table2_10_2B2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2B2e( true) ;
         }
         else
         {
            wb_table1_2_2B2e( false) ;
         }
      }

      protected void wb_table2_10_2B2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "TableBorder", 0, "", "", 0, 0, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" >") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, sPrefix+"W0013"+"", StringUtil.RTrim( WebComp_Component_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+sPrefix+"gxHTMLWrpW0013"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Component_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp(sPrefix+"gxHTMLWrpW0013"+"");
               }
               WebComp_Component.componentdraw();
               if ( StringUtil.StrCmp(OldComponent, WebComp_Component_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_10_2B2e( true) ;
         }
         else
         {
            wb_table2_10_2B2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV18Tabs = (IGxCollection)getParm(obj,0) ;
         AV15TabCode = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15TabCode", AV15TabCode);
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
         PA2B2( ) ;
         WS2B2( ) ;
         WE2B2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void componentbind( Object[] obj )
      {
         if ( IsUrlCreated( ) )
         {
            return  ;
         }
         sCtrlAV18Tabs = (String)((String)getParm(obj,0)) ;
         sCtrlAV15TabCode = (String)((String)getParm(obj,1)) ;
      }

      public override void componentrestorestate( String sPPrefix ,
                                                  String sPSFPrefix )
      {
         sPrefix = sPPrefix + sPSFPrefix ;
         PA2B2( ) ;
         WCParametersGet( ) ;
      }

      public override void componentprepare( Object[] obj )
      {
         wbLoad = false ;
         sCompPrefix = (String)getParm(obj,0) ;
         sSFPrefix = (String)getParm(obj,1) ;
         sPrefix = sCompPrefix + sSFPrefix ;
         AddComponentObject(sPrefix, "tabbedview");
         if ( ( nDoneStart == 0 ) && ( nDynComponent == 0 ) )
         {
            INITWEB( ) ;
         }
         else
         {
            init_default_properties( ) ;
         }
         PA2B2( ) ;
         if ( ! GetJustCreated( ) && ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 ) && ( context.wbGlbDoneStart == 0 ) )
         {
            WCParametersGet( ) ;
         }
         else
         {
            AV18Tabs = (IGxCollection)getParm(obj,2) ;
            AV15TabCode = (String)getParm(obj,3) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15TabCode", AV15TabCode);
         }
         wcpOAV15TabCode = cgiGet( sPrefix+"wcpOAV15TabCode") ;
         if ( ! GetJustCreated( ) && ( ( StringUtil.StrCmp(AV15TabCode, wcpOAV15TabCode) != 0 ) ) )
         {
            setjustcreated();
         }
         wcpOAV15TabCode = AV15TabCode ;
      }

      protected void WCParametersGet( )
      {
         /* Read Component Parameters. */
         sCtrlAV18Tabs = cgiGet( sPrefix+"AV18Tabs_CTRL") ;
         if ( StringUtil.Len( sCtrlAV18Tabs) > 0 )
         {
            AV18Tabs.FromXml(cgiGet( sCtrlAV18Tabs), "");
         }
         else
         {
            ajax_req_read_hidden_sdt(cgiGet( sPrefix+"AV18Tabs_PARM"), (Object)(AV18Tabs));
         }
         sCtrlAV15TabCode = cgiGet( sPrefix+"AV15TabCode_CTRL") ;
         if ( StringUtil.Len( sCtrlAV15TabCode) > 0 )
         {
            AV15TabCode = cgiGet( sCtrlAV15TabCode) ;
            context.httpAjaxContext.ajax_rsp_assign_attri(sPrefix, false, "AV15TabCode", AV15TabCode);
         }
         else
         {
            AV15TabCode = cgiGet( sPrefix+"AV15TabCode_PARM") ;
         }
      }

      public override void componentprocess( String sPPrefix ,
                                             String sPSFPrefix ,
                                             String sCompEvt )
      {
         sCompPrefix = sPPrefix ;
         sSFPrefix = sPSFPrefix ;
         sPrefix = sCompPrefix + sSFPrefix ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         INITWEB( ) ;
         nDraw = 0 ;
         PA2B2( ) ;
         sEvt = sCompEvt ;
         WCParametersGet( ) ;
         WS2B2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override void componentstart( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
      }

      protected void WCStart( )
      {
         nDraw = 1 ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WS2B2( ) ;
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      protected void WCParametersSet( )
      {
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri(sPrefix, false, sPrefix+"AV18Tabs_PARM", (Object)(AV18Tabs));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt(sPrefix+"AV18Tabs_PARM", (Object)(AV18Tabs));
         }
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV18Tabs)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV18Tabs_CTRL", StringUtil.RTrim( sCtrlAV18Tabs));
         }
         GxWebStd.gx_hidden_field( context, sPrefix+"AV15TabCode_PARM", StringUtil.RTrim( AV15TabCode));
         if ( StringUtil.Len( StringUtil.RTrim( sCtrlAV15TabCode)) > 0 )
         {
            GxWebStd.gx_hidden_field( context, sPrefix+"AV15TabCode_CTRL", StringUtil.RTrim( sCtrlAV15TabCode));
         }
      }

      public override void componentdraw( )
      {
         if ( nDoneStart == 0 )
         {
            WCStart( ) ;
         }
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         WCParametersSet( ) ;
         WE2B2( ) ;
         this.cleanup();
         SaveComponentMsgList(sPrefix);
         context.GX_msglist = BackMsgLst ;
      }

      public override String getstring( String sGXControl )
      {
         String sCtrlName ;
         if ( StringUtil.StrCmp(StringUtil.Substring( sGXControl, 1, 1), "&") == 0 )
         {
            sCtrlName = StringUtil.Substring( sGXControl, 2, StringUtil.Len( sGXControl)-1) ;
         }
         else
         {
            sCtrlName = sGXControl ;
         }
         return cgiGet( sPrefix+"v"+StringUtil.Upper( sCtrlName)) ;
      }

      public override void componentjscripts( )
      {
         include_jscripts( ) ;
         if ( ! ( WebComp_Component == null ) )
         {
            WebComp_Component.componentjscripts();
         }
      }

      public override void componentthemes( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         if ( ! ( WebComp_Component == null ) )
         {
            if ( StringUtil.Len( WebComp_Component_Component) != 0 )
            {
               WebComp_Component.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1532741");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("tabbedview.js", "?1532741");
         context.AddJavascriptSource("HistoryManager/rsh/json2005.js", "");
         context.AddJavascriptSource("HistoryManager/rsh/rsh.js", "");
         context.AddJavascriptSource("HistoryManager/HistoryManagerCreate.js", "");
         context.AddJavascriptSource("HistoryManager/HistoryManager.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTabs_Internalname = sPrefix+"TABS" ;
         imgTabprevious_Internalname = sPrefix+"TABPREVIOUS" ;
         imgTabnext_Internalname = sPrefix+"TABNEXT" ;
         tblTable2_Internalname = sPrefix+"TABLE2" ;
         tblTable1_Internalname = sPrefix+"TABLE1" ;
         Historymanager_Internalname = sPrefix+"HISTORYMANAGER" ;
         Form.Internalname = sPrefix+"FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         imgTabnext_Visible = 1 ;
         imgTabprevious_Visible = 1 ;
         lblTabs_Jsonclick = "" ;
         lblTabs_Caption = "Tabs" ;
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
         AV18Tabs = new GxObjectCollection( context, "TabOptions.TabOptionsItem", "Clinica", "SdtTabOptions_TabOptionsItem", "GeneXus.Programs");
         wcpOAV15TabCode = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sPrefix = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         Historymanager_Hash = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sXEvt = "" ;
         OldComponent = "" ;
         WebComp_Component_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         gxDynCompUrl = "" ;
         GXDecQS = "" ;
         Historymanager_Url = "" ;
         Historymanager_Querystring = "" ;
         AV20TabTemplate = "" ;
         AV19TabsMarkup = "" ;
         AV14Tab = new SdtTabOptions_TabOptionsItem(context);
         AV16TabLeftCls = "" ;
         AV17TabRightCls = "" ;
         AV21WebComponentUrl = "" ;
         AV12OnClickTemplate = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sCtrlAV18Tabs = "" ;
         sCtrlAV15TabCode = "" ;
         GXt_char3 = "" ;
         GXt_char4 = "" ;
         WebComp_Component = new GeneXus.Http.GXNullWebComponent();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nDynComponent ;
      private short initialized ;
      private short wbEnd ;
      private short wbStart ;
      private short nDraw ;
      private short nDoneStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV8Index ;
      private short AV5FirstTab ;
      private short AV11LastTab ;
      private short AV13SelectedTab ;
      private short nGXWrapped ;
      private int imgTabprevious_Visible ;
      private int imgTabnext_Visible ;
      private int idxLst ;
      private String AV15TabCode ;
      private String wcpOAV15TabCode ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sPrefix ;
      private String sCompPrefix ;
      private String sSFPrefix ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String Historymanager_Hash ;
      private String GX_FocusControl ;
      private String sXEvt ;
      private String OldComponent ;
      private String WebComp_Component_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String gxDynCompUrl ;
      private String GXDecQS ;
      private String Historymanager_Url ;
      private String Historymanager_Querystring ;
      private String AV20TabTemplate ;
      private String AV19TabsMarkup ;
      private String lblTabs_Caption ;
      private String lblTabs_Internalname ;
      private String imgTabprevious_Internalname ;
      private String imgTabnext_Internalname ;
      private String AV16TabLeftCls ;
      private String AV17TabRightCls ;
      private String AV12OnClickTemplate ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTabs_Jsonclick ;
      private String tblTable2_Internalname ;
      private String sCtrlAV18Tabs ;
      private String sCtrlAV15TabCode ;
      private String GXt_char3 ;
      private String Historymanager_Internalname ;
      private String GXt_char4 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool Historymanager_Visible ;
      private bool returnInSub ;
      private bool AV23URLChangedEvent ;
      private bool AV9IsFirstTab ;
      private bool AV6Found ;
      private String AV21WebComponentUrl ;
      private GXWebComponent WebComp_Component ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtTabOptions_TabOptionsItem ))]
      private IGxCollection AV18Tabs ;
      private SdtTabOptions_TabOptionsItem AV14Tab ;
   }

}
