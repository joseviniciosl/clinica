/*
               File: Gx0240
        Description: Selection List Tipo Vendedor
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:54.64
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
   public class gx0240 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx0240( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx0240( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out int aP1_pTipoVendedorId )
      {
         this.AV10pClinicaCodigo = "" ;
         this.AV11pTipoVendedorId = 0 ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV10pClinicaCodigo;
         aP1_pTipoVendedorId=this.AV11pTipoVendedorId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCtipovendedorestado = new GXCombobox();
         cmbavCtipovendedoresjefe = new GXCombobox();
         cmbTipoVendedorEstado = new GXCombobox();
         cmbTipoVendedorEsJefe = new GXCombobox();
         dynTipoVendedorId = new GXCombobox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"TIPOVENDEDORID") == 0 )
            {
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLATIPOVENDEDORID3J2( ) ;
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
               nGXsfl_36_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_36_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_36_idx, sGXsfl_36_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               cmbavCtipovendedorestado.Name = "vCTIPOVENDEDORESTADO" ;
               cmbavCtipovendedorestado.WebTags = "" ;
               cmbavCtipovendedorestado.addItem("0", "De baja", 0);
               cmbavCtipovendedorestado.addItem("1", "Activo", 0);
               if ( ( cmbavCtipovendedorestado.ItemCount > 0 ) && (0==AV9cTipoVendedorEstado) )
               {
                  AV9cTipoVendedorEstado = (short)(NumberUtil.Val( cmbavCtipovendedorestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoVendedorEstado", StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0));
               }
               cmbavCtipovendedoresjefe.Name = "vCTIPOVENDEDORESJEFE" ;
               cmbavCtipovendedoresjefe.WebTags = "" ;
               cmbavCtipovendedoresjefe.addItem("0", "No", 0);
               cmbavCtipovendedoresjefe.addItem("1", "Si", 0);
               if ( ( cmbavCtipovendedoresjefe.ItemCount > 0 ) && (0==AV12cTipoVendedorEsJefe) )
               {
                  AV12cTipoVendedorEsJefe = (short)(NumberUtil.Val( cmbavCtipovendedoresjefe.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoVendedorEsJefe", StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0));
               }
               GXCCtl = "TIPOVENDEDORESTADO_" + sGXsfl_36_idx ;
               cmbTipoVendedorEstado.Name = GXCCtl ;
               cmbTipoVendedorEstado.WebTags = "" ;
               cmbTipoVendedorEstado.addItem("0", "De baja", 0);
               cmbTipoVendedorEstado.addItem("1", "Activo", 0);
               if ( ( cmbTipoVendedorEstado.ItemCount > 0 ) && (0==A372TipoVendedorEstado) )
               {
                  A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.getItemValue(1), ".")) ;
               }
               GXCCtl = "TIPOVENDEDORESJEFE_" + sGXsfl_36_idx ;
               cmbTipoVendedorEsJefe.Name = GXCCtl ;
               cmbTipoVendedorEsJefe.WebTags = "" ;
               cmbTipoVendedorEsJefe.addItem("0", "No", 0);
               cmbTipoVendedorEsJefe.addItem("1", "Si", 0);
               if ( ( cmbTipoVendedorEsJefe.ItemCount > 0 ) && (0==A378TipoVendedorEsJefe) )
               {
                  A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.getItemValue(1), ".")) ;
               }
               GXCCtl = "TIPOVENDEDORID_" + sGXsfl_36_idx ;
               dynTipoVendedorId.Name = GXCCtl ;
               dynTipoVendedorId.WebTags = "" ;
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV8cTipoVendedorNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoVendedorNombre", AV8cTipoVendedorNombre);
               AV9cTipoVendedorEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoVendedorEstado", StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0));
               AV12cTipoVendedorEsJefe = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoVendedorEsJefe", StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV6cClinicaCodigo, AV8cTipoVendedorNombre, AV9cTipoVendedorEstado, AV12cTipoVendedorEsJefe) ;
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
               AV10pClinicaCodigo = gxfirstwebparm ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV11pTipoVendedorId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pTipoVendedorId), 9, 0)));
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
         PA3J2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3J2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx0240.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode("" +AV11pTipoVendedorId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOVENDEDORNOMBRE", StringUtil.RTrim( AV8cTipoVendedorNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOVENDEDORESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cTipoVendedorEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCTIPOVENDEDORESJEFE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12cTipoVendedorEsJefe), 1, 0, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV10pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPTIPOVENDEDORID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pTipoVendedorId), 9, 0, ".", "")));
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
            WE3J2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3J2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx0240" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Tipo Vendedor" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx0240.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV10pClinicaCodigo)) + "," + UrlEncode("" +AV11pTipoVendedorId) ;
      }

      protected void WB3J0( )
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
            wb_table1_2_3J2( true) ;
         }
         else
         {
            wb_table1_2_3J2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3J2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START3J2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Tipo Vendedor", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP3J0( ) ;
      }

      protected void WS3J2( )
      {
         START3J2( ) ;
         EVT3J2( ) ;
      }

      protected void EVT3J2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOVENDEDORNOMBRE"), AV8cTipoVendedorNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOVENDEDORESTADO"), ".", ",") != Convert.ToDecimal( AV9cTipoVendedorEstado )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOVENDEDORESJEFE"), ".", ",") != Convert.ToDecimal( AV12cTipoVendedorEsJefe )) )
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
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
                              edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
                              cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
                              cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
                              dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A371TipoVendedorNombre = cgiGet( edtTipoVendedorNombre_Internalname) ;
                              cmbTipoVendedorEstado.Name = cmbTipoVendedorEstado_Internalname ;
                              cmbTipoVendedorEstado.CurrentValue = cgiGet( cmbTipoVendedorEstado_Internalname) ;
                              A372TipoVendedorEstado = (short)(NumberUtil.Val( cgiGet( cmbTipoVendedorEstado_Internalname), ".")) ;
                              cmbTipoVendedorEsJefe.Name = cmbTipoVendedorEsJefe_Internalname ;
                              cmbTipoVendedorEsJefe.CurrentValue = cgiGet( cmbTipoVendedorEsJefe_Internalname) ;
                              A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cgiGet( cmbTipoVendedorEsJefe_Internalname), ".")) ;
                              dynTipoVendedorId.Name = dynTipoVendedorId_Internalname ;
                              dynTipoVendedorId.CurrentValue = cgiGet( dynTipoVendedorId_Internalname) ;
                              A370TipoVendedorId = (int)(NumberUtil.Val( cgiGet( dynTipoVendedorId_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E113J2 */
                                    E113J2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E123J2 */
                                    E123J2 ();
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
                                       /* Set Refresh If Ctipovendedornombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCTIPOVENDEDORNOMBRE"), AV8cTipoVendedorNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipovendedorestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOVENDEDORESTADO"), ".", ",") != Convert.ToDecimal( AV9cTipoVendedorEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ctipovendedoresjefe Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTIPOVENDEDORESJEFE"), ".", ",") != Convert.ToDecimal( AV12cTipoVendedorEsJefe )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E133J2 */
                                          E133J2 ();
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

      protected void WE3J2( )
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

      protected void PA3J2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCtipovendedorestado.Name = "vCTIPOVENDEDORESTADO" ;
            cmbavCtipovendedorestado.WebTags = "" ;
            cmbavCtipovendedorestado.addItem("0", "De baja", 0);
            cmbavCtipovendedorestado.addItem("1", "Activo", 0);
            if ( ( cmbavCtipovendedorestado.ItemCount > 0 ) && (0==AV9cTipoVendedorEstado) )
            {
               AV9cTipoVendedorEstado = (short)(NumberUtil.Val( cmbavCtipovendedorestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoVendedorEstado", StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0));
            }
            cmbavCtipovendedoresjefe.Name = "vCTIPOVENDEDORESJEFE" ;
            cmbavCtipovendedoresjefe.WebTags = "" ;
            cmbavCtipovendedoresjefe.addItem("0", "No", 0);
            cmbavCtipovendedoresjefe.addItem("1", "Si", 0);
            if ( ( cmbavCtipovendedoresjefe.ItemCount > 0 ) && (0==AV12cTipoVendedorEsJefe) )
            {
               AV12cTipoVendedorEsJefe = (short)(NumberUtil.Val( cmbavCtipovendedoresjefe.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoVendedorEsJefe", StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0));
            }
            GXCCtl = "TIPOVENDEDORESTADO_" + sGXsfl_36_idx ;
            cmbTipoVendedorEstado.Name = GXCCtl ;
            cmbTipoVendedorEstado.WebTags = "" ;
            cmbTipoVendedorEstado.addItem("0", "De baja", 0);
            cmbTipoVendedorEstado.addItem("1", "Activo", 0);
            if ( ( cmbTipoVendedorEstado.ItemCount > 0 ) && (0==A372TipoVendedorEstado) )
            {
               A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.getItemValue(1), ".")) ;
            }
            GXCCtl = "TIPOVENDEDORESJEFE_" + sGXsfl_36_idx ;
            cmbTipoVendedorEsJefe.Name = GXCCtl ;
            cmbTipoVendedorEsJefe.WebTags = "" ;
            cmbTipoVendedorEsJefe.addItem("0", "No", 0);
            cmbTipoVendedorEsJefe.addItem("1", "Si", 0);
            if ( ( cmbTipoVendedorEsJefe.ItemCount > 0 ) && (0==A378TipoVendedorEsJefe) )
            {
               A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.getItemValue(1), ".")) ;
            }
            GXCCtl = "TIPOVENDEDORID_" + sGXsfl_36_idx ;
            dynTipoVendedorId.Name = GXCCtl ;
            dynTipoVendedorId.WebTags = "" ;
            GX_FocusControl = edtavCclinicacodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLATIPOVENDEDORID3J2( )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLATIPOVENDEDORID_data3J2( ) ;
         gxdynajaxindex = 1 ;
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            context.GX_webresponse.AddString(gxwrpcisep+"{c:\""+GXUtil.EncodeJSConstant( gxdynajaxctrlcodr.Item(gxdynajaxindex))+"\",d:\""+GXUtil.EncodeJSConstant( gxdynajaxctrldescr.Item(gxdynajaxindex))+"\"}");
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
            gxwrpcisep = "," ;
         }
         context.GX_webresponse.AddString(")");
         if ( gxdynajaxctrlcodr.Count == 0 )
         {
            context.GX_webresponse.AddString(",101");
         }
         context.GX_webresponse.AddString("))");
      }

      protected void GXATIPOVENDEDORID_html3J2( )
      {
         int gxdynajaxvalue ;
         GXDLATIPOVENDEDORID_data3J2( ) ;
         gxdynajaxindex = 1 ;
         dynTipoVendedorId.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynTipoVendedorId.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
      }

      protected void GXDLATIPOVENDEDORID_data3J2( )
      {
         /* Using cursor H003J2 */
         pr_default.execute(0);
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H003J2_A370TipoVendedorId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H003J2_A371TipoVendedorNombre[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
         cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
         cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
         dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
            cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
            cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        String AV6cClinicaCodigo ,
                                        String AV8cTipoVendedorNombre ,
                                        short AV9cTipoVendedorEstado ,
                                        short AV12cTipoVendedorEsJefe )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF3J2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF3J2( ) ;
         /* End function Refresh */
      }

      protected void RF3J2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
         cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
         cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
         dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
            cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
            cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV8cTipoVendedorNombre = StringUtil.PadR( StringUtil.RTrim( AV8cTipoVendedorNombre), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoVendedorNombre", AV8cTipoVendedorNombre);
            /* Using cursor H003J3 */
            pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV8cTipoVendedorNombre, AV9cTipoVendedorEstado, AV12cTipoVendedorEsJefe});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(1) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A370TipoVendedorId = H003J3_A370TipoVendedorId[0] ;
               A378TipoVendedorEsJefe = H003J3_A378TipoVendedorEsJefe[0] ;
               A372TipoVendedorEstado = H003J3_A372TipoVendedorEstado[0] ;
               A371TipoVendedorNombre = H003J3_A371TipoVendedorNombre[0] ;
               A41ClinicaCodigo = H003J3_A41ClinicaCodigo[0] ;
               /* Execute user event: E123J2 */
               E123J2 ();
               pr_default.readNext(1);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(1) == 101) ? 1 : 0)) ;
            pr_default.close(1);
            wbEnd = 36 ;
            WB3J0( ) ;
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
         lV8cTipoVendedorNombre = StringUtil.PadR( StringUtil.RTrim( AV8cTipoVendedorNombre), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoVendedorNombre", AV8cTipoVendedorNombre);
         /* Using cursor H003J4 */
         pr_default.execute(2, new Object[] {lV6cClinicaCodigo, lV8cTipoVendedorNombre, AV9cTipoVendedorEstado, AV12cTipoVendedorEsJefe});
         GRID1_nRecordCount = H003J4_AGRID1_nRecordCount[0] ;
         pr_default.close(2);
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

      protected void STRUP3J0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         GXATIPOVENDEDORID_html3J2( ) ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E113J2 */
         E113J2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV8cTipoVendedorNombre = cgiGet( edtavCtipovendedornombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoVendedorNombre", AV8cTipoVendedorNombre);
            cmbavCtipovendedorestado.Name = cmbavCtipovendedorestado_Internalname ;
            cmbavCtipovendedorestado.CurrentValue = cgiGet( cmbavCtipovendedorestado_Internalname) ;
            AV9cTipoVendedorEstado = (short)(NumberUtil.Val( cgiGet( cmbavCtipovendedorestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoVendedorEstado", StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0));
            cmbavCtipovendedoresjefe.Name = cmbavCtipovendedoresjefe_Internalname ;
            cmbavCtipovendedoresjefe.CurrentValue = cgiGet( cmbavCtipovendedoresjefe_Internalname) ;
            AV12cTipoVendedorEsJefe = (short)(NumberUtil.Val( cgiGet( cmbavCtipovendedoresjefe_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoVendedorEsJefe", StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV10pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV11pTipoVendedorId = (int)(context.localUtil.CToN( cgiGet( "vPTIPOVENDEDORID"), ".", ",")) ;
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
         /* Execute user event: E113J2 */
         E113J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E113J2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Tipo Vendedor", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E123J2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Fantastic") ;
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E133J2 */
         E133J2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E133J2( )
      {
         /* Enter Routine */
         AV10pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
         AV11pTipoVendedorId = A370TipoVendedorId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pTipoVendedorId), 9, 0)));
         context.setWebReturnParms(new Object[] {(String)AV10pClinicaCodigo,(int)AV11pTipoVendedorId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_3J2( bool wbgen )
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
            wb_table2_9_3J2( true) ;
         }
         else
         {
            wb_table2_9_3J2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_3J2e( bool wbgen )
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
            wb_table3_33_3J2( true) ;
         }
         else
         {
            wb_table3_33_3J2( false) ;
         }
         return  ;
      }

      protected void wb_table3_33_3J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3J2e( true) ;
         }
         else
         {
            wb_table1_2_3J2e( false) ;
         }
      }

      protected void wb_table3_33_3J2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"36\">") ;
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
               context.SendWebValue( "Descripción") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Jefe?") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Tipo_Vendedor") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A371TipoVendedorNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtTipoVendedorNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A372TipoVendedorEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A378TipoVendedorEsJefe), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A370TipoVendedorId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 36 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_36_idx-1) ;
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
            wb_table4_45_3J2( true) ;
         }
         else
         {
            wb_table4_45_3J2( false) ;
         }
         return  ;
      }

      protected void wb_table4_45_3J2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_33_3J2e( true) ;
         }
         else
         {
            wb_table3_33_3J2e( false) ;
         }
      }

      protected void wb_table4_45_3J2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_45_3J2e( true) ;
         }
         else
         {
            wb_table4_45_3J2e( false) ;
         }
      }

      protected void wb_table2_9_3J2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedornombre_Internalname, "Descripción", "", "", lblTextblocktipovendedornombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTipoVendedorNombre", AV8cTipoVendedorNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCtipovendedornombre_Internalname, StringUtil.RTrim( AV8cTipoVendedorNombre), StringUtil.RTrim( context.localUtil.Format( AV8cTipoVendedorNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCtipovendedornombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedorestado_Internalname, "Estado", "", "", lblTextblocktipovendedorestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cTipoVendedorEstado", StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipovendedorestado, cmbavCtipovendedorestado_Internalname, StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0), 1, cmbavCtipovendedorestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", true, "HLP_Gx0240.htm");
            cmbavCtipovendedorestado.CurrentValue = StringUtil.Str( (decimal)(AV9cTipoVendedorEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCtipovendedorestado_Internalname, "Values", (String)(cmbavCtipovendedorestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocktipovendedoresjefe_Internalname, "Es_Jefe?", "", "", lblTextblocktipovendedoresjefe_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx0240.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cTipoVendedorEsJefe", StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCtipovendedoresjefe, cmbavCtipovendedoresjefe_Internalname, StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0), 1, cmbavCtipovendedoresjefe_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", true, "HLP_Gx0240.htm");
            cmbavCtipovendedoresjefe.CurrentValue = StringUtil.Str( (decimal)(AV12cTipoVendedorEsJefe), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCtipovendedoresjefe_Internalname, "Values", (String)(cmbavCtipovendedoresjefe.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_3J2e( true) ;
         }
         else
         {
            wb_table2_9_3J2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV10pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10pClinicaCodigo", AV10pClinicaCodigo);
         AV11pTipoVendedorId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pTipoVendedorId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pTipoVendedorId), 9, 0)));
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
         PA3J2( ) ;
         WS3J2( ) ;
         WE3J2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1595523");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx0240.js", "?1595523");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB3J0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_36_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_36_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A370TipoVendedorId), 9, 0, ".", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtTipoVendedorNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A370TipoVendedorId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTipoVendedorNombre_Internalname,StringUtil.RTrim( A371TipoVendedorNombre),(String)"",(String)"",(String)"",(String)edtTipoVendedorNombre_Link,(String)"",(String)"Seleccionar",(String)edtTipoVendedorNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_36_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOVENDEDORESTADO_" + sGXsfl_36_idx ;
               cmbTipoVendedorEstado.Name = GXCCtl ;
               cmbTipoVendedorEstado.WebTags = "" ;
               cmbTipoVendedorEstado.addItem("0", "De baja", 0);
               cmbTipoVendedorEstado.addItem("1", "Activo", 0);
               if ( ( cmbTipoVendedorEstado.ItemCount > 0 ) && (0==A372TipoVendedorEstado) )
               {
                  A372TipoVendedorEstado = (short)(NumberUtil.Val( cmbTipoVendedorEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTipoVendedorEstado,(String)cmbTipoVendedorEstado_Internalname,StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0),(short)1,(String)cmbTipoVendedorEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbTipoVendedorEstado.CurrentValue = StringUtil.Str( (decimal)(A372TipoVendedorEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEstado_Internalname, "Values", (String)(cmbTipoVendedorEstado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_36_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOVENDEDORESJEFE_" + sGXsfl_36_idx ;
               cmbTipoVendedorEsJefe.Name = GXCCtl ;
               cmbTipoVendedorEsJefe.WebTags = "" ;
               cmbTipoVendedorEsJefe.addItem("0", "No", 0);
               cmbTipoVendedorEsJefe.addItem("1", "Si", 0);
               if ( ( cmbTipoVendedorEsJefe.ItemCount > 0 ) && (0==A378TipoVendedorEsJefe) )
               {
                  A378TipoVendedorEsJefe = (short)(NumberUtil.Val( cmbTipoVendedorEsJefe.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbTipoVendedorEsJefe,(String)cmbTipoVendedorEsJefe_Internalname,StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0),(short)1,(String)cmbTipoVendedorEsJefe_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbTipoVendedorEsJefe.CurrentValue = StringUtil.Str( (decimal)(A378TipoVendedorEsJefe), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbTipoVendedorEsJefe_Internalname, "Values", (String)(cmbTipoVendedorEsJefe.ToJavascriptSource()));
            GXATIPOVENDEDORID_html3J2( ) ;
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_36_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "TIPOVENDEDORID_" + sGXsfl_36_idx ;
               dynTipoVendedorId.Name = GXCCtl ;
               dynTipoVendedorId.WebTags = "" ;
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)dynTipoVendedorId,(String)dynTipoVendedorId_Internalname,StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0),(short)1,(String)dynTipoVendedorId_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)0,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            dynTipoVendedorId.CurrentValue = StringUtil.Str( (decimal)(A370TipoVendedorId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynTipoVendedorId_Internalname, "Values", (String)(dynTipoVendedorId.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_36_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtTipoVendedorNombre_Internalname = "TIPOVENDEDORNOMBRE_"+sGXsfl_36_idx ;
            cmbTipoVendedorEstado_Internalname = "TIPOVENDEDORESTADO_"+sGXsfl_36_idx ;
            cmbTipoVendedorEsJefe_Internalname = "TIPOVENDEDORESJEFE_"+sGXsfl_36_idx ;
            dynTipoVendedorId_Internalname = "TIPOVENDEDORID_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblocktipovendedornombre_Internalname = "TEXTBLOCKTIPOVENDEDORNOMBRE" ;
         edtavCtipovendedornombre_Internalname = "vCTIPOVENDEDORNOMBRE" ;
         lblTextblocktipovendedorestado_Internalname = "TEXTBLOCKTIPOVENDEDORESTADO" ;
         cmbavCtipovendedorestado_Internalname = "vCTIPOVENDEDORESTADO" ;
         lblTextblocktipovendedoresjefe_Internalname = "TEXTBLOCKTIPOVENDEDORESJEFE" ;
         cmbavCtipovendedoresjefe_Internalname = "vCTIPOVENDEDORESJEFE" ;
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
         dynTipoVendedorId_Jsonclick = "" ;
         cmbTipoVendedorEsJefe_Jsonclick = "" ;
         cmbTipoVendedorEstado_Jsonclick = "" ;
         edtTipoVendedorNombre_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         cmbavCtipovendedoresjefe_Jsonclick = "" ;
         cmbavCtipovendedorestado_Jsonclick = "" ;
         edtavCtipovendedornombre_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtTipoVendedorNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Tipo Vendedor" ;
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
         AV8cTipoVendedorNombre = "" ;
         AV10pClinicaCodigo = "" ;
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
         edtTipoVendedorNombre_Internalname = "" ;
         cmbTipoVendedorEstado_Internalname = "" ;
         cmbTipoVendedorEsJefe_Internalname = "" ;
         dynTipoVendedorId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A371TipoVendedorNombre = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H003J2_A41ClinicaCodigo = new String[] {""} ;
         H003J2_A370TipoVendedorId = new int[1] ;
         H003J2_A371TipoVendedorNombre = new String[] {""} ;
         H003J2_A372TipoVendedorEstado = new short[1] ;
         Grid1Container = new GXWebGrid( context);
         lV6cClinicaCodigo = "" ;
         lV8cTipoVendedorNombre = "" ;
         H003J3_A370TipoVendedorId = new int[1] ;
         H003J3_A378TipoVendedorEsJefe = new short[1] ;
         H003J3_A372TipoVendedorEstado = new short[1] ;
         H003J3_A371TipoVendedorNombre = new String[] {""} ;
         H003J3_A41ClinicaCodigo = new String[] {""} ;
         H003J4_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char5 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblocktipovendedornombre_Jsonclick = "" ;
         lblTextblocktipovendedorestado_Jsonclick = "" ;
         lblTextblocktipovendedoresjefe_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char6 = "" ;
         ROClassString = "" ;
         GXt_char7 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx0240__default(),
            new Object[][] {
                new Object[] {
               H003J2_A41ClinicaCodigo, H003J2_A370TipoVendedorId, H003J2_A371TipoVendedorNombre, H003J2_A372TipoVendedorEstado
               }
               , new Object[] {
               H003J3_A370TipoVendedorId, H003J3_A378TipoVendedorEsJefe, H003J3_A372TipoVendedorEstado, H003J3_A371TipoVendedorNombre, H003J3_A41ClinicaCodigo
               }
               , new Object[] {
               H003J4_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_36_idx=1 ;
      private short AV9cTipoVendedorEstado ;
      private short AV12cTipoVendedorEsJefe ;
      private short A372TipoVendedorEstado ;
      private short A378TipoVendedorEsJefe ;
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
      private int Grid1_PageSize36 ;
      private int AV11pTipoVendedorId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A370TipoVendedorId ;
      private int gxdynajaxindex ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
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
      private String edtTipoVendedorNombre_Internalname ;
      private String cmbTipoVendedorEstado_Internalname ;
      private String cmbTipoVendedorEsJefe_Internalname ;
      private String dynTipoVendedorId_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavCtipovendedornombre_Internalname ;
      private String cmbavCtipovendedorestado_Internalname ;
      private String cmbavCtipovendedoresjefe_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtTipoVendedorNombre_Link ;
      private String GXt_char5 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblocktipovendedornombre_Internalname ;
      private String lblTextblocktipovendedornombre_Jsonclick ;
      private String edtavCtipovendedornombre_Jsonclick ;
      private String lblTextblocktipovendedorestado_Internalname ;
      private String lblTextblocktipovendedorestado_Jsonclick ;
      private String cmbavCtipovendedorestado_Jsonclick ;
      private String lblTextblocktipovendedoresjefe_Internalname ;
      private String lblTextblocktipovendedoresjefe_Jsonclick ;
      private String cmbavCtipovendedoresjefe_Jsonclick ;
      private String GXt_char6 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtTipoVendedorNombre_Jsonclick ;
      private String cmbTipoVendedorEstado_Jsonclick ;
      private String cmbTipoVendedorEsJefe_Jsonclick ;
      private String dynTipoVendedorId_Jsonclick ;
      private String GXt_char7 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV8cTipoVendedorNombre ;
      private String AV10pClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A371TipoVendedorNombre ;
      private String lV6cClinicaCodigo ;
      private String lV8cTipoVendedorNombre ;
      private String AV5LinkSelection ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCtipovendedorestado ;
      private GXCombobox cmbavCtipovendedoresjefe ;
      private GXCombobox cmbTipoVendedorEstado ;
      private GXCombobox cmbTipoVendedorEsJefe ;
      private GXCombobox dynTipoVendedorId ;
      private IDataStoreProvider pr_default ;
      private String[] H003J2_A41ClinicaCodigo ;
      private int[] H003J2_A370TipoVendedorId ;
      private String[] H003J2_A371TipoVendedorNombre ;
      private short[] H003J2_A372TipoVendedorEstado ;
      private int[] H003J3_A370TipoVendedorId ;
      private short[] H003J3_A378TipoVendedorEsJefe ;
      private short[] H003J3_A372TipoVendedorEstado ;
      private String[] H003J3_A371TipoVendedorNombre ;
      private String[] H003J3_A41ClinicaCodigo ;
      private int[] H003J4_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private int aP1_pTipoVendedorId ;
      private GXWebForm Form ;
   }

   public class gx0240__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003J2 ;
          prmH003J2 = new Object[] {
          } ;
          Object[] prmH003J3 ;
          prmH003J3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cTipoVendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV9cTipoVendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV12cTipoVendedorEsJefe",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmH003J4 ;
          prmH003J4 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cTipoVendedorNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV9cTipoVendedorEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV12cTipoVendedorEsJefe",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003J2", "SELECT [ClinicaCodigo], [TipoVendedorId], [TipoVendedorNombre], [TipoVendedorEstado] FROM [TipoVendedor] WITH (NOLOCK) WHERE [TipoVendedorEstado] = 1 ORDER BY [TipoVendedorNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003J2,0,0,true,false )
             ,new CursorDef("H003J3", "SELECT [TipoVendedorId], [TipoVendedorEsJefe], [TipoVendedorEstado], [TipoVendedorNombre], [ClinicaCodigo] FROM [TipoVendedor] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoVendedorNombre] like @lV8cTipoVendedorNombre) AND ([TipoVendedorEstado] >= @AV9cTipoVendedorEstado) AND ([TipoVendedorEsJefe] >= @AV12cTipoVendedorEsJefe) ORDER BY [ClinicaCodigo], [TipoVendedorId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003J3,11,0,true,false )
             ,new CursorDef("H003J4", "SELECT COUNT(*) FROM [TipoVendedor] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([TipoVendedorNombre] like @lV8cTipoVendedorNombre) AND ([TipoVendedorEstado] >= @AV9cTipoVendedorEstado) AND ([TipoVendedorEsJefe] >= @AV12cTipoVendedorEsJefe) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003J4,1,0,true,false )
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
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                break;
             case 2 :
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
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
