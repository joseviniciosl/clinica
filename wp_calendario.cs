/*
               File: wp_calendario
        Description: Agenda Médica
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/10/2019 15:21:54.80
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
   public class wp_calendario : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_calendario( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_calendario( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
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
         PA272( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START272( ) ;
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
         context.AddJavascriptSource("GXScheduler/dhtmlxscheduler.js", "");
         context.AddJavascriptSource("GXScheduler/GXSchedulerRender.js", "");
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_calendario.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "vCURRENTEVENT", (Object)(AV5currentEvent));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vCURRENTEVENT", (Object)(AV5currentEvent));
         }
         GxWebStd.gx_hidden_field( context, "vINITIALDATE", context.localUtil.DToC( AV6initialDate, 0, "/"));
         GxWebStd.gx_hidden_field( context, "GXSCHEDULER1_Loadeventsobjectname", StringUtil.RTrim( Gxscheduler1_Loadeventsobjectname));
         GxWebStd.gx_hidden_field( context, "GXSCHEDULER1_Detailsformobjectname", StringUtil.RTrim( Gxscheduler1_Detailsformobjectname));
         GxWebStd.gx_hidden_field( context, "GXSCHEDULER1_Defaultsteptime", StringUtil.LTrim( StringUtil.NToC( (decimal)(Gxscheduler1_Defaultsteptime), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXSCHEDULER1_Firsthour", StringUtil.RTrim( Gxscheduler1_Firsthour));
         GxWebStd.gx_hidden_field( context, "GXSCHEDULER1_Lasthour", StringUtil.RTrim( Gxscheduler1_Lasthour));
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
            WE272( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT272( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_calendario" ;
      }

      public override String GetPgmdesc( )
      {
         return "Agenda Médica" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_calendario.aspx")  ;
      }

      protected void WB270( )
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
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, "", "", "", "false");
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"GXSCHEDULER1Container"+"\"></div>") ;
         }
         wbLoad = true ;
      }

      protected void START272( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Agenda Médica", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP270( ) ;
      }

      protected void WS272( )
      {
         START272( ) ;
         EVT272( ) ;
      }

      protected void EVT272( )
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
                           else if ( StringUtil.StrCmp(sEvt, "GXSCHEDULER1.EVENTADDED") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E11272 */
                              E11272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GXSCHEDULER1.EVENTDELETED") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E12272 */
                              E12272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GXSCHEDULER1.EVENTUPDATED") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E13272 */
                              E13272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E14272 */
                              E14272 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E15272 */
                              E15272 ();
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
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE272( )
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

      protected void PA272( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF272( ) ;
         /* End function Refresh */
      }

      protected void RF272( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E15272 */
            E15272 ();
            WB270( ) ;
         }
      }

      protected void STRUP270( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E14272 */
         E14272 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vCURRENTEVENT"), (Object)(AV5currentEvent));
            /* Read variables values. */
            /* Read saved values. */
            AV6initialDate = context.localUtil.CToD( cgiGet( "vINITIALDATE"), 0) ;
            Gxscheduler1_View = cgiGet( "GXSCHEDULER1_View") ;
            Gxscheduler1_Width = cgiGet( "GXSCHEDULER1_Width") ;
            Gxscheduler1_Height = cgiGet( "GXSCHEDULER1_Height") ;
            Gxscheduler1_Autoload = cgiGet( "GXSCHEDULER1_Autoload") ;
            Gxscheduler1_Loadeventsobjectname = cgiGet( "GXSCHEDULER1_Loadeventsobjectname") ;
            Gxscheduler1_Detailsformobjectname = cgiGet( "GXSCHEDULER1_Detailsformobjectname") ;
            Gxscheduler1_Defaultsteptime = (int)(context.localUtil.CToN( cgiGet( "GXSCHEDULER1_Defaultsteptime"), ".", ",")) ;
            Gxscheduler1_Defaultlengthtime = (int)(context.localUtil.CToN( cgiGet( "GXSCHEDULER1_Defaultlengthtime"), ".", ",")) ;
            Gxscheduler1_Hoursize = cgiGet( "GXSCHEDULER1_Hoursize") ;
            Gxscheduler1_Firsthour = cgiGet( "GXSCHEDULER1_Firsthour") ;
            Gxscheduler1_Lasthour = cgiGet( "GXSCHEDULER1_Lasthour") ;
            Gxscheduler1_Scrollhour = cgiGet( "GXSCHEDULER1_Scrollhour") ;
            Gxscheduler1_Autoresize = cgiGet( "GXSCHEDULER1_Autoresize") ;
            Gxscheduler1_Pasteventscolor = (int)(context.localUtil.CToN( cgiGet( "GXSCHEDULER1_Pasteventscolor"), ".", ",")) ;
            Gxscheduler1_Todayeventscolor = (int)(context.localUtil.CToN( cgiGet( "GXSCHEDULER1_Todayeventscolor"), ".", ",")) ;
            Gxscheduler1_Futureeventscolor = (int)(context.localUtil.CToN( cgiGet( "GXSCHEDULER1_Futureeventscolor"), ".", ",")) ;
            Gxscheduler1_Displaymonthtab = cgiGet( "GXSCHEDULER1_Displaymonthtab") ;
            Gxscheduler1_Displayweektab = cgiGet( "GXSCHEDULER1_Displayweektab") ;
            Gxscheduler1_Displaydaytab = cgiGet( "GXSCHEDULER1_Displaydaytab") ;
            Gxscheduler1_Displaynavigationbuttons = cgiGet( "GXSCHEDULER1_Displaynavigationbuttons") ;
            Gxscheduler1_Montheventsview = cgiGet( "GXSCHEDULER1_Montheventsview") ;
            Gxscheduler1_Readonly = cgiGet( "GXSCHEDULER1_Readonly") ;
            Gxscheduler1_Detailsoncreate = cgiGet( "GXSCHEDULER1_Detailsoncreate") ;
            Gxscheduler1_Detailsondblclick = cgiGet( "GXSCHEDULER1_Detailsondblclick") ;
            Gxscheduler1_Openlinknewwindow = cgiGet( "GXSCHEDULER1_Openlinknewwindow") ;
            Gxscheduler1_Visible = StringUtil.StrToBool( cgiGet( "GXSCHEDULER1_Visible")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E11272( )
      {
         /* Gxscheduler1_Eventadded Routine */
         GXt_int4 = 0 ;
         new oobtienecorrelativo(context ).execute(  AV9ClinicaCodigo,  3, out  GXt_int4) ;
         AV11CalendarioCodigo = StringUtil.Str( (decimal)(GXt_int4), 20, 0) ;
         AV10Calendario.gxTpr_Clinicacodigo = AV9ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendariocodigo = AV11CalendarioCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendarioinicio = AV5currentEvent.gxTpr_Starttime ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendariofinal = AV5currentEvent.gxTpr_Endtime ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendarioobs = AV5currentEvent.gxTpr_Notes ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.Save();
         context.CommitDataStores("wp_calendario");
      }

      protected void E12272( )
      {
         /* Gxscheduler1_Eventdeleted Routine */
         AV10Calendario.Load(AV5currentEvent.gxTpr_Id, "");
         AV10Calendario.gxTpr_Clinicacodigo = AV9ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.Delete();
         context.CommitDataStores("wp_calendario");
      }

      protected void E13272( )
      {
         /* Gxscheduler1_Eventupdated Routine */
         AV10Calendario.Load(AV5currentEvent.gxTpr_Id, "");
         AV10Calendario.gxTpr_Clinicacodigo = AV9ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendariocodigo = AV11CalendarioCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendarioinicio = AV5currentEvent.gxTpr_Starttime ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendariofinal = AV5currentEvent.gxTpr_Endtime ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.gxTpr_Calendarioobs = AV5currentEvent.gxTpr_Notes ;
         context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", false, "AV10Calendario", (Object)(AV10Calendario));
         AV10Calendario.Save();
         context.CommitDataStores("wp_calendario");
      }

      protected void GXStart( )
      {
         /* Execute user event: E14272 */
         E14272 ();
         if (returnInSub) return;
      }

      protected void E14272( )
      {
         /* Start Routine */
         GXt_SdtParametros5 = AV8Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros5) ;
         AV8Parametros = GXt_SdtParametros5 ;
         AV9ClinicaCodigo = AV8Parametros.gxTpr_Pclinicacodigo ;
      }

      protected void nextLoad( )
      {
      }

      protected void E15272( )
      {
         /* Load Routine */
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA272( ) ;
         WS272( ) ;
         WE272( ) ;
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
         AddStyleSheetFile("GXScheduler/dhtmlxscheduler.css", "?22234287");
         AddThemeStyleSheetFile("", "Fantastic.css", "?12312013");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1521553");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_calendario.js", "?1521553");
         context.AddJavascriptSource("GXScheduler/dhtmlxscheduler.js", "");
         context.AddJavascriptSource("GXScheduler/GXSchedulerRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         Gxscheduler1_Internalname = "GXSCHEDULER1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Gxscheduler1_Lasthour = "21" ;
         Gxscheduler1_Firsthour = "8" ;
         Gxscheduler1_Defaultsteptime = 30 ;
         Gxscheduler1_Detailsformobjectname = "Appointment" ;
         Gxscheduler1_Loadeventsobjectname = "LoadEventsSampleProc" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Agenda Médica" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char1 = "" ;
         GXt_char2 = "" ;
         AV5currentEvent = new SdtSchedulerEvents_event(context);
         AV6initialDate = DateTime.MinValue ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         GXt_char3 = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXKey = "" ;
         Gxscheduler1_View = "" ;
         Gxscheduler1_Width = "" ;
         Gxscheduler1_Height = "" ;
         Gxscheduler1_Autoload = "" ;
         Gxscheduler1_Hoursize = "" ;
         Gxscheduler1_Scrollhour = "" ;
         Gxscheduler1_Autoresize = "" ;
         Gxscheduler1_Displaymonthtab = "" ;
         Gxscheduler1_Displayweektab = "" ;
         Gxscheduler1_Displaydaytab = "" ;
         Gxscheduler1_Displaynavigationbuttons = "" ;
         Gxscheduler1_Montheventsview = "" ;
         Gxscheduler1_Readonly = "" ;
         Gxscheduler1_Detailsoncreate = "" ;
         Gxscheduler1_Detailsondblclick = "" ;
         Gxscheduler1_Openlinknewwindow = "" ;
         AV11CalendarioCodigo = "" ;
         AV9ClinicaCodigo = "" ;
         AV10Calendario = new SdtCalendario(context);
         AV8Parametros = new SdtParametros(context);
         GXt_SdtParametros5 = new SdtParametros(context);
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_calendario__default(),
            new Object[][] {
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short nGXWrapped ;
      private int Gxscheduler1_Defaultsteptime ;
      private int Gxscheduler1_Defaultlengthtime ;
      private int Gxscheduler1_Pasteventscolor ;
      private int Gxscheduler1_Todayeventscolor ;
      private int Gxscheduler1_Futureeventscolor ;
      private int GXt_int4 ;
      private int idxLst ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char1 ;
      private String GXt_char2 ;
      private String Gxscheduler1_Loadeventsobjectname ;
      private String Gxscheduler1_Detailsformobjectname ;
      private String Gxscheduler1_Firsthour ;
      private String Gxscheduler1_Lasthour ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String GXt_char3 ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String Gxscheduler1_View ;
      private String Gxscheduler1_Width ;
      private String Gxscheduler1_Height ;
      private String Gxscheduler1_Autoload ;
      private String Gxscheduler1_Hoursize ;
      private String Gxscheduler1_Scrollhour ;
      private String Gxscheduler1_Autoresize ;
      private String Gxscheduler1_Displaymonthtab ;
      private String Gxscheduler1_Displayweektab ;
      private String Gxscheduler1_Displaydaytab ;
      private String Gxscheduler1_Displaynavigationbuttons ;
      private String Gxscheduler1_Montheventsview ;
      private String Gxscheduler1_Readonly ;
      private String Gxscheduler1_Detailsoncreate ;
      private String Gxscheduler1_Detailsondblclick ;
      private String Gxscheduler1_Openlinknewwindow ;
      private String Gxscheduler1_Internalname ;
      private DateTime AV6initialDate ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool Gxscheduler1_Visible ;
      private bool returnInSub ;
      private String AV11CalendarioCodigo ;
      private String AV9ClinicaCodigo ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private IDataStoreProvider pr_default ;
      private GXWebForm Form ;
      private SdtCalendario AV10Calendario ;
      private SdtSchedulerEvents_event AV5currentEvent ;
      private SdtParametros AV8Parametros ;
      private SdtParametros GXt_SdtParametros5 ;
   }

   public class wp_calendario__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          def= new CursorDef[] {
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
