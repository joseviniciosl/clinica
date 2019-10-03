/*
               File: Gx01E1
        Description: Selection List Catálogo de Cuentas Contables
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:9:24.33
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
   public class gx01e1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx01e1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx01e1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( String aP0_pClinicaCodigo ,
                           out String aP1_pCtaContableCodigo )
      {
         this.AV12pClinicaCodigo = aP0_pClinicaCodigo;
         this.AV13pCtaContableCodigo = "" ;
         executePrivate();
         aP1_pCtaContableCodigo=this.AV13pCtaContableCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCctacontablenivel = new GXCombobox();
         cmbavCctacontablegrupo = new GXCombobox();
         cmbavCctacontablemanual = new GXCombobox();
         cmbavCctacontableestado = new GXCombobox();
         cmbCtaContableNivel = new GXCombobox();
         cmbCtaContableGrupo = new GXCombobox();
         cmbCtaContableManual = new GXCombobox();
         cmbCtaContableEstado = new GXCombobox();
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
               cmbavCctacontablenivel.Name = "vCCTACONTABLENIVEL" ;
               cmbavCctacontablenivel.WebTags = "" ;
               cmbavCctacontablenivel.addItem("1", "Nivel 1", 0);
               cmbavCctacontablenivel.addItem("2", "Nivel 2", 0);
               cmbavCctacontablenivel.addItem("3", "Nivel 3", 0);
               cmbavCctacontablenivel.addItem("4", "Nivel 4", 0);
               cmbavCctacontablenivel.addItem("5", "Nivel 5", 0);
               if ( ( cmbavCctacontablenivel.ItemCount > 0 ) && (0==AV8cCtaContableNivel) )
               {
                  AV8cCtaContableNivel = (short)(NumberUtil.Val( cmbavCctacontablenivel.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCtaContableNivel", StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0));
               }
               cmbavCctacontablegrupo.Name = "vCCTACONTABLEGRUPO" ;
               cmbavCctacontablegrupo.WebTags = "" ;
               cmbavCctacontablegrupo.addItem("Activo", "Activo", 0);
               cmbavCctacontablegrupo.addItem("Pasivo", "Pasivo", 0);
               cmbavCctacontablegrupo.addItem("Capital", "Capital", 0);
               cmbavCctacontablegrupo.addItem("Ingresos", "Ingresos", 0);
               cmbavCctacontablegrupo.addItem("Costos", "Costos", 0);
               cmbavCctacontablegrupo.addItem("Gastos", "Gastos", 0);
               cmbavCctacontablegrupo.addItem("PF", "Productos Financieros", 0);
               if ( ( cmbavCctacontablegrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV9cCtaContableGrupo)) )
               {
                  AV9cCtaContableGrupo = cmbavCctacontablegrupo.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
               }
               cmbavCctacontablemanual.Name = "vCCTACONTABLEMANUAL" ;
               cmbavCctacontablemanual.WebTags = "" ;
               cmbavCctacontablemanual.addItem("0", "No", 0);
               cmbavCctacontablemanual.addItem("1", "Si", 0);
               if ( ( cmbavCctacontablemanual.ItemCount > 0 ) && (0==AV10cCtaContableManual) )
               {
                  AV10cCtaContableManual = (short)(NumberUtil.Val( cmbavCctacontablemanual.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCtaContableManual", StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0));
               }
               cmbavCctacontableestado.Name = "vCCTACONTABLEESTADO" ;
               cmbavCctacontableestado.WebTags = "" ;
               cmbavCctacontableestado.addItem("0", "De baja", 0);
               cmbavCctacontableestado.addItem("1", "Activo", 0);
               if ( ( cmbavCctacontableestado.ItemCount > 0 ) && (0==AV11cCtaContableEstado) )
               {
                  AV11cCtaContableEstado = (short)(NumberUtil.Val( cmbavCctacontableestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCtaContableEstado", StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0));
               }
               GXCCtl = "CTACONTABLENIVEL_" + sGXsfl_46_idx ;
               cmbCtaContableNivel.Name = GXCCtl ;
               cmbCtaContableNivel.WebTags = "" ;
               cmbCtaContableNivel.addItem("1", "Nivel 1", 0);
               cmbCtaContableNivel.addItem("2", "Nivel 2", 0);
               cmbCtaContableNivel.addItem("3", "Nivel 3", 0);
               cmbCtaContableNivel.addItem("4", "Nivel 4", 0);
               cmbCtaContableNivel.addItem("5", "Nivel 5", 0);
               if ( ( cmbCtaContableNivel.ItemCount > 0 ) && (0==A195CtaContableNivel) )
               {
                  A195CtaContableNivel = (short)(NumberUtil.Val( cmbCtaContableNivel.getItemValue(1), ".")) ;
               }
               GXCCtl = "CTACONTABLEGRUPO_" + sGXsfl_46_idx ;
               cmbCtaContableGrupo.Name = GXCCtl ;
               cmbCtaContableGrupo.WebTags = "" ;
               cmbCtaContableGrupo.addItem("Activo", "Activo", 0);
               cmbCtaContableGrupo.addItem("Pasivo", "Pasivo", 0);
               cmbCtaContableGrupo.addItem("Capital", "Capital", 0);
               cmbCtaContableGrupo.addItem("Ingresos", "Ingresos", 0);
               cmbCtaContableGrupo.addItem("Costos", "Costos", 0);
               cmbCtaContableGrupo.addItem("Gastos", "Gastos", 0);
               cmbCtaContableGrupo.addItem("PF", "Productos Financieros", 0);
               if ( ( cmbCtaContableGrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A196CtaContableGrupo)) )
               {
                  A196CtaContableGrupo = cmbCtaContableGrupo.getItemValue(1) ;
               }
               GXCCtl = "CTACONTABLEMANUAL_" + sGXsfl_46_idx ;
               cmbCtaContableManual.Name = GXCCtl ;
               cmbCtaContableManual.WebTags = "" ;
               cmbCtaContableManual.addItem("0", "No", 0);
               cmbCtaContableManual.addItem("1", "Si", 0);
               if ( ( cmbCtaContableManual.ItemCount > 0 ) && (0==A197CtaContableManual) )
               {
                  A197CtaContableManual = (short)(NumberUtil.Val( cmbCtaContableManual.getItemValue(1), ".")) ;
               }
               GXCCtl = "CTACONTABLEESTADO_" + sGXsfl_46_idx ;
               cmbCtaContableEstado.Name = GXCCtl ;
               cmbCtaContableEstado.WebTags = "" ;
               cmbCtaContableEstado.addItem("0", "De baja", 0);
               cmbCtaContableEstado.addItem("1", "Activo", 0);
               if ( ( cmbCtaContableEstado.ItemCount > 0 ) && (0==A198CtaContableEstado) )
               {
                  A198CtaContableEstado = (short)(NumberUtil.Val( cmbCtaContableEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cCtaContableCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCtaContableCodigo", AV6cCtaContableCodigo);
               AV7cCtaContableNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCtaContableNombre", AV7cCtaContableNombre);
               AV8cCtaContableNivel = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCtaContableNivel", StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0));
               AV9cCtaContableGrupo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
               AV10cCtaContableManual = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCtaContableManual", StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0));
               AV11cCtaContableEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCtaContableEstado", StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0));
               AV12pClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cCtaContableCodigo, AV7cCtaContableNombre, AV8cCtaContableNivel, AV9cCtaContableGrupo, AV10cCtaContableManual, AV11cCtaContableEstado, AV12pClinicaCodigo) ;
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
                  AV13pCtaContableCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCtaContableCodigo", AV13pCtaContableCodigo);
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
         PA1Y2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1Y2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx01e1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pCtaContableCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLECODIGO", StringUtil.RTrim( AV6cCtaContableCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLENOMBRE", StringUtil.RTrim( AV7cCtaContableNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLENIVEL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cCtaContableNivel), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLEGRUPO", StringUtil.RTrim( AV9cCtaContableGrupo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLEMANUAL", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cCtaContableManual), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCTACONTABLEESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cCtaContableEstado), 1, 0, ".", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV12pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCTACONTABLECODIGO", StringUtil.RTrim( AV13pCtaContableCodigo));
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
            WE1Y2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1Y2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx01E1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Catálogo de Cuentas Contables" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx01e1.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV12pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV13pCtaContableCodigo)) ;
      }

      protected void WB1Y0( )
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
            wb_table1_2_1Y2( true) ;
         }
         else
         {
            wb_table1_2_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1Y2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1Y2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Catálogo de Cuentas Contables", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1Y0( ) ;
      }

      protected void WS1Y2( )
      {
         START1Y2( ) ;
         EVT1Y2( ) ;
      }

      protected void EVT1Y2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV6cCtaContableCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLENOMBRE"), AV7cCtaContableNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLENIVEL"), ".", ",") != Convert.ToDecimal( AV8cCtaContableNivel )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLEGRUPO"), AV9cCtaContableGrupo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLEMANUAL"), ".", ",") != Convert.ToDecimal( AV10cCtaContableManual )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLEESTADO"), ".", ",") != Convert.ToDecimal( AV11cCtaContableEstado )) )
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
                              edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
                              edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
                              cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
                              cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
                              cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
                              cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A193CtaContableCodigo = cgiGet( edtCtaContableCodigo_Internalname) ;
                              A194CtaContableNombre = cgiGet( edtCtaContableNombre_Internalname) ;
                              cmbCtaContableNivel.Name = cmbCtaContableNivel_Internalname ;
                              cmbCtaContableNivel.CurrentValue = cgiGet( cmbCtaContableNivel_Internalname) ;
                              A195CtaContableNivel = (short)(NumberUtil.Val( cgiGet( cmbCtaContableNivel_Internalname), ".")) ;
                              cmbCtaContableGrupo.Name = cmbCtaContableGrupo_Internalname ;
                              cmbCtaContableGrupo.CurrentValue = cgiGet( cmbCtaContableGrupo_Internalname) ;
                              A196CtaContableGrupo = cgiGet( cmbCtaContableGrupo_Internalname) ;
                              cmbCtaContableManual.Name = cmbCtaContableManual_Internalname ;
                              cmbCtaContableManual.CurrentValue = cgiGet( cmbCtaContableManual_Internalname) ;
                              A197CtaContableManual = (short)(NumberUtil.Val( cgiGet( cmbCtaContableManual_Internalname), ".")) ;
                              cmbCtaContableEstado.Name = cmbCtaContableEstado_Internalname ;
                              cmbCtaContableEstado.CurrentValue = cgiGet( cmbCtaContableEstado_Internalname) ;
                              A198CtaContableEstado = (short)(NumberUtil.Val( cgiGet( cmbCtaContableEstado_Internalname), ".")) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E111Y2 */
                                    E111Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E121Y2 */
                                    E121Y2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Cctacontablecodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLECODIGO"), AV6cCtaContableCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablenombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLENOMBRE"), AV7cCtaContableNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablenivel Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLENIVEL"), ".", ",") != Convert.ToDecimal( AV8cCtaContableNivel )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablegrupo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCTACONTABLEGRUPO"), AV9cCtaContableGrupo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontablemanual Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLEMANUAL"), ".", ",") != Convert.ToDecimal( AV10cCtaContableManual )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cctacontableestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCTACONTABLEESTADO"), ".", ",") != Convert.ToDecimal( AV11cCtaContableEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E131Y2 */
                                          E131Y2 ();
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

      protected void WE1Y2( )
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

      protected void PA1Y2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCctacontablenivel.Name = "vCCTACONTABLENIVEL" ;
            cmbavCctacontablenivel.WebTags = "" ;
            cmbavCctacontablenivel.addItem("1", "Nivel 1", 0);
            cmbavCctacontablenivel.addItem("2", "Nivel 2", 0);
            cmbavCctacontablenivel.addItem("3", "Nivel 3", 0);
            cmbavCctacontablenivel.addItem("4", "Nivel 4", 0);
            cmbavCctacontablenivel.addItem("5", "Nivel 5", 0);
            if ( ( cmbavCctacontablenivel.ItemCount > 0 ) && (0==AV8cCtaContableNivel) )
            {
               AV8cCtaContableNivel = (short)(NumberUtil.Val( cmbavCctacontablenivel.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCtaContableNivel", StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0));
            }
            cmbavCctacontablegrupo.Name = "vCCTACONTABLEGRUPO" ;
            cmbavCctacontablegrupo.WebTags = "" ;
            cmbavCctacontablegrupo.addItem("Activo", "Activo", 0);
            cmbavCctacontablegrupo.addItem("Pasivo", "Pasivo", 0);
            cmbavCctacontablegrupo.addItem("Capital", "Capital", 0);
            cmbavCctacontablegrupo.addItem("Ingresos", "Ingresos", 0);
            cmbavCctacontablegrupo.addItem("Costos", "Costos", 0);
            cmbavCctacontablegrupo.addItem("Gastos", "Gastos", 0);
            cmbavCctacontablegrupo.addItem("PF", "Productos Financieros", 0);
            if ( ( cmbavCctacontablegrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV9cCtaContableGrupo)) )
            {
               AV9cCtaContableGrupo = cmbavCctacontablegrupo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
            }
            cmbavCctacontablemanual.Name = "vCCTACONTABLEMANUAL" ;
            cmbavCctacontablemanual.WebTags = "" ;
            cmbavCctacontablemanual.addItem("0", "No", 0);
            cmbavCctacontablemanual.addItem("1", "Si", 0);
            if ( ( cmbavCctacontablemanual.ItemCount > 0 ) && (0==AV10cCtaContableManual) )
            {
               AV10cCtaContableManual = (short)(NumberUtil.Val( cmbavCctacontablemanual.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCtaContableManual", StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0));
            }
            cmbavCctacontableestado.Name = "vCCTACONTABLEESTADO" ;
            cmbavCctacontableestado.WebTags = "" ;
            cmbavCctacontableestado.addItem("0", "De baja", 0);
            cmbavCctacontableestado.addItem("1", "Activo", 0);
            if ( ( cmbavCctacontableestado.ItemCount > 0 ) && (0==AV11cCtaContableEstado) )
            {
               AV11cCtaContableEstado = (short)(NumberUtil.Val( cmbavCctacontableestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCtaContableEstado", StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0));
            }
            GXCCtl = "CTACONTABLENIVEL_" + sGXsfl_46_idx ;
            cmbCtaContableNivel.Name = GXCCtl ;
            cmbCtaContableNivel.WebTags = "" ;
            cmbCtaContableNivel.addItem("1", "Nivel 1", 0);
            cmbCtaContableNivel.addItem("2", "Nivel 2", 0);
            cmbCtaContableNivel.addItem("3", "Nivel 3", 0);
            cmbCtaContableNivel.addItem("4", "Nivel 4", 0);
            cmbCtaContableNivel.addItem("5", "Nivel 5", 0);
            if ( ( cmbCtaContableNivel.ItemCount > 0 ) && (0==A195CtaContableNivel) )
            {
               A195CtaContableNivel = (short)(NumberUtil.Val( cmbCtaContableNivel.getItemValue(1), ".")) ;
            }
            GXCCtl = "CTACONTABLEGRUPO_" + sGXsfl_46_idx ;
            cmbCtaContableGrupo.Name = GXCCtl ;
            cmbCtaContableGrupo.WebTags = "" ;
            cmbCtaContableGrupo.addItem("Activo", "Activo", 0);
            cmbCtaContableGrupo.addItem("Pasivo", "Pasivo", 0);
            cmbCtaContableGrupo.addItem("Capital", "Capital", 0);
            cmbCtaContableGrupo.addItem("Ingresos", "Ingresos", 0);
            cmbCtaContableGrupo.addItem("Costos", "Costos", 0);
            cmbCtaContableGrupo.addItem("Gastos", "Gastos", 0);
            cmbCtaContableGrupo.addItem("PF", "Productos Financieros", 0);
            if ( ( cmbCtaContableGrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A196CtaContableGrupo)) )
            {
               A196CtaContableGrupo = cmbCtaContableGrupo.getItemValue(1) ;
            }
            GXCCtl = "CTACONTABLEMANUAL_" + sGXsfl_46_idx ;
            cmbCtaContableManual.Name = GXCCtl ;
            cmbCtaContableManual.WebTags = "" ;
            cmbCtaContableManual.addItem("0", "No", 0);
            cmbCtaContableManual.addItem("1", "Si", 0);
            if ( ( cmbCtaContableManual.ItemCount > 0 ) && (0==A197CtaContableManual) )
            {
               A197CtaContableManual = (short)(NumberUtil.Val( cmbCtaContableManual.getItemValue(1), ".")) ;
            }
            GXCCtl = "CTACONTABLEESTADO_" + sGXsfl_46_idx ;
            cmbCtaContableEstado.Name = GXCCtl ;
            cmbCtaContableEstado.WebTags = "" ;
            cmbCtaContableEstado.addItem("0", "De baja", 0);
            cmbCtaContableEstado.addItem("1", "Activo", 0);
            if ( ( cmbCtaContableEstado.ItemCount > 0 ) && (0==A198CtaContableEstado) )
            {
               A198CtaContableEstado = (short)(NumberUtil.Val( cmbCtaContableEstado.getItemValue(1), ".")) ;
            }
            GX_FocusControl = edtavCctacontablecodigo_Internalname ;
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
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
         cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
         cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
         cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
         cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
            edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
            cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
            cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
            cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
            cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        String AV6cCtaContableCodigo ,
                                        String AV7cCtaContableNombre ,
                                        short AV8cCtaContableNivel ,
                                        String AV9cCtaContableGrupo ,
                                        short AV10cCtaContableManual ,
                                        short AV11cCtaContableEstado ,
                                        String AV12pClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF1Y2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1Y2( ) ;
         /* End function Refresh */
      }

      protected void RF1Y2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
         edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
         cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
         cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
         cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
         cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
            edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
            cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
            cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
            cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
            cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
            lV6cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cCtaContableCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCtaContableCodigo", AV6cCtaContableCodigo);
            lV7cCtaContableNombre = StringUtil.PadR( StringUtil.RTrim( AV7cCtaContableNombre), 80, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCtaContableNombre", AV7cCtaContableNombre);
            lV9cCtaContableGrupo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableGrupo), 15, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
            /* Using cursor H001Y2 */
            pr_default.execute(0, new Object[] {AV12pClinicaCodigo, lV6cCtaContableCodigo, lV7cCtaContableNombre, AV8cCtaContableNivel, lV9cCtaContableGrupo, AV10cCtaContableManual, AV11cCtaContableEstado});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A41ClinicaCodigo = H001Y2_A41ClinicaCodigo[0] ;
               A198CtaContableEstado = H001Y2_A198CtaContableEstado[0] ;
               A197CtaContableManual = H001Y2_A197CtaContableManual[0] ;
               A196CtaContableGrupo = H001Y2_A196CtaContableGrupo[0] ;
               A195CtaContableNivel = H001Y2_A195CtaContableNivel[0] ;
               A194CtaContableNombre = H001Y2_A194CtaContableNombre[0] ;
               A193CtaContableCodigo = H001Y2_A193CtaContableCodigo[0] ;
               /* Execute user event: E121Y2 */
               E121Y2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 46 ;
            WB1Y0( ) ;
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
         lV6cCtaContableCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cCtaContableCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCtaContableCodigo", AV6cCtaContableCodigo);
         lV7cCtaContableNombre = StringUtil.PadR( StringUtil.RTrim( AV7cCtaContableNombre), 80, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCtaContableNombre", AV7cCtaContableNombre);
         lV9cCtaContableGrupo = StringUtil.PadR( StringUtil.RTrim( AV9cCtaContableGrupo), 15, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
         /* Using cursor H001Y3 */
         pr_default.execute(1, new Object[] {AV12pClinicaCodigo, lV6cCtaContableCodigo, lV7cCtaContableNombre, AV8cCtaContableNivel, lV9cCtaContableGrupo, AV10cCtaContableManual, AV11cCtaContableEstado});
         GRID1_nRecordCount = H001Y3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP1Y0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E111Y2 */
         E111Y2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cCtaContableCodigo = cgiGet( edtavCctacontablecodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCtaContableCodigo", AV6cCtaContableCodigo);
            AV7cCtaContableNombre = cgiGet( edtavCctacontablenombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCtaContableNombre", AV7cCtaContableNombre);
            cmbavCctacontablenivel.Name = cmbavCctacontablenivel_Internalname ;
            cmbavCctacontablenivel.CurrentValue = cgiGet( cmbavCctacontablenivel_Internalname) ;
            AV8cCtaContableNivel = (short)(NumberUtil.Val( cgiGet( cmbavCctacontablenivel_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCtaContableNivel", StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0));
            cmbavCctacontablegrupo.Name = cmbavCctacontablegrupo_Internalname ;
            cmbavCctacontablegrupo.CurrentValue = cgiGet( cmbavCctacontablegrupo_Internalname) ;
            AV9cCtaContableGrupo = cgiGet( cmbavCctacontablegrupo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
            cmbavCctacontablemanual.Name = cmbavCctacontablemanual_Internalname ;
            cmbavCctacontablemanual.CurrentValue = cgiGet( cmbavCctacontablemanual_Internalname) ;
            AV10cCtaContableManual = (short)(NumberUtil.Val( cgiGet( cmbavCctacontablemanual_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCtaContableManual", StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0));
            cmbavCctacontableestado.Name = cmbavCctacontableestado_Internalname ;
            cmbavCctacontableestado.CurrentValue = cgiGet( cmbavCctacontableestado_Internalname) ;
            AV11cCtaContableEstado = (short)(NumberUtil.Val( cgiGet( cmbavCctacontableestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCtaContableEstado", StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0));
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV12pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV13pCtaContableCodigo = cgiGet( "vPCTACONTABLECODIGO") ;
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
         /* Execute user event: E111Y2 */
         E111Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E111Y2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Catálogo de Cuentas Contables", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E121Y2( )
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
         /* Execute user event: E131Y2 */
         E131Y2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E131Y2( )
      {
         /* Enter Routine */
         AV13pCtaContableCodigo = A193CtaContableCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCtaContableCodigo", AV13pCtaContableCodigo);
         context.setWebReturnParms(new Object[] {(String)AV13pCtaContableCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_1Y2( bool wbgen )
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
            wb_table2_9_1Y2( true) ;
         }
         else
         {
            wb_table2_9_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_1Y2e( bool wbgen )
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
            wb_table3_43_1Y2( true) ;
         }
         else
         {
            wb_table3_43_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_1Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1Y2e( true) ;
         }
         else
         {
            wb_table1_2_1Y2e( false) ;
         }
      }

      protected void wb_table3_43_1Y2( bool wbgen )
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
               context.SendWebValue( "Contable") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nivel") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Grupo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Manual") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A193CtaContableCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A194CtaContableNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtCtaContableNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A195CtaContableNivel), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A196CtaContableGrupo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A197CtaContableManual), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A198CtaContableEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
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
            wb_table4_57_1Y2( true) ;
         }
         else
         {
            wb_table4_57_1Y2( false) ;
         }
         return  ;
      }

      protected void wb_table4_57_1Y2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_1Y2e( true) ;
         }
         else
         {
            wb_table3_43_1Y2e( false) ;
         }
      }

      protected void wb_table4_57_1Y2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_57_1Y2e( true) ;
         }
         else
         {
            wb_table4_57_1Y2e( false) ;
         }
      }

      protected void wb_table2_9_1Y2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablecodigo_Internalname, "Cta_Contable", "", "", lblTextblockctacontablecodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCtaContableCodigo", AV6cCtaContableCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCctacontablecodigo_Internalname, StringUtil.RTrim( AV6cCtaContableCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cCtaContableCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCctacontablecodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablenombre_Internalname, "Nombre", "", "", lblTextblockctacontablenombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCtaContableNombre", AV7cCtaContableNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCctacontablenombre_Internalname, StringUtil.RTrim( AV7cCtaContableNombre), StringUtil.RTrim( context.localUtil.Format( AV7cCtaContableNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCctacontablenombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablenivel_Internalname, "Nivel", "", "", lblTextblockctacontablenivel_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCtaContableNivel", StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCctacontablenivel, cmbavCctacontablenivel_Internalname, StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0), 1, cmbavCctacontablenivel_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", true, "HLP_Gx01E1.htm");
            cmbavCctacontablenivel.CurrentValue = StringUtil.Str( (decimal)(AV8cCtaContableNivel), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCctacontablenivel_Internalname, "Values", (String)(cmbavCctacontablenivel.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablegrupo_Internalname, "Grupo", "", "", lblTextblockctacontablegrupo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCtaContableGrupo", AV9cCtaContableGrupo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCctacontablegrupo, cmbavCctacontablegrupo_Internalname, AV9cCtaContableGrupo, 1, cmbavCctacontablegrupo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 15, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", true, "HLP_Gx01E1.htm");
            cmbavCctacontablegrupo.CurrentValue = AV9cCtaContableGrupo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCctacontablegrupo_Internalname, "Values", (String)(cmbavCctacontablegrupo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontablemanual_Internalname, "Manual", "", "", lblTextblockctacontablemanual_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cCtaContableManual", StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCctacontablemanual, cmbavCctacontablemanual_Internalname, StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0), 1, cmbavCctacontablemanual_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", true, "HLP_Gx01E1.htm");
            cmbavCctacontablemanual.CurrentValue = StringUtil.Str( (decimal)(AV10cCtaContableManual), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCctacontablemanual_Internalname, "Values", (String)(cmbavCctacontablemanual.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockctacontableestado_Internalname, "Estado", "", "", lblTextblockctacontableestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx01E1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCtaContableEstado", StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCctacontableestado, cmbavCctacontableestado_Internalname, StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0), 1, cmbavCctacontableestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", true, "HLP_Gx01E1.htm");
            cmbavCctacontableestado.CurrentValue = StringUtil.Str( (decimal)(AV11cCtaContableEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCctacontableestado_Internalname, "Values", (String)(cmbavCctacontableestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_1Y2e( true) ;
         }
         else
         {
            wb_table2_9_1Y2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pClinicaCodigo", AV12pClinicaCodigo);
         AV13pCtaContableCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCtaContableCodigo", AV13pCtaContableCodigo);
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
         PA1Y2( ) ;
         WS1Y2( ) ;
         WE1Y2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?159255");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx01e1.js", "?159256");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB1Y0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A193CtaContableCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableCodigo_Internalname,StringUtil.RTrim( A193CtaContableCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCtaContableCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtCtaContableNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A193CtaContableCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCtaContableNombre_Internalname,StringUtil.RTrim( A194CtaContableNombre),(String)"",(String)"",(String)"",(String)edtCtaContableNombre_Link,(String)"",(String)"Seleccionar",(String)edtCtaContableNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)80,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CTACONTABLENIVEL_" + sGXsfl_46_idx ;
               cmbCtaContableNivel.Name = GXCCtl ;
               cmbCtaContableNivel.WebTags = "" ;
               cmbCtaContableNivel.addItem("1", "Nivel 1", 0);
               cmbCtaContableNivel.addItem("2", "Nivel 2", 0);
               cmbCtaContableNivel.addItem("3", "Nivel 3", 0);
               cmbCtaContableNivel.addItem("4", "Nivel 4", 0);
               cmbCtaContableNivel.addItem("5", "Nivel 5", 0);
               if ( ( cmbCtaContableNivel.ItemCount > 0 ) && (0==A195CtaContableNivel) )
               {
                  A195CtaContableNivel = (short)(NumberUtil.Val( cmbCtaContableNivel.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCtaContableNivel,(String)cmbCtaContableNivel_Internalname,StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0),(short)1,(String)cmbCtaContableNivel_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCtaContableNivel.CurrentValue = StringUtil.Str( (decimal)(A195CtaContableNivel), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableNivel_Internalname, "Values", (String)(cmbCtaContableNivel.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CTACONTABLEGRUPO_" + sGXsfl_46_idx ;
               cmbCtaContableGrupo.Name = GXCCtl ;
               cmbCtaContableGrupo.WebTags = "" ;
               cmbCtaContableGrupo.addItem("Activo", "Activo", 0);
               cmbCtaContableGrupo.addItem("Pasivo", "Pasivo", 0);
               cmbCtaContableGrupo.addItem("Capital", "Capital", 0);
               cmbCtaContableGrupo.addItem("Ingresos", "Ingresos", 0);
               cmbCtaContableGrupo.addItem("Costos", "Costos", 0);
               cmbCtaContableGrupo.addItem("Gastos", "Gastos", 0);
               cmbCtaContableGrupo.addItem("PF", "Productos Financieros", 0);
               if ( ( cmbCtaContableGrupo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A196CtaContableGrupo)) )
               {
                  A196CtaContableGrupo = cmbCtaContableGrupo.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCtaContableGrupo,(String)cmbCtaContableGrupo_Internalname,(String)A196CtaContableGrupo,(short)1,(String)cmbCtaContableGrupo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCtaContableGrupo.CurrentValue = A196CtaContableGrupo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableGrupo_Internalname, "Values", (String)(cmbCtaContableGrupo.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CTACONTABLEMANUAL_" + sGXsfl_46_idx ;
               cmbCtaContableManual.Name = GXCCtl ;
               cmbCtaContableManual.WebTags = "" ;
               cmbCtaContableManual.addItem("0", "No", 0);
               cmbCtaContableManual.addItem("1", "Si", 0);
               if ( ( cmbCtaContableManual.ItemCount > 0 ) && (0==A197CtaContableManual) )
               {
                  A197CtaContableManual = (short)(NumberUtil.Val( cmbCtaContableManual.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCtaContableManual,(String)cmbCtaContableManual_Internalname,StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0),(short)1,(String)cmbCtaContableManual_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCtaContableManual.CurrentValue = StringUtil.Str( (decimal)(A197CtaContableManual), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableManual_Internalname, "Values", (String)(cmbCtaContableManual.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_46_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CTACONTABLEESTADO_" + sGXsfl_46_idx ;
               cmbCtaContableEstado.Name = GXCCtl ;
               cmbCtaContableEstado.WebTags = "" ;
               cmbCtaContableEstado.addItem("0", "De baja", 0);
               cmbCtaContableEstado.addItem("1", "Activo", 0);
               if ( ( cmbCtaContableEstado.ItemCount > 0 ) && (0==A198CtaContableEstado) )
               {
                  A198CtaContableEstado = (short)(NumberUtil.Val( cmbCtaContableEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCtaContableEstado,(String)cmbCtaContableEstado_Internalname,StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0),(short)1,(String)cmbCtaContableEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCtaContableEstado.CurrentValue = StringUtil.Str( (decimal)(A198CtaContableEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCtaContableEstado_Internalname, "Values", (String)(cmbCtaContableEstado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCtaContableCodigo_Internalname = "CTACONTABLECODIGO_"+sGXsfl_46_idx ;
            edtCtaContableNombre_Internalname = "CTACONTABLENOMBRE_"+sGXsfl_46_idx ;
            cmbCtaContableNivel_Internalname = "CTACONTABLENIVEL_"+sGXsfl_46_idx ;
            cmbCtaContableGrupo_Internalname = "CTACONTABLEGRUPO_"+sGXsfl_46_idx ;
            cmbCtaContableManual_Internalname = "CTACONTABLEMANUAL_"+sGXsfl_46_idx ;
            cmbCtaContableEstado_Internalname = "CTACONTABLEESTADO_"+sGXsfl_46_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockctacontablecodigo_Internalname = "TEXTBLOCKCTACONTABLECODIGO" ;
         edtavCctacontablecodigo_Internalname = "vCCTACONTABLECODIGO" ;
         lblTextblockctacontablenombre_Internalname = "TEXTBLOCKCTACONTABLENOMBRE" ;
         edtavCctacontablenombre_Internalname = "vCCTACONTABLENOMBRE" ;
         lblTextblockctacontablenivel_Internalname = "TEXTBLOCKCTACONTABLENIVEL" ;
         cmbavCctacontablenivel_Internalname = "vCCTACONTABLENIVEL" ;
         lblTextblockctacontablegrupo_Internalname = "TEXTBLOCKCTACONTABLEGRUPO" ;
         cmbavCctacontablegrupo_Internalname = "vCCTACONTABLEGRUPO" ;
         lblTextblockctacontablemanual_Internalname = "TEXTBLOCKCTACONTABLEMANUAL" ;
         cmbavCctacontablemanual_Internalname = "vCCTACONTABLEMANUAL" ;
         lblTextblockctacontableestado_Internalname = "TEXTBLOCKCTACONTABLEESTADO" ;
         cmbavCctacontableestado_Internalname = "vCCTACONTABLEESTADO" ;
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
         edtClinicaCodigo_Jsonclick = "" ;
         cmbCtaContableEstado_Jsonclick = "" ;
         cmbCtaContableManual_Jsonclick = "" ;
         cmbCtaContableGrupo_Jsonclick = "" ;
         cmbCtaContableNivel_Jsonclick = "" ;
         edtCtaContableNombre_Jsonclick = "" ;
         edtCtaContableCodigo_Jsonclick = "" ;
         cmbavCctacontableestado_Jsonclick = "" ;
         cmbavCctacontablemanual_Jsonclick = "" ;
         cmbavCctacontablegrupo_Jsonclick = "" ;
         cmbavCctacontablenivel_Jsonclick = "" ;
         edtavCctacontablenombre_Jsonclick = "" ;
         edtavCctacontablecodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtCtaContableNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Catálogo de Cuentas Contables" ;
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
         wcpOAV12pClinicaCodigo = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV9cCtaContableGrupo = "" ;
         GXCCtl = "" ;
         A196CtaContableGrupo = "" ;
         AV6cCtaContableCodigo = "" ;
         AV7cCtaContableNombre = "" ;
         AV13pCtaContableCodigo = "" ;
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
         edtCtaContableCodigo_Internalname = "" ;
         edtCtaContableNombre_Internalname = "" ;
         cmbCtaContableNivel_Internalname = "" ;
         cmbCtaContableGrupo_Internalname = "" ;
         cmbCtaContableManual_Internalname = "" ;
         cmbCtaContableEstado_Internalname = "" ;
         edtClinicaCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A193CtaContableCodigo = "" ;
         A194CtaContableNombre = "" ;
         A41ClinicaCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cCtaContableCodigo = "" ;
         lV7cCtaContableNombre = "" ;
         lV9cCtaContableGrupo = "" ;
         H001Y2_A41ClinicaCodigo = new String[] {""} ;
         H001Y2_A198CtaContableEstado = new short[1] ;
         H001Y2_A197CtaContableManual = new short[1] ;
         H001Y2_A196CtaContableGrupo = new String[] {""} ;
         H001Y2_A195CtaContableNivel = new short[1] ;
         H001Y2_A194CtaContableNombre = new String[] {""} ;
         H001Y2_A193CtaContableCodigo = new String[] {""} ;
         H001Y3_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblockctacontablecodigo_Jsonclick = "" ;
         lblTextblockctacontablenombre_Jsonclick = "" ;
         lblTextblockctacontablenivel_Jsonclick = "" ;
         lblTextblockctacontablegrupo_Jsonclick = "" ;
         lblTextblockctacontablemanual_Jsonclick = "" ;
         lblTextblockctacontableestado_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx01e1__default(),
            new Object[][] {
                new Object[] {
               H001Y2_A41ClinicaCodigo, H001Y2_A198CtaContableEstado, H001Y2_A197CtaContableManual, H001Y2_A196CtaContableGrupo, H001Y2_A195CtaContableNivel, H001Y2_A194CtaContableNombre, H001Y2_A193CtaContableCodigo
               }
               , new Object[] {
               H001Y3_AGRID1_nRecordCount
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
      private short AV8cCtaContableNivel ;
      private short AV10cCtaContableManual ;
      private short AV11cCtaContableEstado ;
      private short A195CtaContableNivel ;
      private short A197CtaContableManual ;
      private short A198CtaContableEstado ;
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
      private String edtCtaContableCodigo_Internalname ;
      private String edtCtaContableNombre_Internalname ;
      private String cmbCtaContableNivel_Internalname ;
      private String cmbCtaContableGrupo_Internalname ;
      private String cmbCtaContableManual_Internalname ;
      private String cmbCtaContableEstado_Internalname ;
      private String edtClinicaCodigo_Internalname ;
      private String edtavCctacontablecodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCctacontablenombre_Internalname ;
      private String cmbavCctacontablenivel_Internalname ;
      private String cmbavCctacontablegrupo_Internalname ;
      private String cmbavCctacontablemanual_Internalname ;
      private String cmbavCctacontableestado_Internalname ;
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
      private String edtCtaContableNombre_Link ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockctacontablecodigo_Internalname ;
      private String lblTextblockctacontablecodigo_Jsonclick ;
      private String edtavCctacontablecodigo_Jsonclick ;
      private String lblTextblockctacontablenombre_Internalname ;
      private String lblTextblockctacontablenombre_Jsonclick ;
      private String edtavCctacontablenombre_Jsonclick ;
      private String lblTextblockctacontablenivel_Internalname ;
      private String lblTextblockctacontablenivel_Jsonclick ;
      private String cmbavCctacontablenivel_Jsonclick ;
      private String lblTextblockctacontablegrupo_Internalname ;
      private String lblTextblockctacontablegrupo_Jsonclick ;
      private String cmbavCctacontablegrupo_Jsonclick ;
      private String lblTextblockctacontablemanual_Internalname ;
      private String lblTextblockctacontablemanual_Jsonclick ;
      private String cmbavCctacontablemanual_Jsonclick ;
      private String lblTextblockctacontableestado_Internalname ;
      private String lblTextblockctacontableestado_Jsonclick ;
      private String cmbavCctacontableestado_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtCtaContableCodigo_Jsonclick ;
      private String edtCtaContableNombre_Jsonclick ;
      private String cmbCtaContableNivel_Jsonclick ;
      private String cmbCtaContableGrupo_Jsonclick ;
      private String cmbCtaContableManual_Jsonclick ;
      private String cmbCtaContableEstado_Jsonclick ;
      private String edtClinicaCodigo_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV12pClinicaCodigo ;
      private String wcpOAV12pClinicaCodigo ;
      private String AV9cCtaContableGrupo ;
      private String A196CtaContableGrupo ;
      private String AV6cCtaContableCodigo ;
      private String AV7cCtaContableNombre ;
      private String AV13pCtaContableCodigo ;
      private String A193CtaContableCodigo ;
      private String A194CtaContableNombre ;
      private String A41ClinicaCodigo ;
      private String lV6cCtaContableCodigo ;
      private String lV7cCtaContableNombre ;
      private String lV9cCtaContableGrupo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCctacontablenivel ;
      private GXCombobox cmbavCctacontablegrupo ;
      private GXCombobox cmbavCctacontablemanual ;
      private GXCombobox cmbavCctacontableestado ;
      private GXCombobox cmbCtaContableNivel ;
      private GXCombobox cmbCtaContableGrupo ;
      private GXCombobox cmbCtaContableManual ;
      private GXCombobox cmbCtaContableEstado ;
      private IDataStoreProvider pr_default ;
      private String[] H001Y2_A41ClinicaCodigo ;
      private short[] H001Y2_A198CtaContableEstado ;
      private short[] H001Y2_A197CtaContableManual ;
      private String[] H001Y2_A196CtaContableGrupo ;
      private short[] H001Y2_A195CtaContableNivel ;
      private String[] H001Y2_A194CtaContableNombre ;
      private String[] H001Y2_A193CtaContableCodigo ;
      private int[] H001Y3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP1_pCtaContableCodigo ;
      private GXWebForm Form ;
   }

   public class gx01e1__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001Y2 ;
          prmH001Y2 = new Object[] {
          new Object[] {"@AV12pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cCtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cCtaContableNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV8cCtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV9cCtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@AV10cCtaContableManual",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV11cCtaContableEstado",SqlDbType.SmallInt,1,0}
          } ;
          Object[] prmH001Y3 ;
          prmH001Y3 = new Object[] {
          new Object[] {"@AV12pClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV6cCtaContableCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cCtaContableNombre",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV8cCtaContableNivel",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV9cCtaContableGrupo",SqlDbType.VarChar,15,0} ,
          new Object[] {"@AV10cCtaContableManual",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV11cCtaContableEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001Y2", "SELECT [ClinicaCodigo], [CtaContableEstado], [CtaContableManual], [CtaContableGrupo], [CtaContableNivel], [CtaContableNombre], [CtaContableCodigo] FROM [CuentaContable] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV12pClinicaCodigo) AND ([CtaContableCodigo] like @lV6cCtaContableCodigo) AND ([CtaContableNombre] like @lV7cCtaContableNombre) AND ([CtaContableNivel] >= @AV8cCtaContableNivel) AND ([CtaContableGrupo] like @lV9cCtaContableGrupo) AND ([CtaContableManual] >= @AV10cCtaContableManual) AND ([CtaContableEstado] >= @AV11cCtaContableEstado) ORDER BY [ClinicaCodigo], [CtaContableCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y2,11,0,false,false )
             ,new CursorDef("H001Y3", "SELECT COUNT(*) FROM [CuentaContable] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV12pClinicaCodigo) AND ([CtaContableCodigo] like @lV6cCtaContableCodigo) AND ([CtaContableNombre] like @lV7cCtaContableNombre) AND ([CtaContableNivel] >= @AV8cCtaContableNivel) AND ([CtaContableGrupo] like @lV9cCtaContableGrupo) AND ([CtaContableManual] >= @AV10cCtaContableManual) AND ([CtaContableEstado] >= @AV11cCtaContableEstado) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001Y3,1,0,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
