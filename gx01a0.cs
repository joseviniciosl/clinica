/*
               File: Gx01A0
        Description: Selection List Expediente Médico Físico
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:14.6
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
   public class gx01a0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01a0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01a0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out int aP1_pExpedienteId )
      {
         this.AV12pClinicaCodigo = "" ;
         this.AV13pExpedienteId = 0 ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV12pClinicaCodigo;
         aP1_pExpedienteId=this.AV13pExpedienteId;
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_46_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_46_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_46_idx, sGXsfl_46_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cExpedienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cExpedienteId), 9, 0)));
               AV8cExpedienteFecha = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cExpedienteFecha", context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"));
               AV9cExpedienteHora = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cExpedienteHora", AV9cExpedienteHora);
               AV10cPacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
               AV11cUsuarioCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCodigo", AV11cUsuarioCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cClinicaCodigo, AV7cExpedienteId, AV8cExpedienteFecha, AV9cExpedienteHora, AV10cPacienteId, AV11cUsuarioCodigo) ;
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
               AV12pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pExpedienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pExpedienteId), 9, 0)));
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
         PA1Q2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Q2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01a0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode("" +AV13pExpedienteId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCEXPEDIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cExpedienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCEXPEDIENTEFECHA", context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCEXPEDIENTEHORA", StringUtil.RTrim( AV9cExpedienteHora));
         GxWebStd.gx_hidden_field( context, "GXH_vCPACIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCUSUARIOCODIGO", StringUtil.RTrim( AV11cUsuarioCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV12pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPEXPEDIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pExpedienteId), 9, 0, ".", "")));
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
            WE1Q2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Q2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01A0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Expediente Médico Físico" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01a0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode("" +AV13pExpedienteId) ;
      }

      protected void WB1Q0( )
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
            wb_table1_2_1Q2( true) ;
         }
         else
         {
            wb_table1_2_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1Q2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1Q2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Expediente Médico Físico", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1Q0( ) ;
      }

      protected void WS1Q2( )
      {
         START1Q2( ) ;
         EVT1Q2( ) ;
      }

      protected void EVT1Q2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCLINICACODIGO"), AV6cClinicaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEXPEDIENTEID"), ".", ",") != Convert.ToDecimal( AV7cExpedienteId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCEXPEDIENTEFECHA"), 2) != AV8cExpedienteFecha )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCEXPEDIENTEHORA"), AV9cExpedienteHora) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPACIENTEID"), ".", ",") != Convert.ToDecimal( AV10cPacienteId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCODIGO"), AV11cUsuarioCodigo) != 0 )
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
                              nGXsfl_46_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
                              edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
                              edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
                              edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
                              edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
                              edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A167ExpedienteId = (int)(context.localUtil.CToN( cgiGet( edtExpedienteId_Internalname), ".", ",")) ;
                              A168ExpedienteFecha = context.localUtil.CToD( cgiGet( edtExpedienteFecha_Internalname), 2) ;
                              A169ExpedienteHora = cgiGet( edtExpedienteHora_Internalname) ;
                              A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                              A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111Q2 */
                                    E111Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121Q2 */
                                    E121Q2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cclinicacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCLINICACODIGO"), AV6cClinicaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cexpedienteid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCEXPEDIENTEID"), ".", ",") != Convert.ToDecimal( AV7cExpedienteId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cexpedientefecha Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCEXPEDIENTEFECHA"), 2) != AV8cExpedienteFecha )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cexpedientehora Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCEXPEDIENTEHORA"), AV9cExpedienteHora) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cpacienteid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPACIENTEID"), ".", ",") != Convert.ToDecimal( AV10cPacienteId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cusuariocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCUSUARIOCODIGO"), AV11cUsuarioCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E131Q2 */
                                          E131Q2 ();
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

      protected void WE1Q2( )
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

      protected void PA1Q2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCclinicacodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_46_idx ,
                                       String sGXsfl_46_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
         edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
            edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
            edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        String AV6cClinicaCodigo ,
                                        int AV7cExpedienteId ,
                                        DateTime AV8cExpedienteFecha ,
                                        String AV9cExpedienteHora ,
                                        int AV10cPacienteId ,
                                        String AV11cUsuarioCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF1Q2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1Q2( ) ;
         /* End function Refresh */
      }

      protected void RF1Q2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
         edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
         edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
            edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
            edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV9cExpedienteHora = StringUtil.PadR( StringUtil.RTrim( AV9cExpedienteHora), 8, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cExpedienteHora", AV9cExpedienteHora);
            lV11cUsuarioCodigo = StringUtil.PadR( StringUtil.RTrim( AV11cUsuarioCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCodigo", AV11cUsuarioCodigo);
            /* Using cursor H001Q2 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, AV7cExpedienteId, AV8cExpedienteFecha, lV9cExpedienteHora, AV10cPacienteId, lV11cUsuarioCodigo});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A4UsuarioCodigo = H001Q2_A4UsuarioCodigo[0] ;
               A67PacienteId = H001Q2_A67PacienteId[0] ;
               A169ExpedienteHora = H001Q2_A169ExpedienteHora[0] ;
               A168ExpedienteFecha = H001Q2_A168ExpedienteFecha[0] ;
               A167ExpedienteId = H001Q2_A167ExpedienteId[0] ;
               A41ClinicaCodigo = H001Q2_A41ClinicaCodigo[0] ;
               /* Execute user event: E121Q2 */
               E121Q2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 46 ;
            WB1Q0( ) ;
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
         lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
         lV9cExpedienteHora = StringUtil.PadR( StringUtil.RTrim( AV9cExpedienteHora), 8, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cExpedienteHora", AV9cExpedienteHora);
         lV11cUsuarioCodigo = StringUtil.PadR( StringUtil.RTrim( AV11cUsuarioCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCodigo", AV11cUsuarioCodigo);
         /* Using cursor H001Q3 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, AV7cExpedienteId, AV8cExpedienteFecha, lV9cExpedienteHora, AV10cPacienteId, lV11cUsuarioCodigo});
         GRID1_nRecordCount = H001Q3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1Q0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111Q2 */
         E111Q2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCexpedienteid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCexpedienteid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCEXPEDIENTEID");
               GX_FocusControl = edtavCexpedienteid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cExpedienteId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cExpedienteId), 9, 0)));
            }
            else
            {
               AV7cExpedienteId = (int)(context.localUtil.CToN( cgiGet( edtavCexpedienteid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cExpedienteId), 9, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCexpedientefecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "vCEXPEDIENTEFECHA");
               GX_FocusControl = edtavCexpedientefecha_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cExpedienteFecha = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cExpedienteFecha", context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"));
            }
            else
            {
               AV8cExpedienteFecha = context.localUtil.CToD( cgiGet( edtavCexpedientefecha_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cExpedienteFecha", context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"));
            }
            AV9cExpedienteHora = cgiGet( edtavCexpedientehora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cExpedienteHora", AV9cExpedienteHora);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpacienteid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpacienteid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCPACIENTEID");
               GX_FocusControl = edtavCpacienteid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cPacienteId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
            }
            else
            {
               AV10cPacienteId = (int)(context.localUtil.CToN( cgiGet( edtavCpacienteid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
            }
            AV11cUsuarioCodigo = cgiGet( edtavCusuariocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCodigo", AV11cUsuarioCodigo);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV13pExpedienteId = (int)(context.localUtil.CToN( cgiGet( "vPEXPEDIENTEID"), ".", ",")) ;
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
         /* Execute user event: E111Q2 */
         E111Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111Q2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Expediente Médico Físico", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E121Q2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_462( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E131Q2 */
         E131Q2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131Q2( )
      {
         /* Enter Routine */
         AV12pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pExpedienteId = A167ExpedienteId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pExpedienteId), 9, 0)));
         context.setWebReturnParms(new Object[] {(String)AV12pClinicaCodigo,(int)AV13pExpedienteId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_1Q2( bool wbgen )
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
            wb_table2_9_1Q2( true) ;
         }
         else
         {
            wb_table2_9_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_1Q2e( bool wbgen )
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
            wb_table3_43_1Q2( true) ;
         }
         else
         {
            wb_table3_43_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_1Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1Q2e( true) ;
         }
         else
         {
            wb_table1_2_1Q2e( false) ;
         }
      }

      protected void wb_table3_43_1Q2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"46\">") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Expediente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Hora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Paciente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Usuario") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A168ExpedienteFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtExpedienteFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A169ExpedienteHora));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4UsuarioCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 46 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_46_idx-1) ;
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
            wb_table4_56_1Q2( true) ;
         }
         else
         {
            wb_table4_56_1Q2( false) ;
         }
         return  ;
      }

      protected void wb_table4_56_1Q2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_1Q2e( true) ;
         }
         else
         {
            wb_table3_43_1Q2e( false) ;
         }
      }

      protected void wb_table4_56_1Q2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_56_1Q2e( true) ;
         }
         else
         {
            wb_table4_56_1Q2e( false) ;
         }
      }

      protected void wb_table2_9_1Q2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedienteid_Internalname, "Expediente", "", "", lblTextblockexpedienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cExpedienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCexpedienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cExpedienteId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cExpedienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cExpedienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCexpedienteid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedientefecha_Internalname, "Fecha", "", "", lblTextblockexpedientefecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cExpedienteFecha", context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCexpedientefecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCexpedientefecha_Internalname, context.localUtil.Format(AV8cExpedienteFecha, "99/99/99"), context.localUtil.Format( AV8cExpedienteFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCexpedientefecha_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01A0.htm");
            GxWebStd.gx_bitmap( context, edtavCexpedientefecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx01A0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockexpedientehora_Internalname, "Hora", "", "", lblTextblockexpedientehora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cExpedienteHora", AV9cExpedienteHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCexpedientehora_Internalname, StringUtil.RTrim( AV9cExpedienteHora), StringUtil.RTrim( context.localUtil.Format( AV9cExpedienteHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCexpedientehora_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPacienteId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cPacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cPacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavCpacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockusuariocodigo_Internalname, "Usuario", "", "", lblTextblockusuariocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cUsuarioCodigo", AV11cUsuarioCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCusuariocodigo_Internalname, StringUtil.RTrim( AV11cUsuarioCodigo), StringUtil.RTrim( context.localUtil.Format( AV11cUsuarioCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", "", "", "", edtavCusuariocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_1Q2e( true) ;
         }
         else
         {
            wb_table2_9_1Q2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pExpedienteId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pExpedienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pExpedienteId), 9, 0)));
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
         PA1Q2( ) ;
         WS1Q2( ) ;
         WE1Q2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1591474");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx01a0.js", "?1591474");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB1Q0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_46_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_46_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_46_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")))+"'"+"]);" ;
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)AV5LinkSelection,(String)edtavLinkselection_Link,(String)"",(String)"",(String)"Fantastic",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A167ExpedienteId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtExpedienteFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A167ExpedienteId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteFecha_Internalname,context.localUtil.Format(A168ExpedienteFecha, "99/99/99"),context.localUtil.Format( A168ExpedienteFecha, "99/99/99"),(String)"",(String)"",(String)edtExpedienteFecha_Link,(String)"",(String)"Seleccionar",(String)edtExpedienteFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtExpedienteHora_Internalname,StringUtil.RTrim( A169ExpedienteHora),StringUtil.RTrim( context.localUtil.Format( A169ExpedienteHora, "XXXXXXXX")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtExpedienteHora_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioCodigo_Internalname,StringUtil.RTrim( A4UsuarioCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtExpedienteId_Internalname = "EXPEDIENTEID_"+sGXsfl_46_idx ;
            edtExpedienteFecha_Internalname = "EXPEDIENTEFECHA_"+sGXsfl_46_idx ;
            edtExpedienteHora_Internalname = "EXPEDIENTEHORA_"+sGXsfl_46_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_46_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockexpedienteid_Internalname = "TEXTBLOCKEXPEDIENTEID" ;
         edtavCexpedienteid_Internalname = "vCEXPEDIENTEID" ;
         lblTextblockexpedientefecha_Internalname = "TEXTBLOCKEXPEDIENTEFECHA" ;
         edtavCexpedientefecha_Internalname = "vCEXPEDIENTEFECHA" ;
         lblTextblockexpedientehora_Internalname = "TEXTBLOCKEXPEDIENTEHORA" ;
         edtavCexpedientehora_Internalname = "vCEXPEDIENTEHORA" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtavCpacienteid_Internalname = "vCPACIENTEID" ;
         lblTextblockusuariocodigo_Internalname = "TEXTBLOCKUSUARIOCODIGO" ;
         edtavCusuariocodigo_Internalname = "vCUSUARIOCODIGO" ;
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
         edtUsuarioCodigo_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtExpedienteHora_Jsonclick = "" ;
         edtExpedienteFecha_Jsonclick = "" ;
         edtExpedienteId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCusuariocodigo_Jsonclick = "" ;
         edtavCpacienteid_Jsonclick = "" ;
         edtavCexpedientehora_Jsonclick = "" ;
         edtavCexpedientefecha_Jsonclick = "" ;
         edtavCexpedienteid_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtExpedienteFecha_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Expediente Médico Físico" ;
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
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV6cClinicaCodigo = "" ;
         AV8cExpedienteFecha = DateTime.MinValue ;
         AV9cExpedienteHora = "" ;
         AV11cUsuarioCodigo = "" ;
         AV12pClinicaCodigo = "" ;
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
         edtClinicaCodigo_Internalname = "" ;
         edtExpedienteId_Internalname = "" ;
         edtExpedienteFecha_Internalname = "" ;
         edtExpedienteHora_Internalname = "" ;
         edtPacienteId_Internalname = "" ;
         edtUsuarioCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A168ExpedienteFecha = DateTime.MinValue ;
         A169ExpedienteHora = "" ;
         A4UsuarioCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV9cExpedienteHora = "" ;
         lV11cUsuarioCodigo = "" ;
         H001Q2_A4UsuarioCodigo = new String[] {""} ;
         H001Q2_A67PacienteId = new int[1] ;
         H001Q2_A169ExpedienteHora = new String[] {""} ;
         H001Q2_A168ExpedienteFecha = new DateTime[] {DateTime.MinValue} ;
         H001Q2_A167ExpedienteId = new int[1] ;
         H001Q2_A41ClinicaCodigo = new String[] {""} ;
         H001Q3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockexpedienteid_Jsonclick = "" ;
         lblTextblockexpedientefecha_Jsonclick = "" ;
         GXt_char6 = "" ;
         lblTextblockexpedientehora_Jsonclick = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockusuariocodigo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01a0__default(),
            new Object[][] {
                new Object[] {
               H001Q2_A4UsuarioCodigo, H001Q2_A67PacienteId, H001Q2_A169ExpedienteHora, H001Q2_A168ExpedienteFecha, H001Q2_A167ExpedienteId, H001Q2_A41ClinicaCodigo
               }
               , new Object[] {
               H001Q3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_46_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize46 ;
      private int AV7cExpedienteId ;
      private int AV10cPacienteId ;
      private int AV13pExpedienteId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A167ExpedienteId ;
      private int A67PacienteId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_46_idx="0001" ;
      private String AV9cExpedienteHora ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtExpedienteId_Internalname ;
      private String edtExpedienteFecha_Internalname ;
      private String edtExpedienteHora_Internalname ;
      private String edtPacienteId_Internalname ;
      private String edtUsuarioCodigo_Internalname ;
      private String A169ExpedienteHora ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String lV9cExpedienteHora ;
      private String edtavCexpedienteid_Internalname ;
      private String edtavCexpedientefecha_Internalname ;
      private String edtavCexpedientehora_Internalname ;
      private String edtavCpacienteid_Internalname ;
      private String edtavCusuariocodigo_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtExpedienteFecha_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockexpedienteid_Internalname ;
      private String lblTextblockexpedienteid_Jsonclick ;
      private String edtavCexpedienteid_Jsonclick ;
      private String lblTextblockexpedientefecha_Internalname ;
      private String lblTextblockexpedientefecha_Jsonclick ;
      private String edtavCexpedientefecha_Jsonclick ;
      private String GXt_char6 ;
      private String lblTextblockexpedientehora_Internalname ;
      private String lblTextblockexpedientehora_Jsonclick ;
      private String edtavCexpedientehora_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtavCpacienteid_Jsonclick ;
      private String lblTextblockusuariocodigo_Internalname ;
      private String lblTextblockusuariocodigo_Jsonclick ;
      private String edtavCusuariocodigo_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtExpedienteId_Jsonclick ;
      private String edtExpedienteFecha_Jsonclick ;
      private String edtExpedienteHora_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String GXt_char8 ;
      private DateTime AV8cExpedienteFecha ;
      private DateTime A168ExpedienteFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV11cUsuarioCodigo ;
      private String AV12pClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A4UsuarioCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV11cUsuarioCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] H001Q2_A4UsuarioCodigo ;
      private int[] H001Q2_A67PacienteId ;
      private String[] H001Q2_A169ExpedienteHora ;
      private DateTime[] H001Q2_A168ExpedienteFecha ;
      private int[] H001Q2_A167ExpedienteId ;
      private String[] H001Q2_A41ClinicaCodigo ;
      private int[] H001Q3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private int aP1_pExpedienteId ;
      private GXWebForm Form ;
   }

   public class gx01a0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001Q2 ;
          prmH001Q2 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV9cExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV10cPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@lV11cUsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH001Q3 ;
          prmH001Q3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cExpedienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cExpedienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV9cExpedienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV10cPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@lV11cUsuarioCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Q2", "SELECT [UsuarioCodigo], [PacienteId], [ExpedienteHora], [ExpedienteFecha], [ExpedienteId], [ClinicaCodigo] FROM [Expediente] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ExpedienteId] >= @AV7cExpedienteId) AND ([ExpedienteFecha] >= @AV8cExpedienteFecha) AND ([ExpedienteHora] like @lV9cExpedienteHora) AND ([PacienteId] >= @AV10cPacienteId) AND ([UsuarioCodigo] like @lV11cUsuarioCodigo) ORDER BY [ClinicaCodigo], [ExpedienteId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q2,11,0,false,false )
             ,new CursorDef("H001Q3", "SELECT COUNT(*) FROM [Expediente] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ExpedienteId] >= @AV7cExpedienteId) AND ([ExpedienteFecha] >= @AV8cExpedienteFecha) AND ([ExpedienteHora] like @lV9cExpedienteHora) AND ([PacienteId] >= @AV10cPacienteId) AND ([UsuarioCodigo] like @lV11cUsuarioCodigo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Q3,1,0,false,false )
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((int[]) buf[1])[0] = rslt.getInt(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 8) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                break;
       }
    }

 }

}
