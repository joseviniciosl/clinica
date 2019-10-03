/*
               File: Gx01K0
        Description: Selection List Cierre mensual de contabilidad
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:31.27
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
   public class gx01k0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01k0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01k0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out short aP1_pCierreMCAnio ,
                           out short aP2_pCierreMCMes ,
                           out String aP3_pCtaContableCodigo )
      {
         this.AV12pClinicaCodigo = "" ;
         this.AV13pCierreMCAnio = 0 ;
         this.AV14pCierreMCMes = 0 ;
         this.AV15pCtaContableCodigo = "" ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV12pClinicaCodigo;
         aP1_pCierreMCAnio=this.AV13pCierreMCAnio;
         aP2_pCierreMCMes=this.AV14pCierreMCMes;
         aP3_pCtaContableCodigo=this.AV15pCtaContableCodigo;
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
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cCierreMCAnio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCierreMCAnio), 4, 0)));
               AV8cCierreMCMes = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cCierreMCMes), 4, 0)));
               AV9cCtaContableCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
               AV10cCierreMCDebe = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCierreMCDebe", StringUtil.LTrim( StringUtil.Str( AV10cCierreMCDebe, 17, 2)));
               AV11cCierreMCHaber = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCierreMCHaber", StringUtil.LTrim( StringUtil.Str( AV11cCierreMCHaber, 17, 2)));
               AV16cCierreMCInicial = NumberUtil.Val( GetNextPar( ), ".") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cCierreMCInicial", StringUtil.LTrim( StringUtil.Str( AV16cCierreMCInicial, 17, 2)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cCierreMCAnio, AV8cCierreMCMes, AV9cCtaContableCodigo, AV10cCierreMCDebe, AV11cCierreMCHaber, AV16cCierreMCInicial) ;
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
                  AV13pCierreMCAnio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCierreMCAnio), 4, 0)));
                  AV14pCierreMCMes = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCierreMCMes), 4, 0)));
                  AV15pCtaContableCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pCtaContableCodigo", AV15pCtaContableCodigo);
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
         PA222( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START222( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01k0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode("" +AV13pCierreMCAnio) + "," + UrlEncode("" +AV14pCierreMCMes) + "," + UrlEncode(StringUtil.RTrim(AV15pCtaContableCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCIERREMCANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cCierreMCAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCIERREMCMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cCierreMCMes), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLECODIGO", StringUtil.RTrim( AV9cCtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCIERREMCDEBE", StringUtil.LTrim( StringUtil.NToC( AV10cCierreMCDebe, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCIERREMCHABER", StringUtil.LTrim( StringUtil.NToC( AV11cCierreMCHaber, 17, 2, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCIERREMCINICIAL", StringUtil.LTrim( StringUtil.NToC( AV16cCierreMCInicial, 17, 2, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV12pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCIERREMCANIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pCierreMCAnio), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCIERREMCMES", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pCierreMCMes), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCTACONTABLECODIGO", StringUtil.RTrim( AV15pCtaContableCodigo));
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
            WE222( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT222( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01K0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Cierre mensual de contabilidad" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01k0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode("" +AV13pCierreMCAnio) + "," + UrlEncode("" +AV14pCierreMCMes) + "," + UrlEncode(StringUtil.RTrim(AV15pCtaContableCodigo)) ;
      }

      protected void WB220( )
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
            wb_table1_2_222( true) ;
         }
         else
         {
            wb_table1_2_222( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_222e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START222( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Cierre mensual de contabilidad", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP220( ) ;
      }

      protected void WS222( )
      {
         START222( ) ;
         EVT222( ) ;
      }

      protected void EVT222( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCANIO"), ".", ",") != Convert.ToDecimal( AV7cCierreMCAnio )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCMES"), ".", ",") != Convert.ToDecimal( AV8cCierreMCMes )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV9cCtaContableCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCDEBE"), ".", ",") != AV10cCierreMCDebe )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCHABER"), ".", ",") != AV11cCierreMCHaber )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCINICIAL"), ".", ",") != AV16cCierreMCInicial )
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
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
                              edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
                              edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
                              edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
                              edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
                              edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
                              edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A225CierreMCAnio = (short)(context.localUtil.CToN( cgiGet( edtCierreMCAnio_Internalname), ".", ",")) ;
                              A226CierreMCMes = (short)(context.localUtil.CToN( cgiGet( edtCierreMCMes_Internalname), ".", ",")) ;
                              A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
                              A227CierreMCDebe = context.localUtil.CToN( cgiGet( edtCierreMCDebe_Internalname), ".", ",") ;
                              A228CierreMCHaber = context.localUtil.CToN( cgiGet( edtCierreMCHaber_Internalname), ".", ",") ;
                              A300CierreMCInicial = context.localUtil.CToN( cgiGet( edtCierreMCInicial_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11222 */
                                    E11222 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12222 */
                                    E12222 ();
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
                                       /* Set Refresh If Ccierremcanio Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCANIO"), ".", ",") != Convert.ToDecimal( AV7cCierreMCAnio )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccierremcmes Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCMES"), ".", ",") != Convert.ToDecimal( AV8cCierreMCMes )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablecodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV9cCtaContableCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccierremcdebe Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCDEBE"), ".", ",") != AV10cCierreMCDebe )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccierremchaber Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCHABER"), ".", ",") != AV11cCierreMCHaber )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccierremcinicial Changed */
                                       if ( context.localUtil.CToN( cgiGet( "GXH_vCCIERREMCINICIAL"), ".", ",") != AV16cCierreMCInicial )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13222 */
                                          E13222 ();
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

      protected void WE222( )
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

      protected void PA222( )
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
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
         edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
         edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
         edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
         edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
            edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
            edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
            edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        short AV7cCierreMCAnio ,
                                        short AV8cCierreMCMes ,
                                        String AV9cCtaContableCodigo ,
                                        decimal AV10cCierreMCDebe ,
                                        decimal AV11cCierreMCHaber ,
                                        decimal AV16cCierreMCInicial )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF222( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF222( ) ;
         /* End function Refresh */
      }

      protected void RF222( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
         edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
         edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
         edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
         edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
            edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
            edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
            edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV9cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            /* Using cursor H00222 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, AV7cCierreMCAnio, AV8cCierreMCMes, lV9cCtaContableCodigo, AV10cCierreMCDebe, AV11cCierreMCHaber, AV16cCierreMCInicial});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A300CierreMCInicial = H00222_A300CierreMCInicial[0] ;
               A228CierreMCHaber = H00222_A228CierreMCHaber[0] ;
               A227CierreMCDebe = H00222_A227CierreMCDebe[0] ;
               A193CtaContableCodigo = H00222_A193CtaContableCodigo[0] ;
               A226CierreMCMes = H00222_A226CierreMCMes[0] ;
               A225CierreMCAnio = H00222_A225CierreMCAnio[0] ;
               A41ClinicaCodigo = H00222_A41ClinicaCodigo[0] ;
               /* Execute user event: E12222 */
               E12222 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB220( ) ;
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
         lV9cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
         /* Using cursor H00223 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, AV7cCierreMCAnio, AV8cCierreMCMes, lV9cCtaContableCodigo, AV10cCierreMCDebe, AV11cCierreMCHaber, AV16cCierreMCInicial});
         GRID1_nRecordCount = H00223_AGRID1_nRecordCount[0] ;
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

      protected void STRUP220( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11222 */
         E11222 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcierremcanio_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcierremcanio_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCIERREMCANIO");
               GX_FocusControl = edtavCcierremcanio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cCierreMCAnio = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCierreMCAnio), 4, 0)));
            }
            else
            {
               AV7cCierreMCAnio = (short)(context.localUtil.CToN( cgiGet( edtavCcierremcanio_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCierreMCAnio), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcierremcmes_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcierremcmes_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCIERREMCMES");
               GX_FocusControl = edtavCcierremcmes_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cCierreMCMes = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cCierreMCMes), 4, 0)));
            }
            else
            {
               AV8cCierreMCMes = (short)(context.localUtil.CToN( cgiGet( edtavCcierremcmes_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cCierreMCMes), 4, 0)));
            }
            AV9cCtaContableCodigo = cgiGet( edtavCctacontablecodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcierremcdebe_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcierremcdebe_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCIERREMCDEBE");
               GX_FocusControl = edtavCcierremcdebe_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cCierreMCDebe = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCierreMCDebe", StringUtil.LTrim( StringUtil.Str( AV10cCierreMCDebe, 17, 2)));
            }
            else
            {
               AV10cCierreMCDebe = context.localUtil.CToN( cgiGet( edtavCcierremcdebe_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCierreMCDebe", StringUtil.LTrim( StringUtil.Str( AV10cCierreMCDebe, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcierremchaber_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcierremchaber_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCIERREMCHABER");
               GX_FocusControl = edtavCcierremchaber_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV11cCierreMCHaber = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCierreMCHaber", StringUtil.LTrim( StringUtil.Str( AV11cCierreMCHaber, 17, 2)));
            }
            else
            {
               AV11cCierreMCHaber = context.localUtil.CToN( cgiGet( edtavCcierremchaber_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCierreMCHaber", StringUtil.LTrim( StringUtil.Str( AV11cCierreMCHaber, 17, 2)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcierremcinicial_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcierremcinicial_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCIERREMCINICIAL");
               GX_FocusControl = edtavCcierremcinicial_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV16cCierreMCInicial = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cCierreMCInicial", StringUtil.LTrim( StringUtil.Str( AV16cCierreMCInicial, 17, 2)));
            }
            else
            {
               AV16cCierreMCInicial = context.localUtil.CToN( cgiGet( edtavCcierremcinicial_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cCierreMCInicial", StringUtil.LTrim( StringUtil.Str( AV16cCierreMCInicial, 17, 2)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV13pCierreMCAnio = (short)(context.localUtil.CToN( cgiGet( "vPCIERREMCANIO"), ".", ",")) ;
            AV14pCierreMCMes = (short)(context.localUtil.CToN( cgiGet( "vPCIERREMCMES"), ".", ",")) ;
            AV15pCtaContableCodigo = cgiGet( "vPCTACONTABLECODIGO") ;
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
         /* Execute user event: E11222 */
         E11222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11222( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Cierre mensual de contabilidad", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12222( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E13222 */
         E13222 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13222( )
      {
         /* Enter Routine */
         AV12pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pCierreMCAnio = A225CierreMCAnio ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCierreMCAnio), 4, 0)));
         AV14pCierreMCMes = A226CierreMCMes ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCierreMCMes), 4, 0)));
         AV15pCtaContableCodigo = A193CtaContableCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pCtaContableCodigo", AV15pCtaContableCodigo);
         context.setWebReturnParms(new Object[] {(String)AV12pClinicaCodigo,(short)AV13pCierreMCAnio,(short)AV14pCierreMCMes,(String)AV15pCtaContableCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_222( bool wbgen )
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
            wb_table2_9_222( true) ;
         }
         else
         {
            wb_table2_9_222( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_222e( bool wbgen )
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
            wb_table3_48_222( true) ;
         }
         else
         {
            wb_table3_48_222( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_222e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_222e( true) ;
         }
         else
         {
            wb_table1_2_222e( false) ;
         }
      }

      protected void wb_table3_48_222( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"51\">") ;
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
               context.SendWebValue( "Año") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Mes") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cta_Contable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Debe") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Haber") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Inicial") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A225CierreMCAnio), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A226CierreMCMes), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A227CierreMCDebe, 17, 2, ".", "")));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtCierreMCDebe_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A228CierreMCHaber, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A300CierreMCInicial, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
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
            wb_table4_62_222( true) ;
         }
         else
         {
            wb_table4_62_222( false) ;
         }
         return  ;
      }

      protected void wb_table4_62_222e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_222e( true) ;
         }
         else
         {
            wb_table3_48_222e( false) ;
         }
      }

      protected void wb_table4_62_222( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_62_222e( true) ;
         }
         else
         {
            wb_table4_62_222e( false) ;
         }
      }

      protected void wb_table2_9_222( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcanio_Internalname, "Año", "", "", lblTextblockcierremcanio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cCierreMCAnio), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcierremcanio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cCierreMCAnio), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cCierreMCAnio), "ZZZ9")) : context.localUtil.Format( (decimal)(AV7cCierreMCAnio), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCcierremcanio_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcmes_Internalname, "Mes", "", "", lblTextblockcierremcmes_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cCierreMCMes), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcierremcmes_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cCierreMCMes), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cCierreMCMes), "ZZZ9")) : context.localUtil.Format( (decimal)(AV8cCierreMCMes), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCcierremcmes_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableCodigo", AV9cCtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCctacontablecodigo_Internalname, StringUtil.RTrim( AV9cCtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( AV9cCtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCctacontablecodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcdebe_Internalname, "Debe", "", "", lblTextblockcierremcdebe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCierreMCDebe", StringUtil.LTrim( StringUtil.Str( AV10cCierreMCDebe, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcierremcdebe_Internalname, StringUtil.LTrim( StringUtil.NToC( AV10cCierreMCDebe, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV10cCierreMCDebe, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV10cCierreMCDebe, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavCcierremcdebe_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremchaber_Internalname, "Haber", "", "", lblTextblockcierremchaber_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCierreMCHaber", StringUtil.LTrim( StringUtil.Str( AV11cCierreMCHaber, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcierremchaber_Internalname, StringUtil.LTrim( StringUtil.NToC( AV11cCierreMCHaber, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV11cCierreMCHaber, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV11cCierreMCHaber, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(39);\"", "", "", "", "", edtavCcierremchaber_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcierremcinicial_Internalname, "Saldo_Inicial", "", "", lblTextblockcierremcinicial_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cCierreMCInicial", StringUtil.LTrim( StringUtil.Str( AV16cCierreMCInicial, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcierremcinicial_Internalname, StringUtil.LTrim( StringUtil.NToC( AV16cCierreMCInicial, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV16cCierreMCInicial, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV16cCierreMCInicial, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(44);\"", "", "", "", "", edtavCcierremcinicial_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01K0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_222e( true) ;
         }
         else
         {
            wb_table2_9_222e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pCierreMCAnio = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCierreMCAnio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCierreMCAnio), 4, 0)));
         AV14pCierreMCMes = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCierreMCMes", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pCierreMCMes), 4, 0)));
         AV15pCtaContableCodigo = (String)getParm(obj,3) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pCtaContableCodigo", AV15pCtaContableCodigo);
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
         PA222( ) ;
         WS222( ) ;
         WE222( ) ;
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
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?159324");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx01k0.js", "?159324");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB220( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_51_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A225CierreMCAnio), 4, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A226CierreMCMes), 4, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A193CtaContableCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCierreMCAnio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A225CierreMCAnio), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A225CierreMCAnio), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCierreMCAnio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCierreMCMes_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A226CierreMCMes), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A226CierreMCMes), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCierreMCMes_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableCodigo_Internalname,StringUtil.RTrim( A193CtaContableCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtCierreMCDebe_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A225CierreMCAnio), 4, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A226CierreMCMes), 4, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A193CtaContableCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCierreMCDebe_Internalname,StringUtil.LTrim( StringUtil.NToC( A227CierreMCDebe, 17, 2, ".", "")),context.localUtil.Format( A227CierreMCDebe, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)edtCierreMCDebe_Link,(String)"",(String)"Seleccionar",(String)edtCierreMCDebe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCierreMCHaber_Internalname,StringUtil.LTrim( StringUtil.NToC( A228CierreMCHaber, 17, 2, ".", "")),context.localUtil.Format( A228CierreMCHaber, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCierreMCHaber_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCierreMCInicial_Internalname,StringUtil.LTrim( StringUtil.NToC( A300CierreMCInicial, 17, 2, ".", "")),context.localUtil.Format( A300CierreMCInicial, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCierreMCInicial_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCierreMCAnio_Internalname = "CIERREMCANIO_"+sGXsfl_51_idx ;
            edtCierreMCMes_Internalname = "CIERREMCMES_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtCierreMCDebe_Internalname = "CIERREMCDEBE_"+sGXsfl_51_idx ;
            edtCierreMCHaber_Internalname = "CIERREMCHABER_"+sGXsfl_51_idx ;
            edtCierreMCInicial_Internalname = "CIERREMCINICIAL_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockcierremcanio_Internalname = "TEXTBLOCKCIERREMCANIO" ;
         edtavCcierremcanio_Internalname = "vCCIERREMCANIO" ;
         lblTextblockcierremcmes_Internalname = "TEXTBLOCKCIERREMCMES" ;
         edtavCcierremcmes_Internalname = "vCCIERREMCMES" ;
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtavCctacontablecodigo_Internalname = "vCCTACONTABLECODIGO" ;
         lblTextblockcierremcdebe_Internalname = "TEXTBLOCKCIERREMCDEBE" ;
         edtavCcierremcdebe_Internalname = "vCCIERREMCDEBE" ;
         lblTextblockcierremchaber_Internalname = "TEXTBLOCKCIERREMCHABER" ;
         edtavCcierremchaber_Internalname = "vCCIERREMCHABER" ;
         lblTextblockcierremcinicial_Internalname = "TEXTBLOCKCIERREMCINICIAL" ;
         edtavCcierremcinicial_Internalname = "vCCIERREMCINICIAL" ;
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
         edtCierreMCInicial_Jsonclick = "" ;
         edtCierreMCHaber_Jsonclick = "" ;
         edtCierreMCDebe_Jsonclick = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtCierreMCMes_Jsonclick = "" ;
         edtCierreMCAnio_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCcierremcinicial_Jsonclick = "" ;
         edtavCcierremchaber_Jsonclick = "" ;
         edtavCcierremcdebe_Jsonclick = "" ;
         edtavCctacontablecodigo_Jsonclick = "" ;
         edtavCcierremcmes_Jsonclick = "" ;
         edtavCcierremcanio_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtCierreMCDebe_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Cierre mensual de contabilidad" ;
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
         AV9cCtaContableCodigo = "" ;
         AV12pClinicaCodigo = "" ;
         AV15pCtaContableCodigo = "" ;
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
         edtCierreMCAnio_Internalname = "" ;
         edtCierreMCMes_Internalname = "" ;
         edtCtaContableCodigo_Internalname = "" ;
         edtCierreMCDebe_Internalname = "" ;
         edtCierreMCHaber_Internalname = "" ;
         edtCierreMCInicial_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A193CtaContableCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV9cCtaContableCodigo = "" ;
         H00222_A300CierreMCInicial = new decimal[1] ;
         H00222_A228CierreMCHaber = new decimal[1] ;
         H00222_A227CierreMCDebe = new decimal[1] ;
         H00222_A193CtaContableCodigo = new String[] {""} ;
         H00222_A226CierreMCMes = new short[1] ;
         H00222_A225CierreMCAnio = new short[1] ;
         H00222_A41ClinicaCodigo = new String[] {""} ;
         H00223_AGRID1_nRecordCount = new int[1] ;
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
         Grid1Column = new GXWebColumn();
         GXt_char7 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockcierremcanio_Jsonclick = "" ;
         lblTextblockcierremcmes_Jsonclick = "" ;
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         lblTextblockcierremcdebe_Jsonclick = "" ;
         lblTextblockcierremchaber_Jsonclick = "" ;
         lblTextblockcierremcinicial_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01k0__default(),
            new Object[][] {
                new Object[] {
               H00222_A300CierreMCInicial, H00222_A228CierreMCHaber, H00222_A227CierreMCDebe, H00222_A193CtaContableCodigo, H00222_A226CierreMCMes, H00222_A225CierreMCAnio, H00222_A41ClinicaCodigo
               }
               , new Object[] {
               H00223_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV7cCierreMCAnio ;
      private short AV8cCierreMCMes ;
      private short AV13pCierreMCAnio ;
      private short AV14pCierreMCMes ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A225CierreMCAnio ;
      private short A226CierreMCMes ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal AV10cCierreMCDebe ;
      private decimal AV11cCierreMCHaber ;
      private decimal AV16cCierreMCInicial ;
      private decimal A227CierreMCDebe ;
      private decimal A228CierreMCHaber ;
      private decimal A300CierreMCInicial ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
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
      private String edtCierreMCAnio_Internalname ;
      private String edtCierreMCMes_Internalname ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtCierreMCDebe_Internalname ;
      private String edtCierreMCHaber_Internalname ;
      private String edtCierreMCInicial_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCcierremcanio_Internalname ;
      private String edtavCcierremcmes_Internalname ;
      private String edtavCctacontablecodigo_Internalname ;
      private String edtavCcierremcdebe_Internalname ;
      private String edtavCcierremchaber_Internalname ;
      private String edtavCcierremcinicial_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtCierreMCDebe_Link ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockcierremcanio_Internalname ;
      private String lblTextblockcierremcanio_Jsonclick ;
      private String edtavCcierremcanio_Jsonclick ;
      private String lblTextblockcierremcmes_Internalname ;
      private String lblTextblockcierremcmes_Jsonclick ;
      private String edtavCcierremcmes_Jsonclick ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtavCctacontablecodigo_Jsonclick ;
      private String lblTextblockcierremcdebe_Internalname ;
      private String lblTextblockcierremcdebe_Jsonclick ;
      private String edtavCcierremcdebe_Jsonclick ;
      private String lblTextblockcierremchaber_Internalname ;
      private String lblTextblockcierremchaber_Jsonclick ;
      private String edtavCcierremchaber_Jsonclick ;
      private String lblTextblockcierremcinicial_Internalname ;
      private String lblTextblockcierremcinicial_Jsonclick ;
      private String edtavCcierremcinicial_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtCierreMCAnio_Jsonclick ;
      private String edtCierreMCMes_Jsonclick ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtCierreMCDebe_Jsonclick ;
      private String edtCierreMCHaber_Jsonclick ;
      private String edtCierreMCInicial_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV9cCtaContableCodigo ;
      private String AV12pClinicaCodigo ;
      private String AV15pCtaContableCodigo ;
      private String A41ClinicaCodigo ;
      private String A193CtaContableCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV9cCtaContableCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] H00222_A300CierreMCInicial ;
      private decimal[] H00222_A228CierreMCHaber ;
      private decimal[] H00222_A227CierreMCDebe ;
      private String[] H00222_A193CtaContableCodigo ;
      private short[] H00222_A226CierreMCMes ;
      private short[] H00222_A225CierreMCAnio ;
      private String[] H00222_A41ClinicaCodigo ;
      private int[] H00223_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private short aP1_pCierreMCAnio ;
      private short aP2_pCierreMCMes ;
      private String aP3_pCtaContableCodigo ;
      private GXWebForm Form ;
   }

   public class gx01k0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00222 ;
          prmH00222 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cCierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cCierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV9cCtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10cCierreMCDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV11cCierreMCHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV16cCierreMCInicial",SqlDbType.Decimal,17,2}
          } ;
          Object[] prmH00223 ;
          prmH00223 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cCierreMCAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8cCierreMCMes",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV9cCtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10cCierreMCDebe",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV11cCierreMCHaber",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV16cCierreMCInicial",SqlDbType.Decimal,17,2}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00222", "SELECT [CierreMCInicial], [CierreMCHaber], [CierreMCDebe], [CtaContableCodigo], [CierreMCMes], [CierreMCAnio], [ClinicaCodigo] FROM [CierreMensualC] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([CierreMCAnio] >= @AV7cCierreMCAnio) AND ([CierreMCMes] >= @AV8cCierreMCMes) AND ([CtaContableCodigo] like @lV9cCtaContableCodigo) AND ([CierreMCDebe] >= @AV10cCierreMCDebe) AND ([CierreMCHaber] >= @AV11cCierreMCHaber) AND ([CierreMCInicial] >= @AV16cCierreMCInicial) ORDER BY [ClinicaCodigo], [CierreMCAnio], [CierreMCMes], [CtaContableCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00222,11,0,false,false )
             ,new CursorDef("H00223", "SELECT COUNT(*) FROM [CierreMensualC] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([CierreMCAnio] >= @AV7cCierreMCAnio) AND ([CierreMCMes] >= @AV8cCierreMCMes) AND ([CtaContableCodigo] like @lV9cCtaContableCodigo) AND ([CierreMCDebe] >= @AV10cCierreMCDebe) AND ([CierreMCHaber] >= @AV11cCierreMCHaber) AND ([CierreMCInicial] >= @AV16cCierreMCInicial) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00223,1,0,false,false )
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
                ((decimal[]) buf[0])[0] = rslt.getDecimal(1) ;
                ((decimal[]) buf[1])[0] = rslt.getDecimal(2) ;
                ((decimal[]) buf[2])[0] = rslt.getDecimal(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (decimal)parms[4]);
                stmt.SetParameter(6, (decimal)parms[5]);
                stmt.SetParameter(7, (decimal)parms[6]);
                break;
       }
    }

 }

}
