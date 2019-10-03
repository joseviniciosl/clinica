/*
               File: Gx01J0
        Description: Selection List Movimiento mayorizado de partidas contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:29.27
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
   public class gx01j0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01j0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01j0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pTipoParCodigo ,
                           out int aP2_pMovMayorizadoId ,
                           out short aP3_pMovMayorizadoLinea )
      {
         this.AV13pClinicaCodigo = "" ;
         this.AV14pTipoParCodigo = "" ;
         this.AV15pMovMayorizadoId = 0 ;
         this.AV16pMovMayorizadoLinea = 0 ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV13pClinicaCodigo;
         aP1_pTipoParCodigo=this.AV14pTipoParCodigo;
         aP2_pMovMayorizadoId=this.AV15pMovMayorizadoId;
         aP3_pMovMayorizadoLinea=this.AV16pMovMayorizadoLinea;
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
               AV7cTipoParCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
               AV8cMovMayorizadoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovMayorizadoId), 9, 0)));
               AV9cMovMayorizadoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovMayorizadoLinea), 4, 0)));
               AV10cMovMayorizadoFecha = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cMovMayorizadoFecha", context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"));
               AV11cMovMayorizadoHora = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovMayorizadoHora", AV11cMovMayorizadoHora);
               AV12cMovMayorizadoReferencia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovMayorizadoReferencia", AV12cMovMayorizadoReferencia);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cTipoParCodigo, AV8cMovMayorizadoId, AV9cMovMayorizadoLinea, AV10cMovMayorizadoFecha, AV11cMovMayorizadoHora, AV12cMovMayorizadoReferencia) ;
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
               AV13pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV14pTipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoParCodigo", AV14pTipoParCodigo);
                  AV15pMovMayorizadoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovMayorizadoId), 9, 0)));
                  AV16pMovMayorizadoLinea = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMovMayorizadoLinea), 4, 0)));
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
         PA212( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START212( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01j0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pTipoParCodigo)) + "," + UrlEncode("" +AV15pMovMayorizadoId) + "," + UrlEncode("" +AV16pMovMayorizadoLinea)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARCODIGO", StringUtil.RTrim( AV7cTipoParCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVMAYORIZADOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cMovMayorizadoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVMAYORIZADOLINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cMovMayorizadoLinea), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVMAYORIZADOFECHA", context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVMAYORIZADOHORA", StringUtil.RTrim( AV11cMovMayorizadoHora));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVMAYORIZADOREFERENCIA", StringUtil.RTrim( AV12cMovMayorizadoReferencia));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV13pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOPARCODIGO", StringUtil.RTrim( AV14pTipoParCodigo));
         GxWebStd.gx_hidden_field( context, "vPMOVMAYORIZADOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15pMovMayorizadoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPMOVMAYORIZADOLINEA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16pMovMayorizadoLinea), 4, 0, ".", "")));
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
            WE212( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT212( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01J0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Movimiento mayorizado de partidas contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01j0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pTipoParCodigo)) + "," + UrlEncode("" +AV15pMovMayorizadoId) + "," + UrlEncode("" +AV16pMovMayorizadoLinea) ;
      }

      protected void WB210( )
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
            wb_table1_2_212( true) ;
         }
         else
         {
            wb_table1_2_212( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_212e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START212( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Movimiento mayorizado de partidas contables", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP210( ) ;
      }

      protected void WS212( )
      {
         START212( ) ;
         EVT212( ) ;
      }

      protected void EVT212( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOPARCODIGO"), AV7cTipoParCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVMAYORIZADOID"), ".", ",") != Convert.ToDecimal( AV8cMovMayorizadoId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVMAYORIZADOLINEA"), ".", ",") != Convert.ToDecimal( AV9cMovMayorizadoLinea )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCMOVMAYORIZADOFECHA"), 2) != AV10cMovMayorizadoFecha )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVMAYORIZADOHORA"), AV11cMovMayorizadoHora) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVMAYORIZADOREFERENCIA"), AV12cMovMayorizadoReferencia) != 0 )
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
                              edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
                              edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
                              edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
                              edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
                              edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
                              edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
                              edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
                              edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
                              A217MovMayorizadoId = (int)(context.localUtil.CToN( cgiGet( edtMovMayorizadoId_Internalname), ".", ",")) ;
                              A218MovMayorizadoLinea = (short)(context.localUtil.CToN( cgiGet( edtMovMayorizadoLinea_Internalname), ".", ",")) ;
                              A219MovMayorizadoFecha = context.localUtil.CToD( cgiGet( edtMovMayorizadoFecha_Internalname), 2) ;
                              A220MovMayorizadoHora = cgiGet( edtMovMayorizadoHora_Internalname) ;
                              A222MovMayorizadoReferencia = cgiGet( edtMovMayorizadoReferencia_Internalname) ;
                              A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
                              A223MovMayorizadoDebe = context.localUtil.CToN( cgiGet( edtMovMayorizadoDebe_Internalname), ".", ",") ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11212 */
                                    E11212 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12212 */
                                    E12212 ();
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
                                       /* Set Refresh If Ctipoparcodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOPARCODIGO"), AV7cTipoParCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovmayorizadoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVMAYORIZADOID"), ".", ",") != Convert.ToDecimal( AV8cMovMayorizadoId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovmayorizadolinea Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVMAYORIZADOLINEA"), ".", ",") != Convert.ToDecimal( AV9cMovMayorizadoLinea )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovmayorizadofecha Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCMOVMAYORIZADOFECHA"), 2) != AV10cMovMayorizadoFecha )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovmayorizadohora Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVMAYORIZADOHORA"), AV11cMovMayorizadoHora) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovmayorizadoreferencia Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVMAYORIZADOREFERENCIA"), AV12cMovMayorizadoReferencia) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13212 */
                                          E13212 ();
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

      protected void WE212( )
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

      protected void PA212( )
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
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
         edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
         edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
         edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
         edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
         edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
         edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
            edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
            edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
            edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
            edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cTipoParCodigo ,
                                        int AV8cMovMayorizadoId ,
                                        short AV9cMovMayorizadoLinea ,
                                        DateTime AV10cMovMayorizadoFecha ,
                                        String AV11cMovMayorizadoHora ,
                                        String AV12cMovMayorizadoReferencia )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF212( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF212( ) ;
         /* End function Refresh */
      }

      protected void RF212( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
         edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
         edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
         edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
         edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
         edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
         edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
            edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
            edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
            edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
            edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cTipoParCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cTipoParCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
            lV11cMovMayorizadoHora = StringUtil.PadR( StringUtil.RTrim( AV11cMovMayorizadoHora), 8, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovMayorizadoHora", AV11cMovMayorizadoHora);
            lV12cMovMayorizadoReferencia = StringUtil.PadR( StringUtil.RTrim( AV12cMovMayorizadoReferencia), 40, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovMayorizadoReferencia", AV12cMovMayorizadoReferencia);
            /* Using cursor H00212 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cTipoParCodigo, AV8cMovMayorizadoId, AV9cMovMayorizadoLinea, AV10cMovMayorizadoFecha, lV11cMovMayorizadoHora, lV12cMovMayorizadoReferencia});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A223MovMayorizadoDebe = H00212_A223MovMayorizadoDebe[0] ;
               A193CtaContableCodigo = H00212_A193CtaContableCodigo[0] ;
               A222MovMayorizadoReferencia = H00212_A222MovMayorizadoReferencia[0] ;
               A220MovMayorizadoHora = H00212_A220MovMayorizadoHora[0] ;
               A219MovMayorizadoFecha = H00212_A219MovMayorizadoFecha[0] ;
               A218MovMayorizadoLinea = H00212_A218MovMayorizadoLinea[0] ;
               A217MovMayorizadoId = H00212_A217MovMayorizadoId[0] ;
               A199TipoParCodigo = H00212_A199TipoParCodigo[0] ;
               A41ClinicaCodigo = H00212_A41ClinicaCodigo[0] ;
               /* Execute user event: E12212 */
               E12212 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB210( ) ;
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
         lV7cTipoParCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cTipoParCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
         lV11cMovMayorizadoHora = StringUtil.PadR( StringUtil.RTrim( AV11cMovMayorizadoHora), 8, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovMayorizadoHora", AV11cMovMayorizadoHora);
         lV12cMovMayorizadoReferencia = StringUtil.PadR( StringUtil.RTrim( AV12cMovMayorizadoReferencia), 40, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovMayorizadoReferencia", AV12cMovMayorizadoReferencia);
         /* Using cursor H00213 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cTipoParCodigo, AV8cMovMayorizadoId, AV9cMovMayorizadoLinea, AV10cMovMayorizadoFecha, lV11cMovMayorizadoHora, lV12cMovMayorizadoReferencia});
         GRID1_nRecordCount = H00213_AGRID1_nRecordCount[0] ;
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

      protected void STRUP210( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11212 */
         E11212 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV7cTipoParCodigo = cgiGet( edtavCtipoparcodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmovmayorizadoid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmovmayorizadoid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMOVMAYORIZADOID");
               GX_FocusControl = edtavCmovmayorizadoid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cMovMayorizadoId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovMayorizadoId), 9, 0)));
            }
            else
            {
               AV8cMovMayorizadoId = (int)(context.localUtil.CToN( cgiGet( edtavCmovmayorizadoid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovMayorizadoId), 9, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmovmayorizadolinea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmovmayorizadolinea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMOVMAYORIZADOLINEA");
               GX_FocusControl = edtavCmovmayorizadolinea_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cMovMayorizadoLinea = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovMayorizadoLinea), 4, 0)));
            }
            else
            {
               AV9cMovMayorizadoLinea = (short)(context.localUtil.CToN( cgiGet( edtavCmovmayorizadolinea_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovMayorizadoLinea), 4, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCmovmayorizadofecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "vCMOVMAYORIZADOFECHA");
               GX_FocusControl = edtavCmovmayorizadofecha_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cMovMayorizadoFecha = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cMovMayorizadoFecha", context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"));
            }
            else
            {
               AV10cMovMayorizadoFecha = context.localUtil.CToD( cgiGet( edtavCmovmayorizadofecha_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cMovMayorizadoFecha", context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"));
            }
            AV11cMovMayorizadoHora = cgiGet( edtavCmovmayorizadohora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovMayorizadoHora", AV11cMovMayorizadoHora);
            AV12cMovMayorizadoReferencia = cgiGet( edtavCmovmayorizadoreferencia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovMayorizadoReferencia", AV12cMovMayorizadoReferencia);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV14pTipoParCodigo = cgiGet( "vPTIPOPARCODIGO") ;
            AV15pMovMayorizadoId = (int)(context.localUtil.CToN( cgiGet( "vPMOVMAYORIZADOID"), ".", ",")) ;
            AV16pMovMayorizadoLinea = (short)(context.localUtil.CToN( cgiGet( "vPMOVMAYORIZADOLINEA"), ".", ",")) ;
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
         /* Execute user event: E11212 */
         E11212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11212( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Movimiento mayorizado de partidas contables", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12212( )
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
         /* Execute user event: E13212 */
         E13212 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13212( )
      {
         /* Enter Routine */
         AV13pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pTipoParCodigo = A199TipoParCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoParCodigo", AV14pTipoParCodigo);
         AV15pMovMayorizadoId = A217MovMayorizadoId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovMayorizadoId), 9, 0)));
         AV16pMovMayorizadoLinea = A218MovMayorizadoLinea ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMovMayorizadoLinea), 4, 0)));
         context.setWebReturnParms(new Object[] {(String)AV13pClinicaCodigo,(String)AV14pTipoParCodigo,(int)AV15pMovMayorizadoId,(short)AV16pMovMayorizadoLinea});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_212( bool wbgen )
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
            wb_table2_9_212( true) ;
         }
         else
         {
            wb_table2_9_212( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_212e( bool wbgen )
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
            wb_table3_48_212( true) ;
         }
         else
         {
            wb_table3_48_212( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_212e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_212e( true) ;
         }
         else
         {
            wb_table1_2_212e( false) ;
         }
      }

      protected void wb_table3_48_212( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Hora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Referencia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Cta_Contable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Debe") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A199TipoParCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A217MovMayorizadoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A218MovMayorizadoLinea), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtMovMayorizadoFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A220MovMayorizadoHora));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A222MovMayorizadoReferencia));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A223MovMayorizadoDebe, 17, 2, ".", "")));
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
            wb_table4_64_212( true) ;
         }
         else
         {
            wb_table4_64_212( false) ;
         }
         return  ;
      }

      protected void wb_table4_64_212e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_212e( true) ;
         }
         else
         {
            wb_table3_48_212e( false) ;
         }
      }

      protected void wb_table4_64_212( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_64_212e( true) ;
         }
         else
         {
            wb_table4_64_212e( false) ;
         }
      }

      protected void wb_table2_9_212( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Tipo_Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipoparcodigo_Internalname, StringUtil.RTrim( AV7cTipoParCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cTipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCtipoparcodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadoid_Internalname, "Partida", "", "", lblTextblockmovmayorizadoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovMayorizadoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovmayorizadoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cMovMayorizadoId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cMovMayorizadoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cMovMayorizadoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCmovmayorizadoid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadolinea_Internalname, "Línea", "", "", lblTextblockmovmayorizadolinea_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cMovMayorizadoLinea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovmayorizadolinea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cMovMayorizadoLinea), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV9cMovMayorizadoLinea), "ZZZ9")) : context.localUtil.Format( (decimal)(AV9cMovMayorizadoLinea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCmovmayorizadolinea_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadofecha_Internalname, "Fecha", "", "", lblTextblockmovmayorizadofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cMovMayorizadoFecha", context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCmovmayorizadofecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCmovmayorizadofecha_Internalname, context.localUtil.Format(AV10cMovMayorizadoFecha, "99/99/99"), context.localUtil.Format( AV10cMovMayorizadoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(34);\"", "", "", "", "", edtavCmovmayorizadofecha_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01J0.htm");
            GxWebStd.gx_bitmap( context, edtavCmovmayorizadofecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx01J0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadohora_Internalname, "Hora", "", "", lblTextblockmovmayorizadohora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovMayorizadoHora", AV11cMovMayorizadoHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovmayorizadohora_Internalname, StringUtil.RTrim( AV11cMovMayorizadoHora), StringUtil.RTrim( context.localUtil.Format( AV11cMovMayorizadoHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", "", "", "", edtavCmovmayorizadohora_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovmayorizadoreferencia_Internalname, "Referencia", "", "", lblTextblockmovmayorizadoreferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovMayorizadoReferencia", AV12cMovMayorizadoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovmayorizadoreferencia_Internalname, StringUtil.RTrim( AV12cMovMayorizadoReferencia), StringUtil.RTrim( context.localUtil.Format( AV12cMovMayorizadoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", "", "", "", "", edtavCmovmayorizadoreferencia_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01J0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_212e( true) ;
         }
         else
         {
            wb_table2_9_212e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pTipoParCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoParCodigo", AV14pTipoParCodigo);
         AV15pMovMayorizadoId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovMayorizadoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovMayorizadoId), 9, 0)));
         AV16pMovMayorizadoLinea = Convert.ToInt16(getParm(obj,3)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16pMovMayorizadoLinea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16pMovMayorizadoLinea), 4, 0)));
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
         PA212( ) ;
         WS212( ) ;
         WE212( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1593011");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("gx01j0.js", "?1593011");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB210( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TipoParCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A217MovMayorizadoId), 9, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A218MovMayorizadoLinea), 4, 0, ".", "")))+"'"+"]);" ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParCodigo_Internalname,StringUtil.RTrim( A199TipoParCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A217MovMayorizadoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A217MovMayorizadoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovMayorizadoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoLinea_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A218MovMayorizadoLinea), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A218MovMayorizadoLinea), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovMayorizadoLinea_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtMovMayorizadoFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TipoParCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A217MovMayorizadoId), 9, 0, ".", "")))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A218MovMayorizadoLinea), 4, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoFecha_Internalname,context.localUtil.Format(A219MovMayorizadoFecha, "99/99/99"),context.localUtil.Format( A219MovMayorizadoFecha, "99/99/99"),(String)"",(String)"",(String)edtMovMayorizadoFecha_Link,(String)"",(String)"Seleccionar",(String)edtMovMayorizadoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoHora_Internalname,StringUtil.RTrim( A220MovMayorizadoHora),StringUtil.RTrim( context.localUtil.Format( A220MovMayorizadoHora, "XXXXXXXX")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovMayorizadoHora_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoReferencia_Internalname,StringUtil.RTrim( A222MovMayorizadoReferencia),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovMayorizadoReferencia_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovMayorizadoDebe_Internalname,StringUtil.LTrim( StringUtil.NToC( A223MovMayorizadoDebe, 17, 2, ".", "")),context.localUtil.Format( A223MovMayorizadoDebe, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovMayorizadoDebe_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoId_Internalname = "MOVMAYORIZADOID_"+sGXsfl_51_idx ;
            edtMovMayorizadoLinea_Internalname = "MOVMAYORIZADOLINEA_"+sGXsfl_51_idx ;
            edtMovMayorizadoFecha_Internalname = "MOVMAYORIZADOFECHA_"+sGXsfl_51_idx ;
            edtMovMayorizadoHora_Internalname = "MOVMAYORIZADOHORA_"+sGXsfl_51_idx ;
            edtMovMayorizadoReferencia_Internalname = "MOVMAYORIZADOREFERENCIA_"+sGXsfl_51_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_51_idx ;
            edtMovMayorizadoDebe_Internalname = "MOVMAYORIZADODEBE_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblocktipoparcodigo_Internalname = "TEXTBLOCKTIPOPARCODIGO" ;
         edtavCtipoparcodigo_Internalname = "vCTIPOPARCODIGO" ;
         lblTextblockmovmayorizadoid_Internalname = "TEXTBLOCKMOVMAYORIZADOID" ;
         edtavCmovmayorizadoid_Internalname = "vCMOVMAYORIZADOID" ;
         lblTextblockmovmayorizadolinea_Internalname = "TEXTBLOCKMOVMAYORIZADOLINEA" ;
         edtavCmovmayorizadolinea_Internalname = "vCMOVMAYORIZADOLINEA" ;
         lblTextblockmovmayorizadofecha_Internalname = "TEXTBLOCKMOVMAYORIZADOFECHA" ;
         edtavCmovmayorizadofecha_Internalname = "vCMOVMAYORIZADOFECHA" ;
         lblTextblockmovmayorizadohora_Internalname = "TEXTBLOCKMOVMAYORIZADOHORA" ;
         edtavCmovmayorizadohora_Internalname = "vCMOVMAYORIZADOHORA" ;
         lblTextblockmovmayorizadoreferencia_Internalname = "TEXTBLOCKMOVMAYORIZADOREFERENCIA" ;
         edtavCmovmayorizadoreferencia_Internalname = "vCMOVMAYORIZADOREFERENCIA" ;
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
         edtMovMayorizadoDebe_Jsonclick = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         edtMovMayorizadoReferencia_Jsonclick = "" ;
         edtMovMayorizadoHora_Jsonclick = "" ;
         edtMovMayorizadoFecha_Jsonclick = "" ;
         edtMovMayorizadoLinea_Jsonclick = "" ;
         edtMovMayorizadoId_Jsonclick = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCmovmayorizadoreferencia_Jsonclick = "" ;
         edtavCmovmayorizadohora_Jsonclick = "" ;
         edtavCmovmayorizadofecha_Jsonclick = "" ;
         edtavCmovmayorizadolinea_Jsonclick = "" ;
         edtavCmovmayorizadoid_Jsonclick = "" ;
         edtavCtipoparcodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtMovMayorizadoFecha_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Movimiento mayorizado de partidas contables" ;
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
         AV7cTipoParCodigo = "" ;
         AV10cMovMayorizadoFecha = DateTime.MinValue ;
         AV11cMovMayorizadoHora = "" ;
         AV12cMovMayorizadoReferencia = "" ;
         AV13pClinicaCodigo = "" ;
         AV14pTipoParCodigo = "" ;
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
         edtTipoParCodigo_Internalname = "" ;
         edtMovMayorizadoId_Internalname = "" ;
         edtMovMayorizadoLinea_Internalname = "" ;
         edtMovMayorizadoFecha_Internalname = "" ;
         edtMovMayorizadoHora_Internalname = "" ;
         edtMovMayorizadoReferencia_Internalname = "" ;
         edtCtaContableCodigo_Internalname = "" ;
         edtMovMayorizadoDebe_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A199TipoParCodigo = "" ;
         A219MovMayorizadoFecha = DateTime.MinValue ;
         A220MovMayorizadoHora = "" ;
         A222MovMayorizadoReferencia = "" ;
         A193CtaContableCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cTipoParCodigo = "" ;
         lV11cMovMayorizadoHora = "" ;
         lV12cMovMayorizadoReferencia = "" ;
         H00212_A223MovMayorizadoDebe = new decimal[1] ;
         H00212_A193CtaContableCodigo = new String[] {""} ;
         H00212_A222MovMayorizadoReferencia = new String[] {""} ;
         H00212_A220MovMayorizadoHora = new String[] {""} ;
         H00212_A219MovMayorizadoFecha = new DateTime[] {DateTime.MinValue} ;
         H00212_A218MovMayorizadoLinea = new short[1] ;
         H00212_A217MovMayorizadoId = new int[1] ;
         H00212_A199TipoParCodigo = new String[] {""} ;
         H00212_A41ClinicaCodigo = new String[] {""} ;
         H00213_AGRID1_nRecordCount = new int[1] ;
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
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblocktipoparcodigo_Jsonclick = "" ;
         lblTextblockmovmayorizadoid_Jsonclick = "" ;
         lblTextblockmovmayorizadolinea_Jsonclick = "" ;
         lblTextblockmovmayorizadofecha_Jsonclick = "" ;
         GXt_char9 = "" ;
         lblTextblockmovmayorizadohora_Jsonclick = "" ;
         lblTextblockmovmayorizadoreferencia_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char10 = "" ;
         ROClassString = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01j0__default(),
            new Object[][] {
                new Object[] {
               H00212_A223MovMayorizadoDebe, H00212_A193CtaContableCodigo, H00212_A222MovMayorizadoReferencia, H00212_A220MovMayorizadoHora, H00212_A219MovMayorizadoFecha, H00212_A218MovMayorizadoLinea, H00212_A217MovMayorizadoId, H00212_A199TipoParCodigo, H00212_A41ClinicaCodigo
               }
               , new Object[] {
               H00213_AGRID1_nRecordCount
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
      private short AV9cMovMayorizadoLinea ;
      private short AV16pMovMayorizadoLinea ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A218MovMayorizadoLinea ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV8cMovMayorizadoId ;
      private int AV15pMovMayorizadoId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A217MovMayorizadoId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A223MovMayorizadoDebe ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
      private String AV11cMovMayorizadoHora ;
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
      private String edtTipoParCodigo_Internalname ;
      private String edtMovMayorizadoId_Internalname ;
      private String edtMovMayorizadoLinea_Internalname ;
      private String edtMovMayorizadoFecha_Internalname ;
      private String edtMovMayorizadoHora_Internalname ;
      private String edtMovMayorizadoReferencia_Internalname ;
      private String edtCtaContableCodigo_Internalname ;
      private String edtMovMayorizadoDebe_Internalname ;
      private String A220MovMayorizadoHora ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String lV11cMovMayorizadoHora ;
      private String edtavCtipoparcodigo_Internalname ;
      private String edtavCmovmayorizadoid_Internalname ;
      private String edtavCmovmayorizadolinea_Internalname ;
      private String edtavCmovmayorizadofecha_Internalname ;
      private String edtavCmovmayorizadohora_Internalname ;
      private String edtavCmovmayorizadoreferencia_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtMovMayorizadoFecha_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblocktipoparcodigo_Internalname ;
      private String lblTextblocktipoparcodigo_Jsonclick ;
      private String edtavCtipoparcodigo_Jsonclick ;
      private String lblTextblockmovmayorizadoid_Internalname ;
      private String lblTextblockmovmayorizadoid_Jsonclick ;
      private String edtavCmovmayorizadoid_Jsonclick ;
      private String lblTextblockmovmayorizadolinea_Internalname ;
      private String lblTextblockmovmayorizadolinea_Jsonclick ;
      private String edtavCmovmayorizadolinea_Jsonclick ;
      private String lblTextblockmovmayorizadofecha_Internalname ;
      private String lblTextblockmovmayorizadofecha_Jsonclick ;
      private String edtavCmovmayorizadofecha_Jsonclick ;
      private String GXt_char9 ;
      private String lblTextblockmovmayorizadohora_Internalname ;
      private String lblTextblockmovmayorizadohora_Jsonclick ;
      private String edtavCmovmayorizadohora_Jsonclick ;
      private String lblTextblockmovmayorizadoreferencia_Internalname ;
      private String lblTextblockmovmayorizadoreferencia_Jsonclick ;
      private String edtavCmovmayorizadoreferencia_Jsonclick ;
      private String GXt_char10 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoParCodigo_Jsonclick ;
      private String edtMovMayorizadoId_Jsonclick ;
      private String edtMovMayorizadoLinea_Jsonclick ;
      private String edtMovMayorizadoFecha_Jsonclick ;
      private String edtMovMayorizadoHora_Jsonclick ;
      private String edtMovMayorizadoReferencia_Jsonclick ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtMovMayorizadoDebe_Jsonclick ;
      private String GXt_char11 ;
      private DateTime AV10cMovMayorizadoFecha ;
      private DateTime A219MovMayorizadoFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV7cTipoParCodigo ;
      private String AV12cMovMayorizadoReferencia ;
      private String AV13pClinicaCodigo ;
      private String AV14pTipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A222MovMayorizadoReferencia ;
      private String A193CtaContableCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV7cTipoParCodigo ;
      private String lV12cMovMayorizadoReferencia ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private decimal[] H00212_A223MovMayorizadoDebe ;
      private String[] H00212_A193CtaContableCodigo ;
      private String[] H00212_A222MovMayorizadoReferencia ;
      private String[] H00212_A220MovMayorizadoHora ;
      private DateTime[] H00212_A219MovMayorizadoFecha ;
      private short[] H00212_A218MovMayorizadoLinea ;
      private int[] H00212_A217MovMayorizadoId ;
      private String[] H00212_A199TipoParCodigo ;
      private String[] H00212_A41ClinicaCodigo ;
      private int[] H00213_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pTipoParCodigo ;
      private int aP2_pMovMayorizadoId ;
      private short aP3_pMovMayorizadoLinea ;
      private GXWebForm Form ;
   }

   public class gx01j0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00212 ;
          prmH00212 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8cMovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cMovMayorizadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cMovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV11cMovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@lV12cMovMayorizadoReferencia",SqlDbType.VarChar,40,0}
          } ;
          Object[] prmH00213 ;
          prmH00213 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8cMovMayorizadoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cMovMayorizadoLinea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cMovMayorizadoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV11cMovMayorizadoHora",SqlDbType.Char,8,0} ,
          new Object[] {"@lV12cMovMayorizadoReferencia",SqlDbType.VarChar,40,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00212", "SELECT [MovMayorizadoDebe], [CtaContableCodigo], [MovMayorizadoReferencia], [MovMayorizadoHora], [MovMayorizadoFecha], [MovMayorizadoLinea], [MovMayorizadoId], [TipoParCodigo], [ClinicaCodigo] FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoParCodigo] like @lV7cTipoParCodigo) AND ([MovMayorizadoId] >= @AV8cMovMayorizadoId) AND ([MovMayorizadoLinea] >= @AV9cMovMayorizadoLinea) AND ([MovMayorizadoFecha] >= @AV10cMovMayorizadoFecha) AND ([MovMayorizadoHora] like @lV11cMovMayorizadoHora) AND ([MovMayorizadoReferencia] like @lV12cMovMayorizadoReferencia) ORDER BY [ClinicaCodigo], [TipoParCodigo], [MovMayorizadoId], [MovMayorizadoLinea]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00212,11,0,false,false )
             ,new CursorDef("H00213", "SELECT COUNT(*) FROM [MovimientoMayorizado] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoParCodigo] like @lV7cTipoParCodigo) AND ([MovMayorizadoId] >= @AV8cMovMayorizadoId) AND ([MovMayorizadoLinea] >= @AV9cMovMayorizadoLinea) AND ([MovMayorizadoFecha] >= @AV10cMovMayorizadoFecha) AND ([MovMayorizadoHora] like @lV11cMovMayorizadoHora) AND ([MovMayorizadoReferencia] like @lV12cMovMayorizadoReferencia) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00213,1,0,false,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getString(4, 8) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (DateTime)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
