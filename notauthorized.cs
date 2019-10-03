/*
               File: NotAuthorized
        Description: Not Authorized web panel
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:50.1
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
   public class notauthorized : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public notauthorized( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public notauthorized( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_GxObject )
      {
         this.GxObject = aP0_GxObject;
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
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
               GxObject = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GxObject", GxObject);
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
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
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
         PA292( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START292( ) ;
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
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(GxObject)) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("notauthorized.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vGXOBJECT", StringUtil.RTrim( GxObject));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Headerbc == null ) )
         {
            WebComp_Headerbc.componentjscripts();
         }
         if ( ! ( WebComp_Recentlinks == null ) )
         {
            WebComp_Recentlinks.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE292( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT292( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "NotAuthorized" ;
      }

      public override String GetPgmdesc( )
      {
         return "Not Authorized web panel" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode(StringUtil.RTrim(GxObject)) ;
         return formatLink("notauthorized.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void WB290( )
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
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0002"+"", StringUtil.RTrim( WebComp_Headerbc_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0002"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.StrCmp(OldHeaderbc, WebComp_Headerbc_Component) != 0 )
            {
               context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0002"+"");
            }
            WebComp_Headerbc.componentdraw();
            if ( StringUtil.StrCmp(OldHeaderbc, WebComp_Headerbc_Component) != 0 )
            {
               context.httpAjaxContext.ajax_rspEndCmp();
            }
            context.WriteHtmlText( "</div>") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0003"+"", StringUtil.RTrim( WebComp_Recentlinks_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0003"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldRecentlinks, WebComp_Recentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0003"+"");
               }
               WebComp_Recentlinks.componentdraw();
               if ( StringUtil.StrCmp(OldRecentlinks, WebComp_Recentlinks_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            wb_table1_4_292( true) ;
         }
         else
         {
            wb_table1_4_292( false) ;
         }
         return  ;
      }

      protected void wb_table1_4_292e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table2_13_292( true) ;
         }
         else
         {
            wb_table2_13_292( false) ;
         }
         return  ;
      }

      protected void wb_table2_13_292e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_16_292( true) ;
         }
         else
         {
            wb_table3_16_292( false) ;
         }
         return  ;
      }

      protected void wb_table3_16_292e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START292( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Not Authorized web panel", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldHeaderbc = cgiGet( "W0002") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Headerbc_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldHeaderbc)) )
            {
               WebComp_Headerbc = getWebComponent(GetType(), "GeneXus.Programs", OldHeaderbc, new Object[] {context} );
               WebComp_Headerbc.ComponentInit();
               WebComp_Headerbc.Name = "OldHeaderbc";
               WebComp_Headerbc_Component = OldHeaderbc ;
               WebComp_Headerbc.componentrestorestate("W0002", "");
            }
            OldRecentlinks = cgiGet( "W0003") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Recentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldRecentlinks)) )
            {
               WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldRecentlinks, new Object[] {context} );
               WebComp_Recentlinks.ComponentInit();
               WebComp_Recentlinks.Name = "OldRecentlinks";
               WebComp_Recentlinks_Component = OldRecentlinks ;
               WebComp_Recentlinks.componentrestorestate("W0003", "");
            }
         }
         wbErr = false ;
         STRUP290( ) ;
      }

      protected void WS292( )
      {
         START292( ) ;
         EVT292( ) ;
      }

      protected void EVT292( )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11292 */
                              E11292 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12292 */
                              E12292 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 2 )
                        {
                           OldHeaderbc = cgiGet( "W0002") ;
                           if ( ( StringUtil.Len( OldHeaderbc) == 0 ) || ( StringUtil.StrCmp(OldHeaderbc, WebComp_Headerbc_Component) != 0 ) )
                           {
                              WebComp_Headerbc = getWebComponent(GetType(), "GeneXus.Programs", OldHeaderbc, new Object[] {context} );
                              WebComp_Headerbc.ComponentInit();
                              WebComp_Headerbc.Name = "OldHeaderbc";
                              WebComp_Headerbc_Component = OldHeaderbc ;
                           }
                           WebComp_Headerbc.componentprocess("W0002", "", sEvt);
                           WebComp_Headerbc_Component = OldHeaderbc ;
                        }
                        else if ( nCmpId == 3 )
                        {
                           OldRecentlinks = cgiGet( "W0003") ;
                           if ( ( StringUtil.Len( OldRecentlinks) == 0 ) || ( StringUtil.StrCmp(OldRecentlinks, WebComp_Recentlinks_Component) != 0 ) )
                           {
                              WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldRecentlinks, new Object[] {context} );
                              WebComp_Recentlinks.ComponentInit();
                              WebComp_Recentlinks.Name = "OldRecentlinks";
                              WebComp_Recentlinks_Component = OldRecentlinks ;
                           }
                           if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
                           {
                              WebComp_Recentlinks.componentprocess("W0003", "", sEvt);
                           }
                           WebComp_Recentlinks_Component = OldRecentlinks ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE292( )
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

      protected void PA292( )
      {
         if ( nDonePA == 0 )
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
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( nGotPars == 0 )
               {
                  entryPointCalled = false ;
                  gxfirstwebparm = GetNextPar( ) ;
                  if ( ! entryPointCalled )
                  {
                     GxObject = gxfirstwebparm ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GxObject", GxObject);
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
         RF292( ) ;
         /* End function Refresh */
      }

      protected void RF292( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               WebComp_Headerbc.componentstart();
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
               {
                  WebComp_Recentlinks.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E12292 */
            E12292 ();
            WB290( ) ;
         }
      }

      protected void STRUP290( )
      {
         /* Before Start, stand alone formulas. */
         AV8Pgmname = "NotAuthorized" ;
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11292 */
         E11292 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            /* Read saved values. */
            GxObject = cgiGet( "vGXOBJECT") ;
            OldHeaderbc = cgiGet( "W0002") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Headerbc_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldHeaderbc)) )
            {
               WebComp_Headerbc = getWebComponent(GetType(), "GeneXus.Programs", OldHeaderbc, new Object[] {context} );
               WebComp_Headerbc.ComponentInit();
               WebComp_Headerbc.Name = "OldHeaderbc";
               WebComp_Headerbc_Component = OldHeaderbc ;
               WebComp_Headerbc.componentrestorestate("W0002", "");
            }
            OldRecentlinks = cgiGet( "W0003") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Recentlinks_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldRecentlinks)) )
            {
               WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", OldRecentlinks, new Object[] {context} );
               WebComp_Recentlinks.ComponentInit();
               WebComp_Recentlinks.Name = "OldRecentlinks";
               WebComp_Recentlinks_Component = OldRecentlinks ;
               WebComp_Recentlinks.componentrestorestate("W0003", "");
            }
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
         /* Execute user event: E11292 */
         E11292 ();
         if (returnInSub) return;
      }

      protected void E11292( )
      {
         /* Start Routine */
         /* Object Property */
         if ( StringUtil.StrCmp(WebComp_Recentlinks_Component, "RecentLinks") != 0 )
         {
            WebComp_Recentlinks = getWebComponent(GetType(), "GeneXus.Programs", "recentlinks", new Object[] {context} );
            WebComp_Recentlinks.ComponentInit();
            WebComp_Recentlinks.Name = "RecentLinks";
            WebComp_Recentlinks_Component = "RecentLinks" ;
         }
         if ( StringUtil.StrCmp(OldRecentlinks, WebComp_Recentlinks_Component) != 0 )
         {
            WebComp_Recentlinks.setjustcreated();
         }
         if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
         {
            WebComp_Recentlinks.componentprepare(new Object[] {(String)"W0003",(String)"",(String)"Not Authorized",(String)AV8Pgmname});
            WebComp_Recentlinks.componentbind(new Object[] {(String)"",(String)""});
         }
         GX_msglist.addItem("You are not authorized to do this action");
      }

      protected void nextLoad( )
      {
      }

      protected void E12292( )
      {
         /* Load Routine */
      }

      protected void wb_table3_16_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "HorizontalLine", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_16_292e( true) ;
         }
         else
         {
            wb_table3_16_292e( false) ;
         }
      }

      protected void wb_table2_13_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "HorizantalSpace", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_13_292e( true) ;
         }
         else
         {
            wb_table2_13_292e( false) ;
         }
      }

      protected void wb_table1_4_292( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            /* Text block */
            ClassString = "SubTitle" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitletext_Internalname, "Not Authorized", "", "", lblTitletext_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_NotAuthorized.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_4_292e( true) ;
         }
         else
         {
            wb_table1_4_292e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         GxObject = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GxObject", GxObject);
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
         PA292( ) ;
         WS292( ) ;
         WE292( ) ;
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
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         if ( ! ( WebComp_Headerbc == null ) )
         {
            WebComp_Headerbc.componentthemes();
         }
         if ( ! ( WebComp_Recentlinks == null ) )
         {
            if ( StringUtil.Len( WebComp_Recentlinks_Component) != 0 )
            {
               WebComp_Recentlinks.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1575012");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("notauthorized.js", "?1575012");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTitletext_Internalname = "TITLETEXT" ;
         tblTable1_Internalname = "TABLE1" ;
         tblTable2_Internalname = "TABLE2" ;
         tblTable3_Internalname = "TABLE3" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Not Authorized web panel" ;
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
         wcpOGxObject = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         WebComp_Headerbc_Component = "" ;
         OldHeaderbc = "" ;
         WebComp_Recentlinks_Component = "" ;
         GXt_char1 = "" ;
         OldRecentlinks = "" ;
         GXt_char2 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXDecQS = "" ;
         AV8Pgmname = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTitletext_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         WebComp_Headerbc = new GeneXus.Http.GXNullWebComponent();
         WebComp_Recentlinks = new GeneXus.Http.GXNullWebComponent();
         AV8Pgmname = "NotAuthorized" ;
         /* GeneXus formulas. */
         AV8Pgmname = "NotAuthorized" ;
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short nGXWrapped ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String WebComp_Headerbc_Component ;
      private String OldHeaderbc ;
      private String WebComp_Recentlinks_Component ;
      private String GXt_char1 ;
      private String OldRecentlinks ;
      private String GXt_char2 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXDecQS ;
      private String AV8Pgmname ;
      private String sStyleString ;
      private String tblTable3_Internalname ;
      private String tblTable2_Internalname ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTitletext_Internalname ;
      private String lblTitletext_Jsonclick ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String GxObject ;
      private String wcpOGxObject ;
      private GXWebComponent WebComp_Headerbc ;
      private GXWebComponent WebComp_Recentlinks ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

}
