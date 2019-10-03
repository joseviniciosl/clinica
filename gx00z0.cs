/*
               File: Gx00Z0
        Description: Selection List Cuentas Bancarias
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:59.10
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
   public class gx00z0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00z0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00z0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out String aP1_pCuentaBancariaCodigo )
      {
         this.AV13pClinicaCodigo = "" ;
         this.AV14pCuentaBancariaCodigo = "" ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV13pClinicaCodigo;
         aP1_pCuentaBancariaCodigo=this.AV14pCuentaBancariaCodigo;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCcuentabancariatipo = new GXCombobox();
         cmbavCcuentabancariaestado = new GXCombobox();
         cmbCuentaBancariaTipo = new GXCombobox();
         cmbCuentaBancariaEstado = new GXCombobox();
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
               cmbavCcuentabancariatipo.Name = "vCCUENTABANCARIATIPO" ;
               cmbavCcuentabancariatipo.WebTags = "" ;
               cmbavCcuentabancariatipo.addItem("M", "Monetaria", 0);
               cmbavCcuentabancariatipo.addItem("A", "Ahorro", 0);
               if ( ( cmbavCcuentabancariatipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV9cCuentaBancariaTipo)) )
               {
                  AV9cCuentaBancariaTipo = cmbavCcuentabancariatipo.getItemValue(1) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
               }
               cmbavCcuentabancariaestado.Name = "vCCUENTABANCARIAESTADO" ;
               cmbavCcuentabancariaestado.WebTags = "" ;
               cmbavCcuentabancariaestado.addItem("0", "De baja", 0);
               cmbavCcuentabancariaestado.addItem("1", "Activo", 0);
               if ( ( cmbavCcuentabancariaestado.ItemCount > 0 ) && (0==AV11cCuentaBancariaEstado) )
               {
                  AV11cCuentaBancariaEstado = (short)(NumberUtil.Val( cmbavCcuentabancariaestado.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCuentaBancariaEstado", StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0));
               }
               GXCCtl = "CUENTABANCARIATIPO_" + sGXsfl_51_idx ;
               cmbCuentaBancariaTipo.Name = GXCCtl ;
               cmbCuentaBancariaTipo.WebTags = "" ;
               cmbCuentaBancariaTipo.addItem("M", "Monetaria", 0);
               cmbCuentaBancariaTipo.addItem("A", "Ahorro", 0);
               if ( ( cmbCuentaBancariaTipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A130CuentaBancariaTipo)) )
               {
                  A130CuentaBancariaTipo = cmbCuentaBancariaTipo.getItemValue(1) ;
               }
               GXCCtl = "CUENTABANCARIAESTADO_" + sGXsfl_51_idx ;
               cmbCuentaBancariaEstado.Name = GXCCtl ;
               cmbCuentaBancariaEstado.WebTags = "" ;
               cmbCuentaBancariaEstado.addItem("0", "De baja", 0);
               cmbCuentaBancariaEstado.addItem("1", "Activo", 0);
               if ( ( cmbCuentaBancariaEstado.ItemCount > 0 ) && (0==A131CuentaBancariaEstado) )
               {
                  A131CuentaBancariaEstado = (short)(NumberUtil.Val( cmbCuentaBancariaEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cCuentaBancariaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCuentaBancariaCodigo", AV7cCuentaBancariaCodigo);
               AV8cCuentaBancariaNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCuentaBancariaNombre", AV8cCuentaBancariaNombre);
               AV9cCuentaBancariaTipo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
               AV10cBancoCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBancoCodigo", AV10cBancoCodigo);
               AV11cCuentaBancariaEstado = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCuentaBancariaEstado", StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0));
               AV12cCuentaBancariaCuenta = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCuentaBancariaCuenta", AV12cCuentaBancariaCuenta);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cCuentaBancariaCodigo, AV8cCuentaBancariaNombre, AV9cCuentaBancariaTipo, AV10cBancoCodigo, AV11cCuentaBancariaEstado, AV12cCuentaBancariaCuenta) ;
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
                  AV14pCuentaBancariaCodigo = GetNextPar( ) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCuentaBancariaCodigo", AV14pCuentaBancariaCodigo);
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
         PA162( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START162( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00z0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pCuentaBancariaCodigo))+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUENTABANCARIACODIGO", StringUtil.RTrim( AV7cCuentaBancariaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUENTABANCARIANOMBRE", StringUtil.RTrim( AV8cCuentaBancariaNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUENTABANCARIATIPO", StringUtil.RTrim( AV9cCuentaBancariaTipo));
         GxWebStd.gx_hidden_field( context, "GXH_vCBANCOCODIGO", StringUtil.RTrim( AV10cBancoCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUENTABANCARIAESTADO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cCuentaBancariaEstado), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCUENTABANCARIACUENTA", StringUtil.RTrim( AV12cCuentaBancariaCuenta));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV13pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCUENTABANCARIACODIGO", StringUtil.RTrim( AV14pCuentaBancariaCodigo));
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
            WE162( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT162( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00Z0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Cuentas Bancarias" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00z0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode(StringUtil.RTrim(AV14pCuentaBancariaCodigo)) ;
      }

      protected void WB160( )
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
            wb_table1_2_162( true) ;
         }
         else
         {
            wb_table1_2_162( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_162e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START162( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Cuentas Bancarias", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP160( ) ;
      }

      protected void WS162( )
      {
         START162( ) ;
         EVT162( ) ;
      }

      protected void EVT162( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIACODIGO"), AV7cCuentaBancariaCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIANOMBRE"), AV8cCuentaBancariaNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIATIPO"), AV9cCuentaBancariaTipo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCOCODIGO"), AV10cBancoCodigo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCUENTABANCARIAESTADO"), ".", ",") != Convert.ToDecimal( AV11cCuentaBancariaEstado )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIACUENTA"), AV12cCuentaBancariaCuenta) != 0 )
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
                              edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
                              edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
                              cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
                              edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
                              cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A128CuentaBancariaCodigo = cgiGet( edtCuentaBancariaCodigo_Internalname) ;
                              A129CuentaBancariaNombre = cgiGet( edtCuentaBancariaNombre_Internalname) ;
                              cmbCuentaBancariaTipo.Name = cmbCuentaBancariaTipo_Internalname ;
                              cmbCuentaBancariaTipo.CurrentValue = cgiGet( cmbCuentaBancariaTipo_Internalname) ;
                              A130CuentaBancariaTipo = cgiGet( cmbCuentaBancariaTipo_Internalname) ;
                              A126BancoCodigo = cgiGet( edtBancoCodigo_Internalname) ;
                              cmbCuentaBancariaEstado.Name = cmbCuentaBancariaEstado_Internalname ;
                              cmbCuentaBancariaEstado.CurrentValue = cgiGet( cmbCuentaBancariaEstado_Internalname) ;
                              A131CuentaBancariaEstado = (short)(NumberUtil.Val( cgiGet( cmbCuentaBancariaEstado_Internalname), ".")) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E11162 */
                                    E11162 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E12162 */
                                    E12162 ();
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
                                       /* Set Refresh If Ccuentabancariacodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIACODIGO"), AV7cCuentaBancariaCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccuentabancarianombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIANOMBRE"), AV8cCuentaBancariaNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccuentabancariatipo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIATIPO"), AV9cCuentaBancariaTipo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cbancocodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCBANCOCODIGO"), AV10cBancoCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccuentabancariaestado Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCUENTABANCARIAESTADO"), ".", ",") != Convert.ToDecimal( AV11cCuentaBancariaEstado )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccuentabancariacuenta Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCUENTABANCARIACUENTA"), AV12cCuentaBancariaCuenta) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E13162 */
                                          E13162 ();
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

      protected void WE162( )
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

      protected void PA162( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCcuentabancariatipo.Name = "vCCUENTABANCARIATIPO" ;
            cmbavCcuentabancariatipo.WebTags = "" ;
            cmbavCcuentabancariatipo.addItem("M", "Monetaria", 0);
            cmbavCcuentabancariatipo.addItem("A", "Ahorro", 0);
            if ( ( cmbavCcuentabancariatipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV9cCuentaBancariaTipo)) )
            {
               AV9cCuentaBancariaTipo = cmbavCcuentabancariatipo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
            }
            cmbavCcuentabancariaestado.Name = "vCCUENTABANCARIAESTADO" ;
            cmbavCcuentabancariaestado.WebTags = "" ;
            cmbavCcuentabancariaestado.addItem("0", "De baja", 0);
            cmbavCcuentabancariaestado.addItem("1", "Activo", 0);
            if ( ( cmbavCcuentabancariaestado.ItemCount > 0 ) && (0==AV11cCuentaBancariaEstado) )
            {
               AV11cCuentaBancariaEstado = (short)(NumberUtil.Val( cmbavCcuentabancariaestado.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCuentaBancariaEstado", StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0));
            }
            GXCCtl = "CUENTABANCARIATIPO_" + sGXsfl_51_idx ;
            cmbCuentaBancariaTipo.Name = GXCCtl ;
            cmbCuentaBancariaTipo.WebTags = "" ;
            cmbCuentaBancariaTipo.addItem("M", "Monetaria", 0);
            cmbCuentaBancariaTipo.addItem("A", "Ahorro", 0);
            if ( ( cmbCuentaBancariaTipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A130CuentaBancariaTipo)) )
            {
               A130CuentaBancariaTipo = cmbCuentaBancariaTipo.getItemValue(1) ;
            }
            GXCCtl = "CUENTABANCARIAESTADO_" + sGXsfl_51_idx ;
            cmbCuentaBancariaEstado.Name = GXCCtl ;
            cmbCuentaBancariaEstado.WebTags = "" ;
            cmbCuentaBancariaEstado.addItem("0", "De baja", 0);
            cmbCuentaBancariaEstado.addItem("1", "Activo", 0);
            if ( ( cmbCuentaBancariaEstado.ItemCount > 0 ) && (0==A131CuentaBancariaEstado) )
            {
               A131CuentaBancariaEstado = (short)(NumberUtil.Val( cmbCuentaBancariaEstado.getItemValue(1), ".")) ;
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
         edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
         edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
         cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
         cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
            cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
            cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        String AV7cCuentaBancariaCodigo ,
                                        String AV8cCuentaBancariaNombre ,
                                        String AV9cCuentaBancariaTipo ,
                                        String AV10cBancoCodigo ,
                                        short AV11cCuentaBancariaEstado ,
                                        String AV12cCuentaBancariaCuenta )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF162( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF162( ) ;
         /* End function Refresh */
      }

      protected void RF162( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
         edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
         cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
         edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
         cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
            cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
            cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV7cCuentaBancariaCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cCuentaBancariaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCuentaBancariaCodigo", AV7cCuentaBancariaCodigo);
            lV8cCuentaBancariaNombre = StringUtil.PadR( StringUtil.RTrim( AV8cCuentaBancariaNombre), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCuentaBancariaNombre", AV8cCuentaBancariaNombre);
            lV9cCuentaBancariaTipo = StringUtil.PadR( StringUtil.RTrim( AV9cCuentaBancariaTipo), 1, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
            lV10cBancoCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cBancoCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBancoCodigo", AV10cBancoCodigo);
            lV12cCuentaBancariaCuenta = StringUtil.PadR( StringUtil.RTrim( AV12cCuentaBancariaCuenta), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCuentaBancariaCuenta", AV12cCuentaBancariaCuenta);
            /* Using cursor H00162 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, lV7cCuentaBancariaCodigo, lV8cCuentaBancariaNombre, lV9cCuentaBancariaTipo, lV10cBancoCodigo, AV11cCuentaBancariaEstado, lV12cCuentaBancariaCuenta});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A137CuentaBancariaCuenta = H00162_A137CuentaBancariaCuenta[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A137CuentaBancariaCuenta", A137CuentaBancariaCuenta);
               A131CuentaBancariaEstado = H00162_A131CuentaBancariaEstado[0] ;
               A126BancoCodigo = H00162_A126BancoCodigo[0] ;
               A130CuentaBancariaTipo = H00162_A130CuentaBancariaTipo[0] ;
               A129CuentaBancariaNombre = H00162_A129CuentaBancariaNombre[0] ;
               A128CuentaBancariaCodigo = H00162_A128CuentaBancariaCodigo[0] ;
               A41ClinicaCodigo = H00162_A41ClinicaCodigo[0] ;
               /* Execute user event: E12162 */
               E12162 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB160( ) ;
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
         lV7cCuentaBancariaCodigo = StringUtil.PadR( StringUtil.RTrim( AV7cCuentaBancariaCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCuentaBancariaCodigo", AV7cCuentaBancariaCodigo);
         lV8cCuentaBancariaNombre = StringUtil.PadR( StringUtil.RTrim( AV8cCuentaBancariaNombre), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCuentaBancariaNombre", AV8cCuentaBancariaNombre);
         lV9cCuentaBancariaTipo = StringUtil.PadR( StringUtil.RTrim( AV9cCuentaBancariaTipo), 1, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
         lV10cBancoCodigo = StringUtil.PadR( StringUtil.RTrim( AV10cBancoCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBancoCodigo", AV10cBancoCodigo);
         lV12cCuentaBancariaCuenta = StringUtil.PadR( StringUtil.RTrim( AV12cCuentaBancariaCuenta), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCuentaBancariaCuenta", AV12cCuentaBancariaCuenta);
         /* Using cursor H00163 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, lV7cCuentaBancariaCodigo, lV8cCuentaBancariaNombre, lV9cCuentaBancariaTipo, lV10cBancoCodigo, AV11cCuentaBancariaEstado, lV12cCuentaBancariaCuenta});
         GRID1_nRecordCount = H00163_AGRID1_nRecordCount[0] ;
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

      protected void STRUP160( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11162 */
         E11162 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            AV7cCuentaBancariaCodigo = cgiGet( edtavCcuentabancariacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCuentaBancariaCodigo", AV7cCuentaBancariaCodigo);
            AV8cCuentaBancariaNombre = cgiGet( edtavCcuentabancarianombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCuentaBancariaNombre", AV8cCuentaBancariaNombre);
            cmbavCcuentabancariatipo.Name = cmbavCcuentabancariatipo_Internalname ;
            cmbavCcuentabancariatipo.CurrentValue = cgiGet( cmbavCcuentabancariatipo_Internalname) ;
            AV9cCuentaBancariaTipo = cgiGet( cmbavCcuentabancariatipo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
            AV10cBancoCodigo = cgiGet( edtavCbancocodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBancoCodigo", AV10cBancoCodigo);
            cmbavCcuentabancariaestado.Name = cmbavCcuentabancariaestado_Internalname ;
            cmbavCcuentabancariaestado.CurrentValue = cgiGet( cmbavCcuentabancariaestado_Internalname) ;
            AV11cCuentaBancariaEstado = (short)(NumberUtil.Val( cgiGet( cmbavCcuentabancariaestado_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCuentaBancariaEstado", StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0));
            AV12cCuentaBancariaCuenta = cgiGet( edtavCcuentabancariacuenta_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCuentaBancariaCuenta", AV12cCuentaBancariaCuenta);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV14pCuentaBancariaCodigo = cgiGet( "vPCUENTABANCARIACODIGO") ;
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
         /* Execute user event: E11162 */
         E11162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E11162( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Cuentas Bancarias", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E12162( )
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
         /* Execute user event: E13162 */
         E13162 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E13162( )
      {
         /* Enter Routine */
         AV13pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pCuentaBancariaCodigo = A128CuentaBancariaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCuentaBancariaCodigo", AV14pCuentaBancariaCodigo);
         context.setWebReturnParms(new Object[] {(String)AV13pClinicaCodigo,(String)AV14pCuentaBancariaCodigo});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_162( bool wbgen )
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
            wb_table2_9_162( true) ;
         }
         else
         {
            wb_table2_9_162( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_162e( bool wbgen )
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
            wb_table3_48_162( true) ;
         }
         else
         {
            wb_table3_48_162( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_162e( true) ;
         }
         else
         {
            wb_table1_2_162e( false) ;
         }
      }

      protected void wb_table3_48_162( bool wbgen )
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
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Tipo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A128CuentaBancariaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A129CuentaBancariaNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtCuentaBancariaNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A130CuentaBancariaTipo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A126BancoCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A131CuentaBancariaEstado), 1, 0, ".", "")));
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
            wb_table4_61_162( true) ;
         }
         else
         {
            wb_table4_61_162( false) ;
         }
         return  ;
      }

      protected void wb_table4_61_162e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_162e( true) ;
         }
         else
         {
            wb_table3_48_162e( false) ;
         }
      }

      protected void wb_table4_61_162( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_61_162e( true) ;
         }
         else
         {
            wb_table4_61_162e( false) ;
         }
      }

      protected void wb_table2_9_162( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariacodigo_Internalname, "Código", "", "", lblTextblockcuentabancariacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cCuentaBancariaCodigo", AV7cCuentaBancariaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcuentabancariacodigo_Internalname, StringUtil.RTrim( AV7cCuentaBancariaCodigo), StringUtil.RTrim( context.localUtil.Format( AV7cCuentaBancariaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCcuentabancariacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancarianombre_Internalname, "Nombre", "", "", lblTextblockcuentabancarianombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cCuentaBancariaNombre", AV8cCuentaBancariaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcuentabancarianombre_Internalname, StringUtil.RTrim( AV8cCuentaBancariaNombre), StringUtil.RTrim( context.localUtil.Format( AV8cCuentaBancariaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(24);\"", "", "", "", "", edtavCcuentabancarianombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariatipo_Internalname, "Tipo", "", "", lblTextblockcuentabancariatipo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCuentaBancariaTipo", AV9cCuentaBancariaTipo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCcuentabancariatipo, cmbavCcuentabancariatipo_Internalname, AV9cCuentaBancariaTipo, 1, cmbavCcuentabancariatipo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", true, "HLP_Gx00Z0.htm");
            cmbavCcuentabancariatipo.CurrentValue = AV9cCuentaBancariaTipo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCcuentabancariatipo_Internalname, "Values", (String)(cmbavCcuentabancariatipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockbancocodigo_Internalname, "Código", "", "", lblTextblockbancocodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cBancoCodigo", AV10cBancoCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCbancocodigo_Internalname, StringUtil.RTrim( AV10cBancoCodigo), StringUtil.RTrim( context.localUtil.Format( AV10cBancoCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", "", "", "", edtavCbancocodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariaestado_Internalname, "Estado", "", "", lblTextblockcuentabancariaestado_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cCuentaBancariaEstado", StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCcuentabancariaestado, cmbavCcuentabancariaestado_Internalname, StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0), 1, cmbavCcuentabancariaestado_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", true, "HLP_Gx00Z0.htm");
            cmbavCcuentabancariaestado.CurrentValue = StringUtil.Str( (decimal)(AV11cCuentaBancariaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCcuentabancariaestado_Internalname, "Values", (String)(cmbavCcuentabancariaestado.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcuentabancariacuenta_Internalname, "No_Cuenta", "", "", lblTextblockcuentabancariacuenta_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cCuentaBancariaCuenta", AV12cCuentaBancariaCuenta);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcuentabancariacuenta_Internalname, StringUtil.RTrim( AV12cCuentaBancariaCuenta), StringUtil.RTrim( context.localUtil.Format( AV12cCuentaBancariaCuenta, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", "", "", "", "", edtavCcuentabancariacuenta_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00Z0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_162e( true) ;
         }
         else
         {
            wb_table2_9_162e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pCuentaBancariaCodigo = (String)getParm(obj,1) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pCuentaBancariaCodigo", AV14pCuentaBancariaCodigo);
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
         PA162( ) ;
         WS162( ) ;
         WE162( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1585976");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx00z0.js", "?1585976");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB160( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A128CuentaBancariaCodigo))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCuentaBancariaCodigo_Internalname,StringUtil.RTrim( A128CuentaBancariaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCuentaBancariaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtCuentaBancariaNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A128CuentaBancariaCodigo))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCuentaBancariaNombre_Internalname,StringUtil.RTrim( A129CuentaBancariaNombre),(String)"",(String)"",(String)"",(String)edtCuentaBancariaNombre_Link,(String)"",(String)"Seleccionar",(String)edtCuentaBancariaNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CUENTABANCARIATIPO_" + sGXsfl_51_idx ;
               cmbCuentaBancariaTipo.Name = GXCCtl ;
               cmbCuentaBancariaTipo.WebTags = "" ;
               cmbCuentaBancariaTipo.addItem("M", "Monetaria", 0);
               cmbCuentaBancariaTipo.addItem("A", "Ahorro", 0);
               if ( ( cmbCuentaBancariaTipo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A130CuentaBancariaTipo)) )
               {
                  A130CuentaBancariaTipo = cmbCuentaBancariaTipo.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCuentaBancariaTipo,(String)cmbCuentaBancariaTipo_Internalname,(String)A130CuentaBancariaTipo,(short)1,(String)cmbCuentaBancariaTipo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCuentaBancariaTipo.CurrentValue = A130CuentaBancariaTipo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaTipo_Internalname, "Values", (String)(cmbCuentaBancariaTipo.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtBancoCodigo_Internalname,StringUtil.RTrim( A126BancoCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtBancoCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CUENTABANCARIAESTADO_" + sGXsfl_51_idx ;
               cmbCuentaBancariaEstado.Name = GXCCtl ;
               cmbCuentaBancariaEstado.WebTags = "" ;
               cmbCuentaBancariaEstado.addItem("0", "De baja", 0);
               cmbCuentaBancariaEstado.addItem("1", "Activo", 0);
               if ( ( cmbCuentaBancariaEstado.ItemCount > 0 ) && (0==A131CuentaBancariaEstado) )
               {
                  A131CuentaBancariaEstado = (short)(NumberUtil.Val( cmbCuentaBancariaEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbCuentaBancariaEstado,(String)cmbCuentaBancariaEstado_Internalname,StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0),(short)1,(String)cmbCuentaBancariaEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbCuentaBancariaEstado.CurrentValue = StringUtil.Str( (decimal)(A131CuentaBancariaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbCuentaBancariaEstado_Internalname, "Values", (String)(cmbCuentaBancariaEstado.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaCodigo_Internalname = "CUENTABANCARIACODIGO_"+sGXsfl_51_idx ;
            edtCuentaBancariaNombre_Internalname = "CUENTABANCARIANOMBRE_"+sGXsfl_51_idx ;
            cmbCuentaBancariaTipo_Internalname = "CUENTABANCARIATIPO_"+sGXsfl_51_idx ;
            edtBancoCodigo_Internalname = "BANCOCODIGO_"+sGXsfl_51_idx ;
            cmbCuentaBancariaEstado_Internalname = "CUENTABANCARIAESTADO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockcuentabancariacodigo_Internalname = "TEXTBLOCKCUENTABANCARIACODIGO" ;
         edtavCcuentabancariacodigo_Internalname = "vCCUENTABANCARIACODIGO" ;
         lblTextblockcuentabancarianombre_Internalname = "TEXTBLOCKCUENTABANCARIANOMBRE" ;
         edtavCcuentabancarianombre_Internalname = "vCCUENTABANCARIANOMBRE" ;
         lblTextblockcuentabancariatipo_Internalname = "TEXTBLOCKCUENTABANCARIATIPO" ;
         cmbavCcuentabancariatipo_Internalname = "vCCUENTABANCARIATIPO" ;
         lblTextblockbancocodigo_Internalname = "TEXTBLOCKBANCOCODIGO" ;
         edtavCbancocodigo_Internalname = "vCBANCOCODIGO" ;
         lblTextblockcuentabancariaestado_Internalname = "TEXTBLOCKCUENTABANCARIAESTADO" ;
         cmbavCcuentabancariaestado_Internalname = "vCCUENTABANCARIAESTADO" ;
         lblTextblockcuentabancariacuenta_Internalname = "TEXTBLOCKCUENTABANCARIACUENTA" ;
         edtavCcuentabancariacuenta_Internalname = "vCCUENTABANCARIACUENTA" ;
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
         cmbCuentaBancariaEstado_Jsonclick = "" ;
         edtBancoCodigo_Jsonclick = "" ;
         cmbCuentaBancariaTipo_Jsonclick = "" ;
         edtCuentaBancariaNombre_Jsonclick = "" ;
         edtCuentaBancariaCodigo_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCcuentabancariacuenta_Jsonclick = "" ;
         cmbavCcuentabancariaestado_Jsonclick = "" ;
         edtavCbancocodigo_Jsonclick = "" ;
         cmbavCcuentabancariatipo_Jsonclick = "" ;
         edtavCcuentabancarianombre_Jsonclick = "" ;
         edtavCcuentabancariacodigo_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtCuentaBancariaNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Cuentas Bancarias" ;
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
         AV9cCuentaBancariaTipo = "" ;
         GXCCtl = "" ;
         A130CuentaBancariaTipo = "" ;
         AV6cClinicaCodigo = "" ;
         AV7cCuentaBancariaCodigo = "" ;
         AV8cCuentaBancariaNombre = "" ;
         AV10cBancoCodigo = "" ;
         AV12cCuentaBancariaCuenta = "" ;
         AV13pClinicaCodigo = "" ;
         AV14pCuentaBancariaCodigo = "" ;
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
         edtCuentaBancariaCodigo_Internalname = "" ;
         edtCuentaBancariaNombre_Internalname = "" ;
         cmbCuentaBancariaTipo_Internalname = "" ;
         edtBancoCodigo_Internalname = "" ;
         cmbCuentaBancariaEstado_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A128CuentaBancariaCodigo = "" ;
         A129CuentaBancariaNombre = "" ;
         A126BancoCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV7cCuentaBancariaCodigo = "" ;
         lV8cCuentaBancariaNombre = "" ;
         lV9cCuentaBancariaTipo = "" ;
         lV10cBancoCodigo = "" ;
         lV12cCuentaBancariaCuenta = "" ;
         H00162_A137CuentaBancariaCuenta = new String[] {""} ;
         H00162_A131CuentaBancariaEstado = new short[1] ;
         H00162_A126BancoCodigo = new String[] {""} ;
         H00162_A130CuentaBancariaTipo = new String[] {""} ;
         H00162_A129CuentaBancariaNombre = new String[] {""} ;
         H00162_A128CuentaBancariaCodigo = new String[] {""} ;
         H00162_A41ClinicaCodigo = new String[] {""} ;
         A137CuentaBancariaCuenta = "" ;
         H00163_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblockcuentabancariacodigo_Jsonclick = "" ;
         lblTextblockcuentabancarianombre_Jsonclick = "" ;
         lblTextblockcuentabancariatipo_Jsonclick = "" ;
         lblTextblockbancocodigo_Jsonclick = "" ;
         lblTextblockcuentabancariaestado_Jsonclick = "" ;
         lblTextblockcuentabancariacuenta_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char7 = "" ;
         ROClassString = "" ;
         GXt_char8 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00z0__default(),
            new Object[][] {
                new Object[] {
               H00162_A137CuentaBancariaCuenta, H00162_A131CuentaBancariaEstado, H00162_A126BancoCodigo, H00162_A130CuentaBancariaTipo, H00162_A129CuentaBancariaNombre, H00162_A128CuentaBancariaCodigo, H00162_A41ClinicaCodigo
               }
               , new Object[] {
               H00163_AGRID1_nRecordCount
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
      private short AV11cCuentaBancariaEstado ;
      private short A131CuentaBancariaEstado ;
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
      private String edtCuentaBancariaCodigo_Internalname ;
      private String edtCuentaBancariaNombre_Internalname ;
      private String cmbCuentaBancariaTipo_Internalname ;
      private String edtBancoCodigo_Internalname ;
      private String cmbCuentaBancariaEstado_Internalname ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String edtavCcuentabancariacodigo_Internalname ;
      private String edtavCcuentabancarianombre_Internalname ;
      private String cmbavCcuentabancariatipo_Internalname ;
      private String edtavCbancocodigo_Internalname ;
      private String cmbavCcuentabancariaestado_Internalname ;
      private String edtavCcuentabancariacuenta_Internalname ;
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
      private String edtCuentaBancariaNombre_Link ;
      private String GXt_char6 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockcuentabancariacodigo_Internalname ;
      private String lblTextblockcuentabancariacodigo_Jsonclick ;
      private String edtavCcuentabancariacodigo_Jsonclick ;
      private String lblTextblockcuentabancarianombre_Internalname ;
      private String lblTextblockcuentabancarianombre_Jsonclick ;
      private String edtavCcuentabancarianombre_Jsonclick ;
      private String lblTextblockcuentabancariatipo_Internalname ;
      private String lblTextblockcuentabancariatipo_Jsonclick ;
      private String cmbavCcuentabancariatipo_Jsonclick ;
      private String lblTextblockbancocodigo_Internalname ;
      private String lblTextblockbancocodigo_Jsonclick ;
      private String edtavCbancocodigo_Jsonclick ;
      private String lblTextblockcuentabancariaestado_Internalname ;
      private String lblTextblockcuentabancariaestado_Jsonclick ;
      private String cmbavCcuentabancariaestado_Jsonclick ;
      private String lblTextblockcuentabancariacuenta_Internalname ;
      private String lblTextblockcuentabancariacuenta_Jsonclick ;
      private String edtavCcuentabancariacuenta_Jsonclick ;
      private String GXt_char7 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtCuentaBancariaCodigo_Jsonclick ;
      private String edtCuentaBancariaNombre_Jsonclick ;
      private String cmbCuentaBancariaTipo_Jsonclick ;
      private String edtBancoCodigo_Jsonclick ;
      private String cmbCuentaBancariaEstado_Jsonclick ;
      private String GXt_char8 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV9cCuentaBancariaTipo ;
      private String A130CuentaBancariaTipo ;
      private String AV6cClinicaCodigo ;
      private String AV7cCuentaBancariaCodigo ;
      private String AV8cCuentaBancariaNombre ;
      private String AV10cBancoCodigo ;
      private String AV12cCuentaBancariaCuenta ;
      private String AV13pClinicaCodigo ;
      private String AV14pCuentaBancariaCodigo ;
      private String A41ClinicaCodigo ;
      private String A128CuentaBancariaCodigo ;
      private String A129CuentaBancariaNombre ;
      private String A126BancoCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV7cCuentaBancariaCodigo ;
      private String lV8cCuentaBancariaNombre ;
      private String lV9cCuentaBancariaTipo ;
      private String lV10cBancoCodigo ;
      private String lV12cCuentaBancariaCuenta ;
      private String A137CuentaBancariaCuenta ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCcuentabancariatipo ;
      private GXCombobox cmbavCcuentabancariaestado ;
      private GXCombobox cmbCuentaBancariaTipo ;
      private GXCombobox cmbCuentaBancariaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] H00162_A137CuentaBancariaCuenta ;
      private short[] H00162_A131CuentaBancariaEstado ;
      private String[] H00162_A126BancoCodigo ;
      private String[] H00162_A130CuentaBancariaTipo ;
      private String[] H00162_A129CuentaBancariaNombre ;
      private String[] H00162_A128CuentaBancariaCodigo ;
      private String[] H00162_A41ClinicaCodigo ;
      private int[] H00163_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private String aP1_pCuentaBancariaCodigo ;
      private GXWebForm Form ;
   }

   public class gx00z0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH00162 ;
          prmH00162 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cCuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cCuentaBancariaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV9cCuentaBancariaTipo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@lV10cBancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11cCuentaBancariaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV12cCuentaBancariaCuenta",SqlDbType.VarChar,70,0}
          } ;
          Object[] prmH00163 ;
          prmH00163 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7cCuentaBancariaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV8cCuentaBancariaNombre",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV9cCuentaBancariaTipo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@lV10cBancoCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV11cCuentaBancariaEstado",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV12cCuentaBancariaCuenta",SqlDbType.VarChar,70,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H00162", "SELECT [CuentaBancariaCuenta], [CuentaBancariaEstado], [BancoCodigo], [CuentaBancariaTipo], [CuentaBancariaNombre], [CuentaBancariaCodigo], [ClinicaCodigo] FROM [CuentaBancaria] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([CuentaBancariaCodigo] like @lV7cCuentaBancariaCodigo) AND ([CuentaBancariaNombre] like @lV8cCuentaBancariaNombre) AND ([CuentaBancariaTipo] like @lV9cCuentaBancariaTipo) AND ([BancoCodigo] like @lV10cBancoCodigo) AND ([CuentaBancariaEstado] >= @AV11cCuentaBancariaEstado) AND ([CuentaBancariaCuenta] like @lV12cCuentaBancariaCuenta) ORDER BY [ClinicaCodigo], [CuentaBancariaCodigo]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00162,11,0,false,false )
             ,new CursorDef("H00163", "SELECT COUNT(*) FROM [CuentaBancaria] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([CuentaBancariaCodigo] like @lV7cCuentaBancariaCodigo) AND ([CuentaBancariaNombre] like @lV8cCuentaBancariaNombre) AND ([CuentaBancariaTipo] like @lV9cCuentaBancariaTipo) AND ([BancoCodigo] like @lV10cBancoCodigo) AND ([CuentaBancariaEstado] >= @AV11cCuentaBancariaEstado) AND ([CuentaBancariaCuenta] like @lV12cCuentaBancariaCuenta) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH00163,1,0,false,false )
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
