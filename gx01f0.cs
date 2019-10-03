/*
               File: Gx01F0
        Description: Selection List Tipos de Partidas Contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:21.82
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
   public class gx01f0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01f0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01f0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pTipoParCodigo )
      {
         this.AV12pClinicaCodigo = "" ;
         this.AV13pTipoParCodigo = "" ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV12pClinicaCodigo;
         aP1_pTipoParCodigo=this.AV13pTipoParCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCtipoparauxiliar = new GXCombobox();
         cmbavCtipoparmayoriza = new GXCombobox();
         cmbavCtipoparestado = new GXCombobox();
         cmbTipoParAuxiliar = new GXCombobox();
         cmbTipoParMayoriza = new GXCombobox();
         cmbTipoParEstado = new GXCombobox();
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
               cmbavCtipoparauxiliar.Name = "vCTIPOPARAUXILIAR" ;
               cmbavCtipoparauxiliar.WebTags = "" ;
               cmbavCtipoparauxiliar.addItem("1", "Contabilidad", 0);
               cmbavCtipoparauxiliar.addItem("2", "Inventario", 0);
               cmbavCtipoparauxiliar.addItem("3", "Facturación", 0);
               if ( ( cmbavCtipoparauxiliar.ItemCount > 0 ) && (0==AV9cTipoParAuxiliar) )
               {
                  AV9cTipoParAuxiliar = (short)(NumberUtil.Val( cmbavCtipoparauxiliar.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoParAuxiliar", StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0));
               }
               cmbavCtipoparmayoriza.Name = "vCTIPOPARMAYORIZA" ;
               cmbavCtipoparmayoriza.WebTags = "" ;
               cmbavCtipoparmayoriza.addItem("0", "No", 0);
               cmbavCtipoparmayoriza.addItem("1", "Si", 0);
               if ( ( cmbavCtipoparmayoriza.ItemCount > 0 ) && (0==AV10cTipoParMayoriza) )
               {
                  AV10cTipoParMayoriza = (short)(NumberUtil.Val( cmbavCtipoparmayoriza.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoParMayoriza", StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0));
               }
               cmbavCtipoparestado.Name = "vCTIPOPARESTADO" ;
               cmbavCtipoparestado.WebTags = "" ;
               cmbavCtipoparestado.addItem("0", "De baja", 0);
               cmbavCtipoparestado.addItem("1", "Activo", 0);
               if ( ( cmbavCtipoparestado.ItemCount > 0 ) && (0==AV11cTipoParEstado) )
               {
                  AV11cTipoParEstado = (short)(NumberUtil.Val( cmbavCtipoparestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoParEstado", StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0));
               }
               GXCCtl = "TIPOPARAUXILIAR_" + sGXsfl_46_idx ;
               cmbTipoParAuxiliar.Name = GXCCtl ;
               cmbTipoParAuxiliar.WebTags = "" ;
               cmbTipoParAuxiliar.addItem("1", "Contabilidad", 0);
               cmbTipoParAuxiliar.addItem("2", "Inventario", 0);
               cmbTipoParAuxiliar.addItem("3", "Facturación", 0);
               if ( ( cmbTipoParAuxiliar.ItemCount > 0 ) && (0==A201TipoParAuxiliar) )
               {
                  A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.getItemValue(1), ".")) ;
               }
               GXCCtl = "TIPOPARMAYORIZA_" + sGXsfl_46_idx ;
               cmbTipoParMayoriza.Name = GXCCtl ;
               cmbTipoParMayoriza.WebTags = "" ;
               cmbTipoParMayoriza.addItem("0", "No", 0);
               cmbTipoParMayoriza.addItem("1", "Si", 0);
               if ( ( cmbTipoParMayoriza.ItemCount > 0 ) && (0==A202TipoParMayoriza) )
               {
                  A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.getItemValue(1), ".")) ;
               }
               GXCCtl = "TIPOPARESTADO_" + sGXsfl_46_idx ;
               cmbTipoParEstado.Name = GXCCtl ;
               cmbTipoParEstado.WebTags = "" ;
               cmbTipoParEstado.addItem("0", "De baja", 0);
               cmbTipoParEstado.addItem("1", "Activo", 0);
               if ( ( cmbTipoParEstado.ItemCount > 0 ) && (0==A203TipoParEstado) )
               {
                  A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cTipoParCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
               AV8cTipoParNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoParNombre", AV8cTipoParNombre);
               AV9cTipoParAuxiliar = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoParAuxiliar", StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0));
               AV10cTipoParMayoriza = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoParMayoriza", StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0));
               AV11cTipoParEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoParEstado", StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cClinicaCodigo, AV7cTipoParCodigo, AV8cTipoParNombre, AV9cTipoParAuxiliar, AV10cTipoParMayoriza, AV11cTipoParEstado) ;
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
                  AV13pTipoParCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoParCodigo", AV13pTipoParCodigo);
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
         PA1W2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1W2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01f0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pTipoParCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARCODIGO", StringUtil.RTrim( AV7cTipoParCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARNOMBRE", StringUtil.RTrim( AV8cTipoParNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARAUXILIAR", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTipoParAuxiliar), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARMAYORIZA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cTipoParMayoriza), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOPARESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cTipoParEstado), 1, 0, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV12pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOPARCODIGO", StringUtil.RTrim( AV13pTipoParCodigo));
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
            WE1W2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1W2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01F0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Tipos de Partidas Contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01f0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pTipoParCodigo)) ;
      }

      protected void WB1W0( )
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
            wb_table1_2_1W2( true) ;
         }
         else
         {
            wb_table1_2_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1W2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1W2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Tipos de Partidas Contables", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1W0( ) ;
      }

      protected void WS1W2( )
      {
         START1W2( ) ;
         EVT1W2( ) ;
      }

      protected void EVT1W2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOPARNOMBRE"), AV8cTipoParNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARAUXILIAR"), ".", ",") != Convert.ToDecimal( AV9cTipoParAuxiliar )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARMAYORIZA"), ".", ",") != Convert.ToDecimal( AV10cTipoParMayoriza )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARESTADO"), ".", ",") != Convert.ToDecimal( AV11cTipoParEstado )) )
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
                              edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
                              edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
                              cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
                              cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
                              cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A199TipoParCodigo = cgiGet( edtTipoParCodigo_Internalname) ;
                              A200TipoParNombre = cgiGet( edtTipoParNombre_Internalname) ;
                              cmbTipoParAuxiliar.Name = cmbTipoParAuxiliar_Internalname ;
                              cmbTipoParAuxiliar.CurrentValue = cgiGet( cmbTipoParAuxiliar_Internalname) ;
                              A201TipoParAuxiliar = (short)(NumberUtil.Val( cgiGet( cmbTipoParAuxiliar_Internalname), ".")) ;
                              cmbTipoParMayoriza.Name = cmbTipoParMayoriza_Internalname ;
                              cmbTipoParMayoriza.CurrentValue = cgiGet( cmbTipoParMayoriza_Internalname) ;
                              A202TipoParMayoriza = (short)(NumberUtil.Val( cgiGet( cmbTipoParMayoriza_Internalname), ".")) ;
                              cmbTipoParEstado.Name = cmbTipoParEstado_Internalname ;
                              cmbTipoParEstado.CurrentValue = cgiGet( cmbTipoParEstado_Internalname) ;
                              A203TipoParEstado = (short)(NumberUtil.Val( cgiGet( cmbTipoParEstado_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111W2 */
                                    E111W2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121W2 */
                                    E121W2 ();
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
                                       /* Set Refresh If Ctipoparnombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOPARNOMBRE"), AV8cTipoParNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipoparauxiliar Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARAUXILIAR"), ".", ",") != Convert.ToDecimal( AV9cTipoParAuxiliar )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipoparmayoriza Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARMAYORIZA"), ".", ",") != Convert.ToDecimal( AV10cTipoParMayoriza )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipoparestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOPARESTADO"), ".", ",") != Convert.ToDecimal( AV11cTipoParEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E131W2 */
                                          E131W2 ();
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

      protected void WE1W2( )
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

      protected void PA1W2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCtipoparauxiliar.Name = "vCTIPOPARAUXILIAR" ;
            cmbavCtipoparauxiliar.WebTags = "" ;
            cmbavCtipoparauxiliar.addItem("1", "Contabilidad", 0);
            cmbavCtipoparauxiliar.addItem("2", "Inventario", 0);
            cmbavCtipoparauxiliar.addItem("3", "Facturación", 0);
            if ( ( cmbavCtipoparauxiliar.ItemCount > 0 ) && (0==AV9cTipoParAuxiliar) )
            {
               AV9cTipoParAuxiliar = (short)(NumberUtil.Val( cmbavCtipoparauxiliar.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoParAuxiliar", StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0));
            }
            cmbavCtipoparmayoriza.Name = "vCTIPOPARMAYORIZA" ;
            cmbavCtipoparmayoriza.WebTags = "" ;
            cmbavCtipoparmayoriza.addItem("0", "No", 0);
            cmbavCtipoparmayoriza.addItem("1", "Si", 0);
            if ( ( cmbavCtipoparmayoriza.ItemCount > 0 ) && (0==AV10cTipoParMayoriza) )
            {
               AV10cTipoParMayoriza = (short)(NumberUtil.Val( cmbavCtipoparmayoriza.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoParMayoriza", StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0));
            }
            cmbavCtipoparestado.Name = "vCTIPOPARESTADO" ;
            cmbavCtipoparestado.WebTags = "" ;
            cmbavCtipoparestado.addItem("0", "De baja", 0);
            cmbavCtipoparestado.addItem("1", "Activo", 0);
            if ( ( cmbavCtipoparestado.ItemCount > 0 ) && (0==AV11cTipoParEstado) )
            {
               AV11cTipoParEstado = (short)(NumberUtil.Val( cmbavCtipoparestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoParEstado", StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0));
            }
            GXCCtl = "TIPOPARAUXILIAR_" + sGXsfl_46_idx ;
            cmbTipoParAuxiliar.Name = GXCCtl ;
            cmbTipoParAuxiliar.WebTags = "" ;
            cmbTipoParAuxiliar.addItem("1", "Contabilidad", 0);
            cmbTipoParAuxiliar.addItem("2", "Inventario", 0);
            cmbTipoParAuxiliar.addItem("3", "Facturación", 0);
            if ( ( cmbTipoParAuxiliar.ItemCount > 0 ) && (0==A201TipoParAuxiliar) )
            {
               A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.getItemValue(1), ".")) ;
            }
            GXCCtl = "TIPOPARMAYORIZA_" + sGXsfl_46_idx ;
            cmbTipoParMayoriza.Name = GXCCtl ;
            cmbTipoParMayoriza.WebTags = "" ;
            cmbTipoParMayoriza.addItem("0", "No", 0);
            cmbTipoParMayoriza.addItem("1", "Si", 0);
            if ( ( cmbTipoParMayoriza.ItemCount > 0 ) && (0==A202TipoParMayoriza) )
            {
               A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.getItemValue(1), ".")) ;
            }
            GXCCtl = "TIPOPARESTADO_" + sGXsfl_46_idx ;
            cmbTipoParEstado.Name = GXCCtl ;
            cmbTipoParEstado.WebTags = "" ;
            cmbTipoParEstado.addItem("0", "De baja", 0);
            cmbTipoParEstado.addItem("1", "Activo", 0);
            if ( ( cmbTipoParEstado.ItemCount > 0 ) && (0==A203TipoParEstado) )
            {
               A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.getItemValue(1), ".")) ;
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
                                       short nGXsfl_46_idx ,
                                       String sGXsfl_46_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
         edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
         cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
         cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
         cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
            cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
            cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
            cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cTipoParCodigo ,
                                        String AV8cTipoParNombre ,
                                        short AV9cTipoParAuxiliar ,
                                        short AV10cTipoParMayoriza ,
                                        short AV11cTipoParEstado )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF1W2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1W2( ) ;
         /* End function Refresh */
      }

      protected void RF1W2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
         edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
         cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
         cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
         cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
            cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
            cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
            cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cTipoParCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cTipoParCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
            lV8cTipoParNombre = StringUtil.PadR( StringUtil.RTrim( AV8cTipoParNombre), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoParNombre", AV8cTipoParNombre);
            /* Using cursor H001W2 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cTipoParCodigo, lV8cTipoParNombre, AV9cTipoParAuxiliar, AV10cTipoParMayoriza, AV11cTipoParEstado});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A203TipoParEstado = H001W2_A203TipoParEstado[0] ;
               A202TipoParMayoriza = H001W2_A202TipoParMayoriza[0] ;
               A201TipoParAuxiliar = H001W2_A201TipoParAuxiliar[0] ;
               A200TipoParNombre = H001W2_A200TipoParNombre[0] ;
               A199TipoParCodigo = H001W2_A199TipoParCodigo[0] ;
               A41ClinicaCodigo = H001W2_A41ClinicaCodigo[0] ;
               /* Execute user event: E121W2 */
               E121W2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 46 ;
            WB1W0( ) ;
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
         lV8cTipoParNombre = StringUtil.PadR( StringUtil.RTrim( AV8cTipoParNombre), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoParNombre", AV8cTipoParNombre);
         /* Using cursor H001W3 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cTipoParCodigo, lV8cTipoParNombre, AV9cTipoParAuxiliar, AV10cTipoParMayoriza, AV11cTipoParEstado});
         GRID1_nRecordCount = H001W3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1W0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111W2 */
         E111W2 ();
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
            AV8cTipoParNombre = cgiGet( edtavCtipoparnombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoParNombre", AV8cTipoParNombre);
            cmbavCtipoparauxiliar.Name = cmbavCtipoparauxiliar_Internalname ;
            cmbavCtipoparauxiliar.CurrentValue = cgiGet( cmbavCtipoparauxiliar_Internalname) ;
            AV9cTipoParAuxiliar = (short)(NumberUtil.Val( cgiGet( cmbavCtipoparauxiliar_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoParAuxiliar", StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0));
            cmbavCtipoparmayoriza.Name = cmbavCtipoparmayoriza_Internalname ;
            cmbavCtipoparmayoriza.CurrentValue = cgiGet( cmbavCtipoparmayoriza_Internalname) ;
            AV10cTipoParMayoriza = (short)(NumberUtil.Val( cgiGet( cmbavCtipoparmayoriza_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoParMayoriza", StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0));
            cmbavCtipoparestado.Name = cmbavCtipoparestado_Internalname ;
            cmbavCtipoparestado.CurrentValue = cgiGet( cmbavCtipoparestado_Internalname) ;
            AV11cTipoParEstado = (short)(NumberUtil.Val( cgiGet( cmbavCtipoparestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoParEstado", StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV13pTipoParCodigo = cgiGet( "vPTIPOPARCODIGO") ;
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
         /* Execute user event: E111W2 */
         E111W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111W2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Tipos de Partidas Contables", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E121W2( )
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
         /* Execute user event: E131W2 */
         E131W2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131W2( )
      {
         /* Enter Routine */
         AV12pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pTipoParCodigo = A199TipoParCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoParCodigo", AV13pTipoParCodigo);
         context.setWebReturnParms(new Object[] {(String)AV12pClinicaCodigo,(String)AV13pTipoParCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_1W2( bool wbgen )
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
            wb_table2_9_1W2( true) ;
         }
         else
         {
            wb_table2_9_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_1W2e( bool wbgen )
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
            wb_table3_43_1W2( true) ;
         }
         else
         {
            wb_table3_43_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_1W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1W2e( true) ;
         }
         else
         {
            wb_table1_2_1W2e( false) ;
         }
      }

      protected void wb_table3_43_1W2( bool wbgen )
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Partida") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Auxiliar") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Mayoriza?") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A200TipoParNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTipoParNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A201TipoParAuxiliar), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A202TipoParMayoriza), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A203TipoParEstado), 1, 0, ".", "")));
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
            wb_table4_56_1W2( true) ;
         }
         else
         {
            wb_table4_56_1W2( false) ;
         }
         return  ;
      }

      protected void wb_table4_56_1W2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_1W2e( true) ;
         }
         else
         {
            wb_table3_43_1W2e( false) ;
         }
      }

      protected void wb_table4_56_1W2( bool wbgen )
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
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_56_1W2e( true) ;
         }
         else
         {
            wb_table4_56_1W2e( false) ;
         }
      }

      protected void wb_table2_9_1W2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparcodigo_Internalname, "Tipo_Partida", "", "", lblTextblocktipoparcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cTipoParCodigo", AV7cTipoParCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipoparcodigo_Internalname, StringUtil.RTrim( AV7cTipoParCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cTipoParCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCtipoparcodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparnombre_Internalname, "Nombre", "", "", lblTextblocktipoparnombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoParNombre", AV8cTipoParNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipoparnombre_Internalname, StringUtil.RTrim( AV8cTipoParNombre), StringUtil.RTrim( context.localUtil.Format( AV8cTipoParNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", "", "", "", edtavCtipoparnombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparauxiliar_Internalname, "Auxiliar", "", "", lblTextblocktipoparauxiliar_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoParAuxiliar", StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipoparauxiliar, cmbavCtipoparauxiliar_Internalname, StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0), 1, cmbavCtipoparauxiliar_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", true, "HLP_Gx01F0.htm");
            cmbavCtipoparauxiliar.CurrentValue = StringUtil.Str( (decimal)(AV9cTipoParAuxiliar), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCtipoparauxiliar_Internalname, "Values", (String)(cmbavCtipoparauxiliar.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparmayoriza_Internalname, "Mayoriza?", "", "", lblTextblocktipoparmayoriza_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cTipoParMayoriza", StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipoparmayoriza, cmbavCtipoparmayoriza_Internalname, StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0), 1, cmbavCtipoparmayoriza_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", true, "HLP_Gx01F0.htm");
            cmbavCtipoparmayoriza.CurrentValue = StringUtil.Str( (decimal)(AV10cTipoParMayoriza), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCtipoparmayoriza_Internalname, "Values", (String)(cmbavCtipoparmayoriza.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipoparestado_Internalname, "Estado", "", "", lblTextblocktipoparestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01F0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cTipoParEstado", StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipoparestado, cmbavCtipoparestado_Internalname, StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0), 1, cmbavCtipoparestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", true, "HLP_Gx01F0.htm");
            cmbavCtipoparestado.CurrentValue = StringUtil.Str( (decimal)(AV11cTipoParEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCtipoparestado_Internalname, "Values", (String)(cmbavCtipoparestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_1W2e( true) ;
         }
         else
         {
            wb_table2_9_1W2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pTipoParCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pTipoParCodigo", AV13pTipoParCodigo);
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
         PA1W2( ) ;
         WS1W2( ) ;
         WE1W2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1592247");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx01f0.js", "?1592247");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB1W0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TipoParCodigo))+"'"+"]);" ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParCodigo_Internalname,StringUtil.RTrim( A199TipoParCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTipoParCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTipoParNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A199TipoParCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoParNombre_Internalname,StringUtil.RTrim( A200TipoParNombre),(String)"",(String)"",(String)"",(String)edtTipoParNombre_Link,(String)"",(String)"Seleccionar",(String)edtTipoParNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOPARAUXILIAR_" + sGXsfl_46_idx ;
               cmbTipoParAuxiliar.Name = GXCCtl ;
               cmbTipoParAuxiliar.WebTags = "" ;
               cmbTipoParAuxiliar.addItem("1", "Contabilidad", 0);
               cmbTipoParAuxiliar.addItem("2", "Inventario", 0);
               cmbTipoParAuxiliar.addItem("3", "Facturación", 0);
               if ( ( cmbTipoParAuxiliar.ItemCount > 0 ) && (0==A201TipoParAuxiliar) )
               {
                  A201TipoParAuxiliar = (short)(NumberUtil.Val( cmbTipoParAuxiliar.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTipoParAuxiliar,(String)cmbTipoParAuxiliar_Internalname,StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0),(short)1,(String)cmbTipoParAuxiliar_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbTipoParAuxiliar.CurrentValue = StringUtil.Str( (decimal)(A201TipoParAuxiliar), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParAuxiliar_Internalname, "Values", (String)(cmbTipoParAuxiliar.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOPARMAYORIZA_" + sGXsfl_46_idx ;
               cmbTipoParMayoriza.Name = GXCCtl ;
               cmbTipoParMayoriza.WebTags = "" ;
               cmbTipoParMayoriza.addItem("0", "No", 0);
               cmbTipoParMayoriza.addItem("1", "Si", 0);
               if ( ( cmbTipoParMayoriza.ItemCount > 0 ) && (0==A202TipoParMayoriza) )
               {
                  A202TipoParMayoriza = (short)(NumberUtil.Val( cmbTipoParMayoriza.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTipoParMayoriza,(String)cmbTipoParMayoriza_Internalname,StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0),(short)1,(String)cmbTipoParMayoriza_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbTipoParMayoriza.CurrentValue = StringUtil.Str( (decimal)(A202TipoParMayoriza), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParMayoriza_Internalname, "Values", (String)(cmbTipoParMayoriza.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOPARESTADO_" + sGXsfl_46_idx ;
               cmbTipoParEstado.Name = GXCCtl ;
               cmbTipoParEstado.WebTags = "" ;
               cmbTipoParEstado.addItem("0", "De baja", 0);
               cmbTipoParEstado.addItem("1", "Activo", 0);
               if ( ( cmbTipoParEstado.ItemCount > 0 ) && (0==A203TipoParEstado) )
               {
                  A203TipoParEstado = (short)(NumberUtil.Val( cmbTipoParEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTipoParEstado,(String)cmbTipoParEstado_Internalname,StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0),(short)1,(String)cmbTipoParEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbTipoParEstado.CurrentValue = StringUtil.Str( (decimal)(A203TipoParEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoParEstado_Internalname, "Values", (String)(cmbTipoParEstado.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            edtTipoParCodigo_Internalname = "TIPOPARCODIGO_"+sGXsfl_46_idx ;
            edtTipoParNombre_Internalname = "TIPOPARNOMBRE_"+sGXsfl_46_idx ;
            cmbTipoParAuxiliar_Internalname = "TIPOPARAUXILIAR_"+sGXsfl_46_idx ;
            cmbTipoParMayoriza_Internalname = "TIPOPARMAYORIZA_"+sGXsfl_46_idx ;
            cmbTipoParEstado_Internalname = "TIPOPARESTADO_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblocktipoparcodigo_Internalname = "TEXTBLOCKTIPOPARCODIGO" ;
         edtavCtipoparcodigo_Internalname = "vCTIPOPARCODIGO" ;
         lblTextblocktipoparnombre_Internalname = "TEXTBLOCKTIPOPARNOMBRE" ;
         edtavCtipoparnombre_Internalname = "vCTIPOPARNOMBRE" ;
         lblTextblocktipoparauxiliar_Internalname = "TEXTBLOCKTIPOPARAUXILIAR" ;
         cmbavCtipoparauxiliar_Internalname = "vCTIPOPARAUXILIAR" ;
         lblTextblocktipoparmayoriza_Internalname = "TEXTBLOCKTIPOPARMAYORIZA" ;
         cmbavCtipoparmayoriza_Internalname = "vCTIPOPARMAYORIZA" ;
         lblTextblocktipoparestado_Internalname = "TEXTBLOCKTIPOPARESTADO" ;
         cmbavCtipoparestado_Internalname = "vCTIPOPARESTADO" ;
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
         cmbTipoParEstado_Jsonclick = "" ;
         cmbTipoParMayoriza_Jsonclick = "" ;
         cmbTipoParAuxiliar_Jsonclick = "" ;
         edtTipoParNombre_Jsonclick = "" ;
         edtTipoParCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         cmbavCtipoparestado_Jsonclick = "" ;
         cmbavCtipoparmayoriza_Jsonclick = "" ;
         cmbavCtipoparauxiliar_Jsonclick = "" ;
         edtavCtipoparnombre_Jsonclick = "" ;
         edtavCtipoparcodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtTipoParNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Tipos de Partidas Contables" ;
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
         AV7cTipoParCodigo = "" ;
         AV8cTipoParNombre = "" ;
         AV12pClinicaCodigo = "" ;
         AV13pTipoParCodigo = "" ;
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
         edtTipoParNombre_Internalname = "" ;
         cmbTipoParAuxiliar_Internalname = "" ;
         cmbTipoParMayoriza_Internalname = "" ;
         cmbTipoParEstado_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A199TipoParCodigo = "" ;
         A200TipoParNombre = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cTipoParCodigo = "" ;
         lV8cTipoParNombre = "" ;
         H001W2_A203TipoParEstado = new short[1] ;
         H001W2_A202TipoParMayoriza = new short[1] ;
         H001W2_A201TipoParAuxiliar = new short[1] ;
         H001W2_A200TipoParNombre = new String[] {""} ;
         H001W2_A199TipoParCodigo = new String[] {""} ;
         H001W2_A41ClinicaCodigo = new String[] {""} ;
         H001W3_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char6 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblocktipoparcodigo_Jsonclick = "" ;
         lblTextblocktipoparnombre_Jsonclick = "" ;
         lblTextblocktipoparauxiliar_Jsonclick = "" ;
         lblTextblocktipoparmayoriza_Jsonclick = "" ;
         lblTextblocktipoparestado_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01f0__default(),
            new Object[][] {
                new Object[] {
               H001W2_A203TipoParEstado, H001W2_A202TipoParMayoriza, H001W2_A201TipoParAuxiliar, H001W2_A200TipoParNombre, H001W2_A199TipoParCodigo, H001W2_A41ClinicaCodigo
               }
               , new Object[] {
               H001W3_AGRID1_nRecordCount
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
      private short AV9cTipoParAuxiliar ;
      private short AV10cTipoParMayoriza ;
      private short AV11cTipoParEstado ;
      private short A201TipoParAuxiliar ;
      private short A202TipoParMayoriza ;
      private short A203TipoParEstado ;
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
      private int GRID1_nFirstRecordOnPage ;
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
      private String edtTipoParCodigo_Internalname ;
      private String edtTipoParNombre_Internalname ;
      private String cmbTipoParAuxiliar_Internalname ;
      private String cmbTipoParMayoriza_Internalname ;
      private String cmbTipoParEstado_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCtipoparcodigo_Internalname ;
      private String edtavCtipoparnombre_Internalname ;
      private String cmbavCtipoparauxiliar_Internalname ;
      private String cmbavCtipoparmayoriza_Internalname ;
      private String cmbavCtipoparestado_Internalname ;
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
      private String edtTipoParNombre_Link ;
      private String GXt_char6 ;
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
      private String lblTextblocktipoparnombre_Internalname ;
      private String lblTextblocktipoparnombre_Jsonclick ;
      private String edtavCtipoparnombre_Jsonclick ;
      private String lblTextblocktipoparauxiliar_Internalname ;
      private String lblTextblocktipoparauxiliar_Jsonclick ;
      private String cmbavCtipoparauxiliar_Jsonclick ;
      private String lblTextblocktipoparmayoriza_Internalname ;
      private String lblTextblocktipoparmayoriza_Jsonclick ;
      private String cmbavCtipoparmayoriza_Jsonclick ;
      private String lblTextblocktipoparestado_Internalname ;
      private String lblTextblocktipoparestado_Jsonclick ;
      private String cmbavCtipoparestado_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoParCodigo_Jsonclick ;
      private String edtTipoParNombre_Jsonclick ;
      private String cmbTipoParAuxiliar_Jsonclick ;
      private String cmbTipoParMayoriza_Jsonclick ;
      private String cmbTipoParEstado_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV7cTipoParCodigo ;
      private String AV8cTipoParNombre ;
      private String AV12pClinicaCodigo ;
      private String AV13pTipoParCodigo ;
      private String A41ClinicaCodigo ;
      private String A199TipoParCodigo ;
      private String A200TipoParNombre ;
      private String lV6cClinicaCodigo ;
      private String lV7cTipoParCodigo ;
      private String lV8cTipoParNombre ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCtipoparauxiliar ;
      private GXCombobox cmbavCtipoparmayoriza ;
      private GXCombobox cmbavCtipoparestado ;
      private GXCombobox cmbTipoParAuxiliar ;
      private GXCombobox cmbTipoParMayoriza ;
      private GXCombobox cmbTipoParEstado ;
      private IDataStoreProvider pr_default ;
      private short[] H001W2_A203TipoParEstado ;
      private short[] H001W2_A202TipoParMayoriza ;
      private short[] H001W2_A201TipoParAuxiliar ;
      private String[] H001W2_A200TipoParNombre ;
      private String[] H001W2_A199TipoParCodigo ;
      private String[] H001W2_A41ClinicaCodigo ;
      private int[] H001W3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pTipoParCodigo ;
      private GXWebForm Form ;
   }

   public class gx01f0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001W2 ;
          prmH001W2 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cTipoParNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV9cTipoParAuxiliar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cTipoParMayoriza",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV11cTipoParEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmH001W3 ;
          prmH001W3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cTipoParCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cTipoParNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV9cTipoParAuxiliar",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV10cTipoParMayoriza",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV11cTipoParEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001W2", "SELECT [TipoParEstado], [TipoParMayoriza], [TipoParAuxiliar], [TipoParNombre], [TipoParCodigo], [ClinicaCodigo] FROM [TipoPartida] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoParCodigo] like @lV7cTipoParCodigo) AND ([TipoParNombre] like @lV8cTipoParNombre) AND ([TipoParAuxiliar] >= @AV9cTipoParAuxiliar) AND ([TipoParMayoriza] >= @AV10cTipoParMayoriza) AND ([TipoParEstado] >= @AV11cTipoParEstado) ORDER BY [ClinicaCodigo], [TipoParCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W2,11,0,false,false )
             ,new CursorDef("H001W3", "SELECT COUNT(*) FROM [TipoPartida] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoParCodigo] like @lV7cTipoParCodigo) AND ([TipoParNombre] like @lV8cTipoParNombre) AND ([TipoParAuxiliar] >= @AV9cTipoParAuxiliar) AND ([TipoParMayoriza] >= @AV10cTipoParMayoriza) AND ([TipoParEstado] >= @AV11cTipoParEstado) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001W3,1,0,false,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
       }
    }

 }

}
