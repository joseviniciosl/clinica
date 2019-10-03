/*
               File: Gx01T0
        Description: Selection List Encabezado de movimiento de inventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:41.27
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
   public class gx01t0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01t0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01t0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pTipoMICodigo ,
                           out int aP2_pMovimientoId )
      {
         this.AV13pClinicaCodigo = "" ;
         this.AV14pTipoMICodigo = "" ;
         this.AV15pMovimientoId = 0 ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV13pClinicaCodigo;
         aP1_pTipoMICodigo=this.AV14pTipoMICodigo;
         aP2_pMovimientoId=this.AV15pMovimientoId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCmovimientoestado = new GXCombobox();
         cmbMovimientoEstado = new GXCombobox();
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
               cmbavCmovimientoestado.Name = "vCMOVIMIENTOESTADO" ;
               cmbavCmovimientoestado.WebTags = "" ;
               cmbavCmovimientoestado.addItem("0", "Creado", 0);
               cmbavCmovimientoestado.addItem("1", "Emitido", 0);
               cmbavCmovimientoestado.addItem("2", "Anulado", 0);
               cmbavCmovimientoestado.addItem("3", "Cancelado", 0);
               if ( ( cmbavCmovimientoestado.ItemCount > 0 ) && (0==AV12cMovimientoEstado) )
               {
                  AV12cMovimientoEstado = (short)(NumberUtil.Val( cmbavCmovimientoestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovimientoEstado", StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0));
               }
               GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_51_idx ;
               cmbMovimientoEstado.Name = GXCCtl ;
               cmbMovimientoEstado.WebTags = "" ;
               cmbMovimientoEstado.addItem("0", "Creado", 0);
               cmbMovimientoEstado.addItem("1", "Emitido", 0);
               cmbMovimientoEstado.addItem("2", "Anulado", 0);
               cmbMovimientoEstado.addItem("3", "Cancelado", 0);
               if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
               {
                  A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cTipoMICodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoMICodigo", AV7cTipoMICodigo);
               AV8cMovimientoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovimientoId), 9, 0)));
               AV9cMovimientoFecha = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientoFecha", context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"));
               AV10cBodegaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodegaCodigo", AV10cBodegaCodigo);
               AV11cMovimientoReferencia = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovimientoReferencia", AV11cMovimientoReferencia);
               AV12cMovimientoEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovimientoEstado", StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cTipoMICodigo, AV8cMovimientoId, AV9cMovimientoFecha, AV10cBodegaCodigo, AV11cMovimientoReferencia, AV12cMovimientoEstado) ;
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
                  AV14pTipoMICodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoMICodigo", AV14pTipoMICodigo);
                  AV15pMovimientoId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovimientoId), 9, 0)));
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
         PA2U2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2U2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01t0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pTipoMICodigo)) + "," + UrlEncode("" +AV15pMovimientoId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOMICODIGO", StringUtil.RTrim( AV7cTipoMICodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cMovimientoId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOFECHA", context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCBODEGACODIGO", StringUtil.RTrim( AV10cBodegaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOREFERENCIA", StringUtil.RTrim( AV11cMovimientoReferencia));
         GxWebStd.gx_hidden_field( context, "GXH_vCMOVIMIENTOESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cMovimientoEstado), 1, 0, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV13pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOMICODIGO", StringUtil.RTrim( AV14pTipoMICodigo));
         GxWebStd.gx_hidden_field( context, "vPMOVIMIENTOID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15pMovimientoId), 9, 0, ".", "")));
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
            WE2U2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2U2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01T0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Encabezado de movimiento de inventario" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01t0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pTipoMICodigo)) + "," + UrlEncode("" +AV15pMovimientoId) ;
      }

      protected void WB2U0( )
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
            wb_table1_2_2U2( true) ;
         }
         else
         {
            wb_table1_2_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START2U2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Encabezado de movimiento de inventario", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP2U0( ) ;
      }

      protected void WS2U2( )
      {
         START2U2( ) ;
         EVT2U2( ) ;
      }

      protected void EVT2U2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOMICODIGO"), AV7cTipoMICodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOID"), ".", ",") != Convert.ToDecimal( AV8cMovimientoId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCMOVIMIENTOFECHA"), 2) != AV9cMovimientoFecha )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBODEGACODIGO"), AV10cBodegaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVIMIENTOREFERENCIA"), AV11cMovimientoReferencia) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOESTADO"), ".", ",") != Convert.ToDecimal( AV12cMovimientoEstado )) )
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
                              edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
                              edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
                              edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
                              edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
                              edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
                              cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
                              edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A114TipoMICodigo = cgiGet( edtTipoMICodigo_Internalname) ;
                              A267MovimientoId = (int)(context.localUtil.CToN( cgiGet( edtMovimientoId_Internalname), ".", ",")) ;
                              A268MovimientoFecha = context.localUtil.CToD( cgiGet( edtMovimientoFecha_Internalname), 2) ;
                              A121BodegaCodigo = cgiGet( edtBodegaCodigo_Internalname) ;
                              A269MovimientoReferencia = cgiGet( edtMovimientoReferencia_Internalname) ;
                              cmbMovimientoEstado.Name = cmbMovimientoEstado_Internalname ;
                              cmbMovimientoEstado.CurrentValue = cgiGet( cmbMovimientoEstado_Internalname) ;
                              A271MovimientoEstado = (short)(NumberUtil.Val( cgiGet( cmbMovimientoEstado_Internalname), ".")) ;
                              A4UsuarioCodigo = cgiGet( edtUsuarioCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E112U2 */
                                    E112U2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E122U2 */
                                    E122U2 ();
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
                                       /* Set Refresh If Ctipomicodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOMICODIGO"), AV7cTipoMICodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovimientoid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOID"), ".", ",") != Convert.ToDecimal( AV8cMovimientoId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovimientofecha Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCMOVIMIENTOFECHA"), 2) != AV9cMovimientoFecha )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbodegacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBODEGACODIGO"), AV10cBodegaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovimientoreferencia Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCMOVIMIENTOREFERENCIA"), AV11cMovimientoReferencia) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cmovimientoestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCMOVIMIENTOESTADO"), ".", ",") != Convert.ToDecimal( AV12cMovimientoEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E132U2 */
                                          E132U2 ();
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

      protected void WE2U2( )
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

      protected void PA2U2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCmovimientoestado.Name = "vCMOVIMIENTOESTADO" ;
            cmbavCmovimientoestado.WebTags = "" ;
            cmbavCmovimientoestado.addItem("0", "Creado", 0);
            cmbavCmovimientoestado.addItem("1", "Emitido", 0);
            cmbavCmovimientoestado.addItem("2", "Anulado", 0);
            cmbavCmovimientoestado.addItem("3", "Cancelado", 0);
            if ( ( cmbavCmovimientoestado.ItemCount > 0 ) && (0==AV12cMovimientoEstado) )
            {
               AV12cMovimientoEstado = (short)(NumberUtil.Val( cmbavCmovimientoestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovimientoEstado", StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0));
            }
            GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_51_idx ;
            cmbMovimientoEstado.Name = GXCCtl ;
            cmbMovimientoEstado.WebTags = "" ;
            cmbMovimientoEstado.addItem("0", "Creado", 0);
            cmbMovimientoEstado.addItem("1", "Emitido", 0);
            cmbMovimientoEstado.addItem("2", "Anulado", 0);
            cmbMovimientoEstado.addItem("3", "Cancelado", 0);
            if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
            {
               A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
            }
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
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
         edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
         edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
         cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cTipoMICodigo ,
                                        int AV8cMovimientoId ,
                                        DateTime AV9cMovimientoFecha ,
                                        String AV10cBodegaCodigo ,
                                        String AV11cMovimientoReferencia ,
                                        short AV12cMovimientoEstado )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF2U2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2U2( ) ;
         /* End function Refresh */
      }

      protected void RF2U2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
         edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
         edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
         edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
         edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
         cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
         edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cTipoMICodigo = StringUtil.PadR( StringUtil.RTrim( AV7cTipoMICodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoMICodigo", AV7cTipoMICodigo);
            lV10cBodegaCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cBodegaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodegaCodigo", AV10cBodegaCodigo);
            lV11cMovimientoReferencia = StringUtil.PadR( StringUtil.RTrim( AV11cMovimientoReferencia), 40, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovimientoReferencia", AV11cMovimientoReferencia);
            /* Using cursor H002U2 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cTipoMICodigo, AV8cMovimientoId, AV9cMovimientoFecha, lV10cBodegaCodigo, lV11cMovimientoReferencia, AV12cMovimientoEstado});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A4UsuarioCodigo = H002U2_A4UsuarioCodigo[0] ;
               A271MovimientoEstado = H002U2_A271MovimientoEstado[0] ;
               A269MovimientoReferencia = H002U2_A269MovimientoReferencia[0] ;
               A121BodegaCodigo = H002U2_A121BodegaCodigo[0] ;
               A268MovimientoFecha = H002U2_A268MovimientoFecha[0] ;
               A267MovimientoId = H002U2_A267MovimientoId[0] ;
               A114TipoMICodigo = H002U2_A114TipoMICodigo[0] ;
               A41ClinicaCodigo = H002U2_A41ClinicaCodigo[0] ;
               /* Execute user event: E122U2 */
               E122U2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB2U0( ) ;
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
         lV7cTipoMICodigo = StringUtil.PadR( StringUtil.RTrim( AV7cTipoMICodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoMICodigo", AV7cTipoMICodigo);
         lV10cBodegaCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cBodegaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodegaCodigo", AV10cBodegaCodigo);
         lV11cMovimientoReferencia = StringUtil.PadR( StringUtil.RTrim( AV11cMovimientoReferencia), 40, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovimientoReferencia", AV11cMovimientoReferencia);
         /* Using cursor H002U3 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cTipoMICodigo, AV8cMovimientoId, AV9cMovimientoFecha, lV10cBodegaCodigo, lV11cMovimientoReferencia, AV12cMovimientoEstado});
         GRID1_nRecordCount = H002U3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP2U0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E112U2 */
         E112U2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV7cTipoMICodigo = cgiGet( edtavCtipomicodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoMICodigo", AV7cTipoMICodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCmovimientoid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCmovimientoid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCMOVIMIENTOID");
               GX_FocusControl = edtavCmovimientoid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cMovimientoId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovimientoId), 9, 0)));
            }
            else
            {
               AV8cMovimientoId = (int)(context.localUtil.CToN( cgiGet( edtavCmovimientoid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovimientoId), 9, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCmovimientofecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "vCMOVIMIENTOFECHA");
               GX_FocusControl = edtavCmovimientofecha_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cMovimientoFecha = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientoFecha", context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"));
            }
            else
            {
               AV9cMovimientoFecha = context.localUtil.CToD( cgiGet( edtavCmovimientofecha_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientoFecha", context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"));
            }
            AV10cBodegaCodigo = cgiGet( edtavCbodegacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodegaCodigo", AV10cBodegaCodigo);
            AV11cMovimientoReferencia = cgiGet( edtavCmovimientoreferencia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovimientoReferencia", AV11cMovimientoReferencia);
            cmbavCmovimientoestado.Name = cmbavCmovimientoestado_Internalname ;
            cmbavCmovimientoestado.CurrentValue = cgiGet( cmbavCmovimientoestado_Internalname) ;
            AV12cMovimientoEstado = (short)(NumberUtil.Val( cgiGet( cmbavCmovimientoestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovimientoEstado", StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV14pTipoMICodigo = cgiGet( "vPTIPOMICODIGO") ;
            AV15pMovimientoId = (int)(context.localUtil.CToN( cgiGet( "vPMOVIMIENTOID"), ".", ",")) ;
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
         /* Execute user event: E112U2 */
         E112U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E112U2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Encabezado de movimiento de inventario", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E122U2( )
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
         /* Execute user event: E132U2 */
         E132U2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E132U2( )
      {
         /* Enter Routine */
         AV13pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pTipoMICodigo = A114TipoMICodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoMICodigo", AV14pTipoMICodigo);
         AV15pMovimientoId = A267MovimientoId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovimientoId), 9, 0)));
         context.setWebReturnParms(new Object[] {(String)AV13pClinicaCodigo,(String)AV14pTipoMICodigo,(int)AV15pMovimientoId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_2U2( bool wbgen )
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
            wb_table2_9_2U2( true) ;
         }
         else
         {
            wb_table2_9_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_2U2e( bool wbgen )
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
            wb_table3_48_2U2( true) ;
         }
         else
         {
            wb_table3_48_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2U2e( true) ;
         }
         else
         {
            wb_table1_2_2U2e( false) ;
         }
      }

      protected void wb_table3_48_2U2( bool wbgen )
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
               context.SendWebValue( "Tipo_Movimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Fecha") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Bodega") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Referencia") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A114TipoMICodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A268MovimientoFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtMovimientoFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A121BodegaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A269MovimientoReferencia));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A271MovimientoEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A4UsuarioCodigo));
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
            wb_table4_63_2U2( true) ;
         }
         else
         {
            wb_table4_63_2U2( false) ;
         }
         return  ;
      }

      protected void wb_table4_63_2U2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_2U2e( true) ;
         }
         else
         {
            wb_table3_48_2U2e( false) ;
         }
      }

      protected void wb_table4_63_2U2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_63_2U2e( true) ;
         }
         else
         {
            wb_table4_63_2U2e( false) ;
         }
      }

      protected void wb_table2_9_2U2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipomicodigo_Internalname, "Tipo_Movimiento", "", "", lblTextblocktipomicodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoMICodigo", AV7cTipoMICodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipomicodigo_Internalname, StringUtil.RTrim( AV7cTipoMICodigo), StringUtil.RTrim( context.localUtil.Format( AV7cTipoMICodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCtipomicodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoid_Internalname, "Id", "", "", lblTextblockmovimientoid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cMovimientoId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovimientoid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cMovimientoId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8cMovimientoId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8cMovimientoId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCmovimientoid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientofecha_Internalname, "Fecha", "", "", lblTextblockmovimientofecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cMovimientoFecha", context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCmovimientofecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCmovimientofecha_Internalname, context.localUtil.Format(AV9cMovimientoFecha, "99/99/99"), context.localUtil.Format( AV9cMovimientoFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCmovimientofecha_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx01T0.htm");
            GxWebStd.gx_bitmap( context, edtavCmovimientofecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx01T0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbodegacodigo_Internalname, "Bodega", "", "", lblTextblockbodegacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBodegaCodigo", AV10cBodegaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbodegacodigo_Internalname, StringUtil.RTrim( AV10cBodegaCodigo), StringUtil.RTrim( context.localUtil.Format( AV10cBodegaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", "", "", "", edtavCbodegacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoreferencia_Internalname, "Referencia", "", "", lblTextblockmovimientoreferencia_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cMovimientoReferencia", AV11cMovimientoReferencia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCmovimientoreferencia_Internalname, StringUtil.RTrim( AV11cMovimientoReferencia), StringUtil.RTrim( context.localUtil.Format( AV11cMovimientoReferencia, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", "", "", "", edtavCmovimientoreferencia_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 40, "chr", 1, "row", 40, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockmovimientoestado_Internalname, "Movimiento Estado", "", "", lblTextblockmovimientoestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01T0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cMovimientoEstado", StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCmovimientoestado, cmbavCmovimientoestado_Internalname, StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0), 1, cmbavCmovimientoestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", "", true, "HLP_Gx01T0.htm");
            cmbavCmovimientoestado.CurrentValue = StringUtil.Str( (decimal)(AV12cMovimientoEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCmovimientoestado_Internalname, "Values", (String)(cmbavCmovimientoestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_2U2e( true) ;
         }
         else
         {
            wb_table2_9_2U2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pTipoMICodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pTipoMICodigo", AV14pTipoMICodigo);
         AV15pMovimientoId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15pMovimientoId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15pMovimientoId), 9, 0)));
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
         PA2U2( ) ;
         WS2U2( ) ;
         WE2U2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?159422");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx01t0.js", "?159422");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB2U0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A114TipoMICodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoMICodigo_Internalname,StringUtil.RTrim( A114TipoMICodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoMICodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A267MovimientoId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtMovimientoFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A114TipoMICodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A267MovimientoId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoFecha_Internalname,context.localUtil.Format(A268MovimientoFecha, "99/99/99"),context.localUtil.Format( A268MovimientoFecha, "99/99/99"),(String)"",(String)"",(String)edtMovimientoFecha_Link,(String)"",(String)"Seleccionar",(String)edtMovimientoFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBodegaCodigo_Internalname,StringUtil.RTrim( A121BodegaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBodegaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMovimientoReferencia_Internalname,StringUtil.RTrim( A269MovimientoReferencia),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMovimientoReferencia_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)40,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "MOVIMIENTOESTADO_" + sGXsfl_51_idx ;
               cmbMovimientoEstado.Name = GXCCtl ;
               cmbMovimientoEstado.WebTags = "" ;
               cmbMovimientoEstado.addItem("0", "Creado", 0);
               cmbMovimientoEstado.addItem("1", "Emitido", 0);
               cmbMovimientoEstado.addItem("2", "Anulado", 0);
               cmbMovimientoEstado.addItem("3", "Cancelado", 0);
               if ( ( cmbMovimientoEstado.ItemCount > 0 ) && (0==A271MovimientoEstado) )
               {
                  A271MovimientoEstado = (short)(NumberUtil.Val( cmbMovimientoEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbMovimientoEstado,(String)cmbMovimientoEstado_Internalname,StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0),(short)1,(String)cmbMovimientoEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbMovimientoEstado.CurrentValue = StringUtil.Str( (decimal)(A271MovimientoEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbMovimientoEstado_Internalname, "Values", (String)(cmbMovimientoEstado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtUsuarioCodigo_Internalname,StringUtil.RTrim( A4UsuarioCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtUsuarioCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtTipoMICodigo_Internalname = "TIPOMICODIGO_"+sGXsfl_51_idx ;
            edtMovimientoId_Internalname = "MOVIMIENTOID_"+sGXsfl_51_idx ;
            edtMovimientoFecha_Internalname = "MOVIMIENTOFECHA_"+sGXsfl_51_idx ;
            edtBodegaCodigo_Internalname = "BODEGACODIGO_"+sGXsfl_51_idx ;
            edtMovimientoReferencia_Internalname = "MOVIMIENTOREFERENCIA_"+sGXsfl_51_idx ;
            cmbMovimientoEstado_Internalname = "MOVIMIENTOESTADO_"+sGXsfl_51_idx ;
            edtUsuarioCodigo_Internalname = "USUARIOCODIGO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblocktipomicodigo_Internalname = "TEXTBLOCKTIPOMICODIGO" ;
         edtavCtipomicodigo_Internalname = "vCTIPOMICODIGO" ;
         lblTextblockmovimientoid_Internalname = "TEXTBLOCKMOVIMIENTOID" ;
         edtavCmovimientoid_Internalname = "vCMOVIMIENTOID" ;
         lblTextblockmovimientofecha_Internalname = "TEXTBLOCKMOVIMIENTOFECHA" ;
         edtavCmovimientofecha_Internalname = "vCMOVIMIENTOFECHA" ;
         lblTextblockbodegacodigo_Internalname = "TEXTBLOCKBODEGACODIGO" ;
         edtavCbodegacodigo_Internalname = "vCBODEGACODIGO" ;
         lblTextblockmovimientoreferencia_Internalname = "TEXTBLOCKMOVIMIENTOREFERENCIA" ;
         edtavCmovimientoreferencia_Internalname = "vCMOVIMIENTOREFERENCIA" ;
         lblTextblockmovimientoestado_Internalname = "TEXTBLOCKMOVIMIENTOESTADO" ;
         cmbavCmovimientoestado_Internalname = "vCMOVIMIENTOESTADO" ;
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
         cmbMovimientoEstado_Jsonclick = "" ;
         edtMovimientoReferencia_Jsonclick = "" ;
         edtBodegaCodigo_Jsonclick = "" ;
         edtMovimientoFecha_Jsonclick = "" ;
         edtMovimientoId_Jsonclick = "" ;
         edtTipoMICodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         cmbavCmovimientoestado_Jsonclick = "" ;
         edtavCmovimientoreferencia_Jsonclick = "" ;
         edtavCbodegacodigo_Jsonclick = "" ;
         edtavCmovimientofecha_Jsonclick = "" ;
         edtavCmovimientoid_Jsonclick = "" ;
         edtavCtipomicodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtMovimientoFecha_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Encabezado de movimiento de inventario" ;
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
         GXCCtl = "" ;
         AV6cClinicaCodigo = "" ;
         AV7cTipoMICodigo = "" ;
         AV9cMovimientoFecha = DateTime.MinValue ;
         AV10cBodegaCodigo = "" ;
         AV11cMovimientoReferencia = "" ;
         AV13pClinicaCodigo = "" ;
         AV14pTipoMICodigo = "" ;
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
         edtTipoMICodigo_Internalname = "" ;
         edtMovimientoId_Internalname = "" ;
         edtMovimientoFecha_Internalname = "" ;
         edtBodegaCodigo_Internalname = "" ;
         edtMovimientoReferencia_Internalname = "" ;
         cmbMovimientoEstado_Internalname = "" ;
         edtUsuarioCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A114TipoMICodigo = "" ;
         A268MovimientoFecha = DateTime.MinValue ;
         A121BodegaCodigo = "" ;
         A269MovimientoReferencia = "" ;
         A4UsuarioCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cTipoMICodigo = "" ;
         lV10cBodegaCodigo = "" ;
         lV11cMovimientoReferencia = "" ;
         H002U2_A4UsuarioCodigo = new String[] {""} ;
         H002U2_A271MovimientoEstado = new short[1] ;
         H002U2_A269MovimientoReferencia = new String[] {""} ;
         H002U2_A121BodegaCodigo = new String[] {""} ;
         H002U2_A268MovimientoFecha = new DateTime[] {DateTime.MinValue} ;
         H002U2_A267MovimientoId = new int[1] ;
         H002U2_A114TipoMICodigo = new String[] {""} ;
         H002U2_A41ClinicaCodigo = new String[] {""} ;
         H002U3_AGRID1_nRecordCount = new int[1] ;
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
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblocktipomicodigo_Jsonclick = "" ;
         lblTextblockmovimientoid_Jsonclick = "" ;
         lblTextblockmovimientofecha_Jsonclick = "" ;
         GXt_char8 = "" ;
         lblTextblockbodegacodigo_Jsonclick = "" ;
         lblTextblockmovimientoreferencia_Jsonclick = "" ;
         lblTextblockmovimientoestado_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char9 = "" ;
         ROClassString = "" ;
         GXt_char10 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01t0__default(),
            new Object[][] {
                new Object[] {
               H002U2_A4UsuarioCodigo, H002U2_A271MovimientoEstado, H002U2_A269MovimientoReferencia, H002U2_A121BodegaCodigo, H002U2_A268MovimientoFecha, H002U2_A267MovimientoId, H002U2_A114TipoMICodigo, H002U2_A41ClinicaCodigo
               }
               , new Object[] {
               H002U3_AGRID1_nRecordCount
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
      private short AV12cMovimientoEstado ;
      private short A271MovimientoEstado ;
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
      private int Grid1_PageSize51 ;
      private int AV8cMovimientoId ;
      private int AV15pMovimientoId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A267MovimientoId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_51_idx="0001" ;
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
      private String edtClinicaCodigo_Internalname ;
      private String edtTipoMICodigo_Internalname ;
      private String edtMovimientoId_Internalname ;
      private String edtMovimientoFecha_Internalname ;
      private String edtBodegaCodigo_Internalname ;
      private String edtMovimientoReferencia_Internalname ;
      private String cmbMovimientoEstado_Internalname ;
      private String edtUsuarioCodigo_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCtipomicodigo_Internalname ;
      private String edtavCmovimientoid_Internalname ;
      private String edtavCmovimientofecha_Internalname ;
      private String edtavCbodegacodigo_Internalname ;
      private String edtavCmovimientoreferencia_Internalname ;
      private String cmbavCmovimientoestado_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtMovimientoFecha_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblocktipomicodigo_Internalname ;
      private String lblTextblocktipomicodigo_Jsonclick ;
      private String edtavCtipomicodigo_Jsonclick ;
      private String lblTextblockmovimientoid_Internalname ;
      private String lblTextblockmovimientoid_Jsonclick ;
      private String edtavCmovimientoid_Jsonclick ;
      private String lblTextblockmovimientofecha_Internalname ;
      private String lblTextblockmovimientofecha_Jsonclick ;
      private String edtavCmovimientofecha_Jsonclick ;
      private String GXt_char8 ;
      private String lblTextblockbodegacodigo_Internalname ;
      private String lblTextblockbodegacodigo_Jsonclick ;
      private String edtavCbodegacodigo_Jsonclick ;
      private String lblTextblockmovimientoreferencia_Internalname ;
      private String lblTextblockmovimientoreferencia_Jsonclick ;
      private String edtavCmovimientoreferencia_Jsonclick ;
      private String lblTextblockmovimientoestado_Internalname ;
      private String lblTextblockmovimientoestado_Jsonclick ;
      private String cmbavCmovimientoestado_Jsonclick ;
      private String GXt_char9 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoMICodigo_Jsonclick ;
      private String edtMovimientoId_Jsonclick ;
      private String edtMovimientoFecha_Jsonclick ;
      private String edtBodegaCodigo_Jsonclick ;
      private String edtMovimientoReferencia_Jsonclick ;
      private String cmbMovimientoEstado_Jsonclick ;
      private String edtUsuarioCodigo_Jsonclick ;
      private String GXt_char10 ;
      private DateTime AV9cMovimientoFecha ;
      private DateTime A268MovimientoFecha ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV7cTipoMICodigo ;
      private String AV10cBodegaCodigo ;
      private String AV11cMovimientoReferencia ;
      private String AV13pClinicaCodigo ;
      private String AV14pTipoMICodigo ;
      private String A41ClinicaCodigo ;
      private String A114TipoMICodigo ;
      private String A121BodegaCodigo ;
      private String A269MovimientoReferencia ;
      private String A4UsuarioCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV7cTipoMICodigo ;
      private String lV10cBodegaCodigo ;
      private String lV11cMovimientoReferencia ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCmovimientoestado ;
      private GXCombobox cmbMovimientoEstado ;
      private IDataStoreProvider pr_default ;
      private String[] H002U2_A4UsuarioCodigo ;
      private short[] H002U2_A271MovimientoEstado ;
      private String[] H002U2_A269MovimientoReferencia ;
      private String[] H002U2_A121BodegaCodigo ;
      private DateTime[] H002U2_A268MovimientoFecha ;
      private int[] H002U2_A267MovimientoId ;
      private String[] H002U2_A114TipoMICodigo ;
      private String[] H002U2_A41ClinicaCodigo ;
      private int[] H002U3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pTipoMICodigo ;
      private int aP2_pMovimientoId ;
      private GXWebForm Form ;
   }

   public class gx01t0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002U2 ;
          prmH002U2 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8cMovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cMovimientoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV10cBodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV11cMovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV12cMovimientoEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmH002U3 ;
          prmH002U3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8cMovimientoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV9cMovimientoFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV10cBodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV11cMovimientoReferencia",SqlDbType.VarChar,40,0} ,
          new Object[] {"@AV12cMovimientoEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002U2", "SELECT [UsuarioCodigo], [MovimientoEstado], [MovimientoReferencia], [BodegaCodigo], [MovimientoFecha], [MovimientoId], [TipoMICodigo], [ClinicaCodigo] FROM [MovimientoInv] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoMICodigo] like @lV7cTipoMICodigo) AND ([MovimientoId] >= @AV8cMovimientoId) AND ([MovimientoFecha] >= @AV9cMovimientoFecha) AND ([BodegaCodigo] like @lV10cBodegaCodigo) AND ([MovimientoReferencia] like @lV11cMovimientoReferencia) AND ([MovimientoEstado] >= @AV12cMovimientoEstado) ORDER BY [ClinicaCodigo], [TipoMICodigo], [MovimientoId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U2,11,0,false,false )
             ,new CursorDef("H002U3", "SELECT COUNT(*) FROM [MovimientoInv] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoMICodigo] like @lV7cTipoMICodigo) AND ([MovimientoId] >= @AV8cMovimientoId) AND ([MovimientoFecha] >= @AV9cMovimientoFecha) AND ([BodegaCodigo] like @lV10cBodegaCodigo) AND ([MovimientoReferencia] like @lV11cMovimientoReferencia) AND ([MovimientoEstado] >= @AV12cMovimientoEstado) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002U3,1,0,false,false )
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((DateTime[]) buf[4])[0] = rslt.getGXDate(5) ;
                ((int[]) buf[5])[0] = rslt.getInt(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
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
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (int)parms[2]);
                stmt.SetParameter(4, (DateTime)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
