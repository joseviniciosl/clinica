/*
               File: Gx00P0
        Description: Selection List Consulta de pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:44.67
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
   public class gx00p0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00p0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public gx00p0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out String aP0_pClinicaCodigo ,
                           out int aP1_pConsultaId )
      {
         this.AV13pClinicaCodigo = "" ;
         this.AV14pConsultaId = 0 ;
         executePrivate();
         aP0_pClinicaCodigo=this.AV13pClinicaCodigo;
         aP1_pConsultaId=this.AV14pConsultaId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
         cmbavCconsultatipo = new GXCombobox();
         cmbConsultaTipo = new GXCombobox();
         cmbConsultaEstado = new GXCombobox();
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
               cmbavCconsultatipo.Name = "vCCONSULTATIPO" ;
               cmbavCconsultatipo.WebTags = "" ;
               cmbavCconsultatipo.addItem("1", "Consulta en clínica", 0);
               cmbavCconsultatipo.addItem("2", "Consulta telefónica", 0);
               cmbavCconsultatipo.addItem("3", "En hospital", 0);
               cmbavCconsultatipo.addItem("4", "A domicilio", 0);
               if ( ( cmbavCconsultatipo.ItemCount > 0 ) && (0==AV11cConsultaTipo) )
               {
                  AV11cConsultaTipo = (short)(NumberUtil.Val( cmbavCconsultatipo.getItemValue(1), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConsultaTipo", StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0));
               }
               GXCCtl = "CONSULTATIPO_" + sGXsfl_51_idx ;
               cmbConsultaTipo.Name = GXCCtl ;
               cmbConsultaTipo.WebTags = "" ;
               cmbConsultaTipo.addItem("1", "Consulta en clínica", 0);
               cmbConsultaTipo.addItem("2", "Consulta telefónica", 0);
               cmbConsultaTipo.addItem("3", "En hospital", 0);
               cmbConsultaTipo.addItem("4", "A domicilio", 0);
               if ( ( cmbConsultaTipo.ItemCount > 0 ) && (0==A94ConsultaTipo) )
               {
                  A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.getItemValue(1), ".")) ;
               }
               GXCCtl = "CONSULTAESTADO_" + sGXsfl_51_idx ;
               cmbConsultaEstado.Name = GXCCtl ;
               cmbConsultaEstado.WebTags = "" ;
               cmbConsultaEstado.addItem("1", "Creado", 0);
               cmbConsultaEstado.addItem("2", "Finalizado", 0);
               cmbConsultaEstado.addItem("3", "Facturado", 0);
               cmbConsultaEstado.addItem("4", "Cancelado", 0);
               if ( ( cmbConsultaEstado.ItemCount > 0 ) && (0==A159ConsultaEstado) )
               {
                  A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.getItemValue(1), ".")) ;
               }
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cClinicaCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
               AV7cConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConsultaId), 9, 0)));
               AV8cConsultaFecha = context.localUtil.ParseDateParm( GetNextPar( )) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cConsultaFecha", context.localUtil.Format(AV8cConsultaFecha, "99/99/99"));
               AV9cConsultaHora = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cConsultaHora", AV9cConsultaHora);
               AV10cPacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
               AV11cConsultaTipo = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConsultaTipo", StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0));
               AV12cAsegCodigo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegCodigo", AV12cAsegCodigo);
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cClinicaCodigo, AV7cConsultaId, AV8cConsultaFecha, AV9cConsultaHora, AV10cPacienteId, AV11cConsultaTipo, AV12cAsegCodigo) ;
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
                  AV14pConsultaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pConsultaId), 9, 0)));
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
         PA0V2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0V2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00p0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode("" +AV14pConsultaId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCLINICACODIGO", StringUtil.RTrim( AV6cClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONSULTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cConsultaId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONSULTAFECHA", context.localUtil.Format(AV8cConsultaFecha, "99/99/99"));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONSULTAHORA", StringUtil.RTrim( AV9cConsultaHora));
         GxWebStd.gx_hidden_field( context, "GXH_vCPACIENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPacienteId), 9, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCCONSULTATIPO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11cConsultaTipo), 1, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCASEGCODIGO", StringUtil.RTrim( AV12cAsegCodigo));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vPCLINICACODIGO", StringUtil.RTrim( AV13pClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "vPCONSULTAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14pConsultaId), 9, 0, ".", "")));
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
            WE0V2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0V2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00P0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Consulta de pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00p0.aspx") + "?" + UrlEncode(StringUtil.RTrim(AV13pClinicaCodigo)) + "," + UrlEncode("" +AV14pConsultaId) ;
      }

      protected void WB0V0( )
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
            wb_table1_2_0V2( true) ;
         }
         else
         {
            wb_table1_2_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0V2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0V2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Selection List Consulta de pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0V0( ) ;
      }

      protected void WS0V2( )
      {
         START0V2( ) ;
         EVT0V2( ) ;
      }

      protected void EVT0V2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONSULTAID"), ".", ",") != Convert.ToDecimal( AV7cConsultaId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( context.localUtil.CToD( cgiGet( "GXH_vCCONSULTAFECHA"), 2) != AV8cConsultaFecha )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCCONSULTAHORA"), AV9cConsultaHora) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPACIENTEID"), ".", ",") != Convert.ToDecimal( AV10cPacienteId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONSULTATIPO"), ".", ",") != Convert.ToDecimal( AV11cConsultaTipo )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCASEGCODIGO"), AV12cAsegCodigo) != 0 )
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
                              edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
                              edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
                              edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
                              edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
                              cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
                              edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
                              edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
                              edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
                              cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
                              edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
                              edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
                              edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A91ConsultaId = (int)(context.localUtil.CToN( cgiGet( edtConsultaId_Internalname), ".", ",")) ;
                              A92ConsultaFecha = context.localUtil.CToD( cgiGet( edtConsultaFecha_Internalname), 2) ;
                              A93ConsultaHora = cgiGet( edtConsultaHora_Internalname) ;
                              A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                              cmbConsultaTipo.Name = cmbConsultaTipo_Internalname ;
                              cmbConsultaTipo.CurrentValue = cgiGet( cmbConsultaTipo_Internalname) ;
                              A94ConsultaTipo = (short)(NumberUtil.Val( cgiGet( cmbConsultaTipo_Internalname), ".")) ;
                              A82AsegCodigo = cgiGet( edtAsegCodigo_Internalname) ;
                              n82AsegCodigo = false ;
                              A50Cie10Codigo = cgiGet( edtCie10Codigo_Internalname) ;
                              n50Cie10Codigo = false ;
                              A157ConsultaEdad = (short)(context.localUtil.CToN( cgiGet( edtConsultaEdad_Internalname), ".", ",")) ;
                              cmbConsultaEstado.Name = cmbConsultaEstado_Internalname ;
                              cmbConsultaEstado.CurrentValue = cgiGet( cmbConsultaEstado_Internalname) ;
                              A159ConsultaEstado = (short)(NumberUtil.Val( cgiGet( cmbConsultaEstado_Internalname), ".")) ;
                              A160ConsultaFechaFin = context.localUtil.CToD( cgiGet( edtConsultaFechaFin_Internalname), 2) ;
                              A161ConsultaHoraFin = cgiGet( edtConsultaHoraFin_Internalname) ;
                              A19MedicoCodigo = cgiGet( edtMedicoCodigo_Internalname) ;
                              n19MedicoCodigo = false ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110V2 */
                                    E110V2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120V2 */
                                    E120V2 ();
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
                                       /* Set Refresh If Cconsultaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONSULTAID"), ".", ",") != Convert.ToDecimal( AV7cConsultaId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cconsultafecha Changed */
                                       if ( context.localUtil.CToD( cgiGet( "GXH_vCCONSULTAFECHA"), 2) != AV8cConsultaFecha )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cconsultahora Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCCONSULTAHORA"), AV9cConsultaHora) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cpacienteid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPACIENTEID"), ".", ",") != Convert.ToDecimal( AV10cPacienteId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cconsultatipo Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCONSULTATIPO"), ".", ",") != Convert.ToDecimal( AV11cConsultaTipo )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casegcodigo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCASEGCODIGO"), AV12cAsegCodigo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130V2 */
                                          E130V2 ();
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

      protected void WE0V2( )
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

      protected void PA0V2( )
      {
         if ( nDonePA == 0 )
         {
            cmbavCconsultatipo.Name = "vCCONSULTATIPO" ;
            cmbavCconsultatipo.WebTags = "" ;
            cmbavCconsultatipo.addItem("1", "Consulta en clínica", 0);
            cmbavCconsultatipo.addItem("2", "Consulta telefónica", 0);
            cmbavCconsultatipo.addItem("3", "En hospital", 0);
            cmbavCconsultatipo.addItem("4", "A domicilio", 0);
            if ( ( cmbavCconsultatipo.ItemCount > 0 ) && (0==AV11cConsultaTipo) )
            {
               AV11cConsultaTipo = (short)(NumberUtil.Val( cmbavCconsultatipo.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConsultaTipo", StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0));
            }
            GXCCtl = "CONSULTATIPO_" + sGXsfl_51_idx ;
            cmbConsultaTipo.Name = GXCCtl ;
            cmbConsultaTipo.WebTags = "" ;
            cmbConsultaTipo.addItem("1", "Consulta en clínica", 0);
            cmbConsultaTipo.addItem("2", "Consulta telefónica", 0);
            cmbConsultaTipo.addItem("3", "En hospital", 0);
            cmbConsultaTipo.addItem("4", "A domicilio", 0);
            if ( ( cmbConsultaTipo.ItemCount > 0 ) && (0==A94ConsultaTipo) )
            {
               A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.getItemValue(1), ".")) ;
            }
            GXCCtl = "CONSULTAESTADO_" + sGXsfl_51_idx ;
            cmbConsultaEstado.Name = GXCCtl ;
            cmbConsultaEstado.WebTags = "" ;
            cmbConsultaEstado.addItem("1", "Creado", 0);
            cmbConsultaEstado.addItem("2", "Finalizado", 0);
            cmbConsultaEstado.addItem("3", "Facturado", 0);
            cmbConsultaEstado.addItem("4", "Cancelado", 0);
            if ( ( cmbConsultaEstado.ItemCount > 0 ) && (0==A159ConsultaEstado) )
            {
               A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.getItemValue(1), ".")) ;
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
         edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
         edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
         edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
         cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
         edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
         edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
         edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
         cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
         edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
         edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
            edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
            edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
            cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
            edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
            edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
            edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
            cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
            edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
            edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
            edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        String AV6cClinicaCodigo ,
                                        int AV7cConsultaId ,
                                        DateTime AV8cConsultaFecha ,
                                        String AV9cConsultaHora ,
                                        int AV10cPacienteId ,
                                        short AV11cConsultaTipo ,
                                        String AV12cAsegCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF0V2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0V2( ) ;
         /* End function Refresh */
      }

      protected void RF0V2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
         edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
         edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
         edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
         cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
         edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
         edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
         edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
         cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
         edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
         edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
         edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
            edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
            edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
            cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
            edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
            edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
            edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
            cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
            edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
            edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
            edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
            lV6cClinicaCodigo = StringUtil.PadR( StringUtil.RTrim( AV6cClinicaCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            lV9cConsultaHora = StringUtil.PadR( StringUtil.RTrim( AV9cConsultaHora), 8, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cConsultaHora", AV9cConsultaHora);
            lV12cAsegCodigo = StringUtil.PadR( StringUtil.RTrim( AV12cAsegCodigo), 10, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegCodigo", AV12cAsegCodigo);
            /* Using cursor H000V2 */
            pr_default.execute(0, new Object[] {lV6cClinicaCodigo, AV7cConsultaId, AV8cConsultaFecha, lV9cConsultaHora, AV10cPacienteId, AV11cConsultaTipo, lV12cAsegCodigo});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A19MedicoCodigo = H000V2_A19MedicoCodigo[0] ;
               n19MedicoCodigo = H000V2_n19MedicoCodigo[0] ;
               A161ConsultaHoraFin = H000V2_A161ConsultaHoraFin[0] ;
               A160ConsultaFechaFin = H000V2_A160ConsultaFechaFin[0] ;
               A159ConsultaEstado = H000V2_A159ConsultaEstado[0] ;
               A157ConsultaEdad = H000V2_A157ConsultaEdad[0] ;
               A50Cie10Codigo = H000V2_A50Cie10Codigo[0] ;
               n50Cie10Codigo = H000V2_n50Cie10Codigo[0] ;
               A82AsegCodigo = H000V2_A82AsegCodigo[0] ;
               n82AsegCodigo = H000V2_n82AsegCodigo[0] ;
               A94ConsultaTipo = H000V2_A94ConsultaTipo[0] ;
               A67PacienteId = H000V2_A67PacienteId[0] ;
               A93ConsultaHora = H000V2_A93ConsultaHora[0] ;
               A92ConsultaFecha = H000V2_A92ConsultaFecha[0] ;
               A91ConsultaId = H000V2_A91ConsultaId[0] ;
               A41ClinicaCodigo = H000V2_A41ClinicaCodigo[0] ;
               /* Execute user event: E120V2 */
               E120V2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB0V0( ) ;
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
         lV9cConsultaHora = StringUtil.PadR( StringUtil.RTrim( AV9cConsultaHora), 8, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cConsultaHora", AV9cConsultaHora);
         lV12cAsegCodigo = StringUtil.PadR( StringUtil.RTrim( AV12cAsegCodigo), 10, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegCodigo", AV12cAsegCodigo);
         /* Using cursor H000V3 */
         pr_default.execute(1, new Object[] {lV6cClinicaCodigo, AV7cConsultaId, AV8cConsultaFecha, lV9cConsultaHora, AV10cPacienteId, AV11cConsultaTipo, lV12cAsegCodigo});
         GRID1_nRecordCount = H000V3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP0V0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110V2 */
         E110V2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV6cClinicaCodigo = cgiGet( edtavCclinicacodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCconsultaid_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCconsultaid_Internalname), ".", ",") > Convert.ToDecimal( 999999999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vCCONSULTAID");
               GX_FocusControl = edtavCconsultaid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cConsultaId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConsultaId), 9, 0)));
            }
            else
            {
               AV7cConsultaId = (int)(context.localUtil.CToN( cgiGet( edtavCconsultaid_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConsultaId), 9, 0)));
            }
            if ( context.localUtil.VCDate( cgiGet( edtavCconsultafecha_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "vCCONSULTAFECHA");
               GX_FocusControl = edtavCconsultafecha_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cConsultaFecha = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cConsultaFecha", context.localUtil.Format(AV8cConsultaFecha, "99/99/99"));
            }
            else
            {
               AV8cConsultaFecha = context.localUtil.CToD( cgiGet( edtavCconsultafecha_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cConsultaFecha", context.localUtil.Format(AV8cConsultaFecha, "99/99/99"));
            }
            AV9cConsultaHora = cgiGet( edtavCconsultahora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cConsultaHora", AV9cConsultaHora);
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
            cmbavCconsultatipo.Name = cmbavCconsultatipo_Internalname ;
            cmbavCconsultatipo.CurrentValue = cgiGet( cmbavCconsultatipo_Internalname) ;
            AV11cConsultaTipo = (short)(NumberUtil.Val( cgiGet( cmbavCconsultatipo_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConsultaTipo", StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0));
            AV12cAsegCodigo = cgiGet( edtavCasegcodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegCodigo", AV12cAsegCodigo);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            AV13pClinicaCodigo = cgiGet( "vPCLINICACODIGO") ;
            AV14pConsultaId = (int)(context.localUtil.CToN( cgiGet( "vPCONSULTAID"), ".", ",")) ;
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
         /* Execute user event: E110V2 */
         E110V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110V2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Consulta de pacientes", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120V2( )
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
         /* Execute user event: E130V2 */
         E130V2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130V2( )
      {
         /* Enter Routine */
         AV13pClinicaCodigo = A41ClinicaCodigo ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pConsultaId = A91ConsultaId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pConsultaId), 9, 0)));
         context.setWebReturnParms(new Object[] {(String)AV13pClinicaCodigo,(int)AV14pConsultaId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0V2( bool wbgen )
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
            wb_table2_9_0V2( true) ;
         }
         else
         {
            wb_table2_9_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0V2e( bool wbgen )
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
            wb_table3_48_0V2( true) ;
         }
         else
         {
            wb_table3_48_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_0V2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0V2e( true) ;
         }
         else
         {
            wb_table1_2_0V2e( false) ;
         }
      }

      protected void wb_table3_48_0V2( bool wbgen )
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
               context.SendWebValue( "Consulta") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Consulta") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Aseguradora") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Edad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Estado") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Finaliza") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Finaliza") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A92ConsultaFecha, "99/99/99"));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtConsultaFecha_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A93ConsultaHora));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A94ConsultaTipo), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A82AsegCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A50Cie10Codigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A157ConsultaEdad), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A159ConsultaEstado), 1, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A161ConsultaHoraFin));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A19MedicoCodigo));
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
            wb_table4_68_0V2( true) ;
         }
         else
         {
            wb_table4_68_0V2( false) ;
         }
         return  ;
      }

      protected void wb_table4_68_0V2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_0V2e( true) ;
         }
         else
         {
            wb_table3_48_0V2e( false) ;
         }
      }

      protected void wb_table4_68_0V2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "standard", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_68_0V2e( true) ;
         }
         else
         {
            wb_table4_68_0V2e( false) ;
         }
      }

      protected void wb_table2_9_0V2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockclinicacodigo_Internalname, "Código", "", "", lblTextblockclinicacodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cClinicaCodigo", AV6cClinicaCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCclinicacodigo_Internalname, StringUtil.RTrim( AV6cClinicaCodigo), StringUtil.RTrim( context.localUtil.Format( AV6cClinicaCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(14);\"", "", "", "", "", edtavCclinicacodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultaid_Internalname, "Consulta", "", "", lblTextblockconsultaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cConsultaId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCconsultaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cConsultaId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7cConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7cConsultaId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCconsultaid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultafecha_Internalname, "Fecha", "", "", lblTextblockconsultafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cConsultaFecha", context.localUtil.Format(AV8cConsultaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavCconsultafecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavCconsultafecha_Internalname, context.localUtil.Format(AV8cConsultaFecha, "99/99/99"), context.localUtil.Format( AV8cConsultaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCconsultafecha_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            GxWebStd.gx_bitmap( context, edtavCconsultafecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_Gx00P0.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultahora_Internalname, "Hora", "", "", lblTextblockconsultahora_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cConsultaHora", AV9cConsultaHora);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCconsultahora_Internalname, StringUtil.RTrim( AV9cConsultaHora), StringUtil.RTrim( context.localUtil.Format( AV9cConsultaHora, "XXXXXXXX")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavCconsultahora_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpacienteid_Internalname, "Paciente", "", "", lblTextblockpacienteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cPacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cPacienteId), 9, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cPacienteId), 9, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV10cPacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV10cPacienteId), "ZZZZZZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavCpacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockconsultatipo_Internalname, "Tipo_Consulta", "", "", lblTextblockconsultatipo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cConsultaTipo", StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavCconsultatipo, cmbavCconsultatipo_Internalname, StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0), 1, cmbavCconsultatipo_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(39);\"", "", true, "HLP_Gx00P0.htm");
            cmbavCconsultatipo.CurrentValue = StringUtil.Str( (decimal)(AV11cConsultaTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavCconsultatipo_Internalname, "Values", (String)(cmbavCconsultatipo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasegcodigo_Internalname, "Aseguradora", "", "", lblTextblockasegcodigo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12cAsegCodigo", AV12cAsegCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasegcodigo_Internalname, StringUtil.RTrim( AV12cAsegCodigo), StringUtil.RTrim( context.localUtil.Format( AV12cAsegCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(44);\"", "", "", "", "", edtavCasegcodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00P0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0V2e( true) ;
         }
         else
         {
            wb_table2_9_0V2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV13pClinicaCodigo = (String)getParm(obj,0) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pClinicaCodigo", AV13pClinicaCodigo);
         AV14pConsultaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14pConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14pConsultaId), 9, 0)));
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
         PA0V2( ) ;
         WS0V2( ) ;
         WE0V2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1584561");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gx00p0.js", "?1584561");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB0V0( ) ;
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
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A91ConsultaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtConsultaFecha_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.RTrim( A41ClinicaCodigo))+"'"+", "+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A91ConsultaId), 9, 0, ".", "")))+"'"+"]);" ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaFecha_Internalname,context.localUtil.Format(A92ConsultaFecha, "99/99/99"),context.localUtil.Format( A92ConsultaFecha, "99/99/99"),(String)"",(String)"",(String)edtConsultaFecha_Link,(String)"",(String)"Seleccionar",(String)edtConsultaFecha_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaHora_Internalname,StringUtil.RTrim( A93ConsultaHora),StringUtil.RTrim( context.localUtil.Format( A93ConsultaHora, "XXXXXXXX")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaHora_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CONSULTATIPO_" + sGXsfl_51_idx ;
               cmbConsultaTipo.Name = GXCCtl ;
               cmbConsultaTipo.WebTags = "" ;
               cmbConsultaTipo.addItem("1", "Consulta en clínica", 0);
               cmbConsultaTipo.addItem("2", "Consulta telefónica", 0);
               cmbConsultaTipo.addItem("3", "En hospital", 0);
               cmbConsultaTipo.addItem("4", "A domicilio", 0);
               if ( ( cmbConsultaTipo.ItemCount > 0 ) && (0==A94ConsultaTipo) )
               {
                  A94ConsultaTipo = (short)(NumberUtil.Val( cmbConsultaTipo.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbConsultaTipo,(String)cmbConsultaTipo_Internalname,StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0),(short)1,(String)cmbConsultaTipo_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbConsultaTipo.CurrentValue = StringUtil.Str( (decimal)(A94ConsultaTipo), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaTipo_Internalname, "Values", (String)(cmbConsultaTipo.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsegCodigo_Internalname,StringUtil.RTrim( A82AsegCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtAsegCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCie10Codigo_Internalname,StringUtil.RTrim( A50Cie10Codigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCie10Codigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaEdad_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A157ConsultaEdad), 4, 0, ".", "")),context.localUtil.Format( (decimal)(A157ConsultaEdad), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaEdad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "" ;
            if ( ( nGXsfl_51_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "CONSULTAESTADO_" + sGXsfl_51_idx ;
               cmbConsultaEstado.Name = GXCCtl ;
               cmbConsultaEstado.WebTags = "" ;
               cmbConsultaEstado.addItem("1", "Creado", 0);
               cmbConsultaEstado.addItem("2", "Finalizado", 0);
               cmbConsultaEstado.addItem("3", "Facturado", 0);
               cmbConsultaEstado.addItem("4", "Cancelado", 0);
               if ( ( cmbConsultaEstado.ItemCount > 0 ) && (0==A159ConsultaEstado) )
               {
                  A159ConsultaEstado = (short)(NumberUtil.Val( cmbConsultaEstado.getItemValue(1), ".")) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbConsultaEstado,(String)cmbConsultaEstado_Internalname,StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0),(short)1,(String)cmbConsultaEstado_Jsonclick,(short)0,(String)"",(String)"int",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbConsultaEstado.CurrentValue = StringUtil.Str( (decimal)(A159ConsultaEstado), 1, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbConsultaEstado_Internalname, "Values", (String)(cmbConsultaEstado.ToJavascriptSource()));
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaFechaFin_Internalname,context.localUtil.Format(A160ConsultaFechaFin, "99/99/99"),context.localUtil.Format( A160ConsultaFechaFin, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaFechaFin_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtConsultaHoraFin_Internalname,StringUtil.RTrim( A161ConsultaHoraFin),StringUtil.RTrim( context.localUtil.Format( A161ConsultaHoraFin, "XXXXXXXX")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtConsultaHoraFin_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtMedicoCodigo_Internalname,StringUtil.RTrim( A19MedicoCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtMedicoCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_51_idx ;
            edtConsultaId_Internalname = "CONSULTAID_"+sGXsfl_51_idx ;
            edtConsultaFecha_Internalname = "CONSULTAFECHA_"+sGXsfl_51_idx ;
            edtConsultaHora_Internalname = "CONSULTAHORA_"+sGXsfl_51_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_51_idx ;
            cmbConsultaTipo_Internalname = "CONSULTATIPO_"+sGXsfl_51_idx ;
            edtAsegCodigo_Internalname = "ASEGCODIGO_"+sGXsfl_51_idx ;
            edtCie10Codigo_Internalname = "CIE10CODIGO_"+sGXsfl_51_idx ;
            edtConsultaEdad_Internalname = "CONSULTAEDAD_"+sGXsfl_51_idx ;
            cmbConsultaEstado_Internalname = "CONSULTAESTADO_"+sGXsfl_51_idx ;
            edtConsultaFechaFin_Internalname = "CONSULTAFECHAFIN_"+sGXsfl_51_idx ;
            edtConsultaHoraFin_Internalname = "CONSULTAHORAFIN_"+sGXsfl_51_idx ;
            edtMedicoCodigo_Internalname = "MEDICOCODIGO_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockclinicacodigo_Internalname = "TEXTBLOCKCLINICACODIGO" ;
         edtavCclinicacodigo_Internalname = "vCCLINICACODIGO" ;
         lblTextblockconsultaid_Internalname = "TEXTBLOCKCONSULTAID" ;
         edtavCconsultaid_Internalname = "vCCONSULTAID" ;
         lblTextblockconsultafecha_Internalname = "TEXTBLOCKCONSULTAFECHA" ;
         edtavCconsultafecha_Internalname = "vCCONSULTAFECHA" ;
         lblTextblockconsultahora_Internalname = "TEXTBLOCKCONSULTAHORA" ;
         edtavCconsultahora_Internalname = "vCCONSULTAHORA" ;
         lblTextblockpacienteid_Internalname = "TEXTBLOCKPACIENTEID" ;
         edtavCpacienteid_Internalname = "vCPACIENTEID" ;
         lblTextblockconsultatipo_Internalname = "TEXTBLOCKCONSULTATIPO" ;
         cmbavCconsultatipo_Internalname = "vCCONSULTATIPO" ;
         lblTextblockasegcodigo_Internalname = "TEXTBLOCKASEGCODIGO" ;
         edtavCasegcodigo_Internalname = "vCASEGCODIGO" ;
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
         edtMedicoCodigo_Jsonclick = "" ;
         edtConsultaHoraFin_Jsonclick = "" ;
         edtConsultaFechaFin_Jsonclick = "" ;
         cmbConsultaEstado_Jsonclick = "" ;
         edtConsultaEdad_Jsonclick = "" ;
         edtCie10Codigo_Jsonclick = "" ;
         edtAsegCodigo_Jsonclick = "" ;
         cmbConsultaTipo_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtConsultaHora_Jsonclick = "" ;
         edtConsultaFecha_Jsonclick = "" ;
         edtConsultaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavCasegcodigo_Jsonclick = "" ;
         cmbavCconsultatipo_Jsonclick = "" ;
         edtavCpacienteid_Jsonclick = "" ;
         edtavCconsultahora_Jsonclick = "" ;
         edtavCconsultafecha_Jsonclick = "" ;
         edtavCconsultaid_Jsonclick = "" ;
         edtavCclinicacodigo_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         edtConsultaFecha_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Consulta de pacientes" ;
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
         AV8cConsultaFecha = DateTime.MinValue ;
         AV9cConsultaHora = "" ;
         AV12cAsegCodigo = "" ;
         AV13pClinicaCodigo = "" ;
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
         edtConsultaId_Internalname = "" ;
         edtConsultaFecha_Internalname = "" ;
         edtConsultaHora_Internalname = "" ;
         edtPacienteId_Internalname = "" ;
         cmbConsultaTipo_Internalname = "" ;
         edtAsegCodigo_Internalname = "" ;
         edtCie10Codigo_Internalname = "" ;
         edtConsultaEdad_Internalname = "" ;
         cmbConsultaEstado_Internalname = "" ;
         edtConsultaFechaFin_Internalname = "" ;
         edtConsultaHoraFin_Internalname = "" ;
         edtMedicoCodigo_Internalname = "" ;
         AV5LinkSelection = "" ;
         A41ClinicaCodigo = "" ;
         A92ConsultaFecha = DateTime.MinValue ;
         A93ConsultaHora = "" ;
         A82AsegCodigo = "" ;
         A50Cie10Codigo = "" ;
         A160ConsultaFechaFin = DateTime.MinValue ;
         A161ConsultaHoraFin = "" ;
         A19MedicoCodigo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV6cClinicaCodigo = "" ;
         lV9cConsultaHora = "" ;
         lV12cAsegCodigo = "" ;
         H000V2_A19MedicoCodigo = new String[] {""} ;
         H000V2_n19MedicoCodigo = new bool[] {false} ;
         H000V2_A161ConsultaHoraFin = new String[] {""} ;
         H000V2_A160ConsultaFechaFin = new DateTime[] {DateTime.MinValue} ;
         H000V2_A159ConsultaEstado = new short[1] ;
         H000V2_A157ConsultaEdad = new short[1] ;
         H000V2_A50Cie10Codigo = new String[] {""} ;
         H000V2_n50Cie10Codigo = new bool[] {false} ;
         H000V2_A82AsegCodigo = new String[] {""} ;
         H000V2_n82AsegCodigo = new bool[] {false} ;
         H000V2_A94ConsultaTipo = new short[1] ;
         H000V2_A67PacienteId = new int[1] ;
         H000V2_A93ConsultaHora = new String[] {""} ;
         H000V2_A92ConsultaFecha = new DateTime[] {DateTime.MinValue} ;
         H000V2_A91ConsultaId = new int[1] ;
         H000V2_A41ClinicaCodigo = new String[] {""} ;
         H000V3_AGRID1_nRecordCount = new int[1] ;
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
         GXt_char9 = "" ;
         GXt_char10 = "" ;
         GXt_char11 = "" ;
         GXt_char12 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockclinicacodigo_Jsonclick = "" ;
         lblTextblockconsultaid_Jsonclick = "" ;
         lblTextblockconsultafecha_Jsonclick = "" ;
         GXt_char13 = "" ;
         lblTextblockconsultahora_Jsonclick = "" ;
         lblTextblockpacienteid_Jsonclick = "" ;
         lblTextblockconsultatipo_Jsonclick = "" ;
         lblTextblockasegcodigo_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char14 = "" ;
         ROClassString = "" ;
         GXt_char15 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00p0__default(),
            new Object[][] {
                new Object[] {
               H000V2_A19MedicoCodigo, H000V2_n19MedicoCodigo, H000V2_A161ConsultaHoraFin, H000V2_A160ConsultaFechaFin, H000V2_A159ConsultaEstado, H000V2_A157ConsultaEdad, H000V2_A50Cie10Codigo, H000V2_n50Cie10Codigo, H000V2_A82AsegCodigo, H000V2_n82AsegCodigo,
               H000V2_A94ConsultaTipo, H000V2_A67PacienteId, H000V2_A93ConsultaHora, H000V2_A92ConsultaFecha, H000V2_A91ConsultaId, H000V2_A41ClinicaCodigo
               }
               , new Object[] {
               H000V3_AGRID1_nRecordCount
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
      private short AV11cConsultaTipo ;
      private short A94ConsultaTipo ;
      private short A159ConsultaEstado ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A157ConsultaEdad ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
      private int AV7cConsultaId ;
      private int AV10cPacienteId ;
      private int AV14pConsultaId ;
      private int GRID1_nFirstRecordOnPage ;
      private int A91ConsultaId ;
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
      private String sGXsfl_51_idx="0001" ;
      private String GXCCtl ;
      private String AV9cConsultaHora ;
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
      private String edtConsultaId_Internalname ;
      private String edtConsultaFecha_Internalname ;
      private String edtConsultaHora_Internalname ;
      private String edtPacienteId_Internalname ;
      private String cmbConsultaTipo_Internalname ;
      private String edtAsegCodigo_Internalname ;
      private String edtCie10Codigo_Internalname ;
      private String edtConsultaEdad_Internalname ;
      private String cmbConsultaEstado_Internalname ;
      private String edtConsultaFechaFin_Internalname ;
      private String edtConsultaHoraFin_Internalname ;
      private String edtMedicoCodigo_Internalname ;
      private String A93ConsultaHora ;
      private String A161ConsultaHoraFin ;
      private String edtavCclinicacodigo_Internalname ;
      private String scmdbuf ;
      private String lV9cConsultaHora ;
      private String edtavCconsultaid_Internalname ;
      private String edtavCconsultafecha_Internalname ;
      private String edtavCconsultahora_Internalname ;
      private String edtavCpacienteid_Internalname ;
      private String cmbavCconsultatipo_Internalname ;
      private String edtavCasegcodigo_Internalname ;
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
      private String GXt_char9 ;
      private String GXt_char10 ;
      private String GXt_char11 ;
      private String GXt_char12 ;
      private String edtavLinkselection_Link ;
      private String edtConsultaFecha_Link ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockclinicacodigo_Internalname ;
      private String lblTextblockclinicacodigo_Jsonclick ;
      private String edtavCclinicacodigo_Jsonclick ;
      private String lblTextblockconsultaid_Internalname ;
      private String lblTextblockconsultaid_Jsonclick ;
      private String edtavCconsultaid_Jsonclick ;
      private String lblTextblockconsultafecha_Internalname ;
      private String lblTextblockconsultafecha_Jsonclick ;
      private String edtavCconsultafecha_Jsonclick ;
      private String GXt_char13 ;
      private String lblTextblockconsultahora_Internalname ;
      private String lblTextblockconsultahora_Jsonclick ;
      private String edtavCconsultahora_Jsonclick ;
      private String lblTextblockpacienteid_Internalname ;
      private String lblTextblockpacienteid_Jsonclick ;
      private String edtavCpacienteid_Jsonclick ;
      private String lblTextblockconsultatipo_Internalname ;
      private String lblTextblockconsultatipo_Jsonclick ;
      private String cmbavCconsultatipo_Jsonclick ;
      private String lblTextblockasegcodigo_Internalname ;
      private String lblTextblockasegcodigo_Jsonclick ;
      private String edtavCasegcodigo_Jsonclick ;
      private String GXt_char14 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtConsultaId_Jsonclick ;
      private String edtConsultaFecha_Jsonclick ;
      private String edtConsultaHora_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String cmbConsultaTipo_Jsonclick ;
      private String edtAsegCodigo_Jsonclick ;
      private String edtCie10Codigo_Jsonclick ;
      private String edtConsultaEdad_Jsonclick ;
      private String cmbConsultaEstado_Jsonclick ;
      private String edtConsultaFechaFin_Jsonclick ;
      private String edtConsultaHoraFin_Jsonclick ;
      private String edtMedicoCodigo_Jsonclick ;
      private String GXt_char15 ;
      private DateTime AV8cConsultaFecha ;
      private DateTime A92ConsultaFecha ;
      private DateTime A160ConsultaFechaFin ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool n82AsegCodigo ;
      private bool n50Cie10Codigo ;
      private bool n19MedicoCodigo ;
      private bool returnInSub ;
      private String AV6cClinicaCodigo ;
      private String AV12cAsegCodigo ;
      private String AV13pClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A82AsegCodigo ;
      private String A50Cie10Codigo ;
      private String A19MedicoCodigo ;
      private String lV6cClinicaCodigo ;
      private String lV12cAsegCodigo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavCconsultatipo ;
      private GXCombobox cmbConsultaTipo ;
      private GXCombobox cmbConsultaEstado ;
      private IDataStoreProvider pr_default ;
      private String[] H000V2_A19MedicoCodigo ;
      private bool[] H000V2_n19MedicoCodigo ;
      private String[] H000V2_A161ConsultaHoraFin ;
      private DateTime[] H000V2_A160ConsultaFechaFin ;
      private short[] H000V2_A159ConsultaEstado ;
      private short[] H000V2_A157ConsultaEdad ;
      private String[] H000V2_A50Cie10Codigo ;
      private bool[] H000V2_n50Cie10Codigo ;
      private String[] H000V2_A82AsegCodigo ;
      private bool[] H000V2_n82AsegCodigo ;
      private short[] H000V2_A94ConsultaTipo ;
      private int[] H000V2_A67PacienteId ;
      private String[] H000V2_A93ConsultaHora ;
      private DateTime[] H000V2_A92ConsultaFecha ;
      private int[] H000V2_A91ConsultaId ;
      private String[] H000V2_A41ClinicaCodigo ;
      private int[] H000V3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private String aP0_pClinicaCodigo ;
      private int aP1_pConsultaId ;
      private GXWebForm Form ;
   }

   public class gx00p0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000V2 ;
          prmH000V2 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV9cConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV10cPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11cConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV12cAsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH000V3 ;
          prmH000V3 = new Object[] {
          new Object[] {"@lV6cClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV7cConsultaId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV8cConsultaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@lV9cConsultaHora",SqlDbType.Char,8,0} ,
          new Object[] {"@AV10cPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV11cConsultaTipo",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@lV12cAsegCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000V2", "SELECT [MedicoCodigo], [ConsultaHoraFin], [ConsultaFechaFin], [ConsultaEstado], [ConsultaEdad], [Cie10Codigo], [AsegCodigo], [ConsultaTipo], [PacienteId], [ConsultaHora], [ConsultaFecha], [ConsultaId], [ClinicaCodigo] FROM [Consulta] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ConsultaId] >= @AV7cConsultaId) AND ([ConsultaFecha] >= @AV8cConsultaFecha) AND ([ConsultaHora] like @lV9cConsultaHora) AND ([PacienteId] >= @AV10cPacienteId) AND ([ConsultaTipo] >= @AV11cConsultaTipo) AND ([AsegCodigo] like @lV12cAsegCodigo) ORDER BY [ClinicaCodigo], [ConsultaId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V2,11,0,false,false )
             ,new CursorDef("H000V3", "SELECT COUNT(*) FROM [Consulta] WITH (NOLOCK) WHERE ([ClinicaCodigo] like @lV6cClinicaCodigo) AND ([ConsultaId] >= @AV7cConsultaId) AND ([ConsultaFecha] >= @AV8cConsultaFecha) AND ([ConsultaHora] like @lV9cConsultaHora) AND ([PacienteId] >= @AV10cPacienteId) AND ([ConsultaTipo] >= @AV11cConsultaTipo) AND ([AsegCodigo] like @lV12cAsegCodigo) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000V3,1,0,false,false )
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
                ((bool[]) buf[1])[0] = rslt.wasNull(1);
                ((String[]) buf[2])[0] = rslt.getString(2, 8) ;
                ((DateTime[]) buf[3])[0] = rslt.getGXDate(3) ;
                ((short[]) buf[4])[0] = rslt.getShort(4) ;
                ((short[]) buf[5])[0] = rslt.getShort(5) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(6) ;
                ((bool[]) buf[7])[0] = rslt.wasNull(6);
                ((String[]) buf[8])[0] = rslt.getVarchar(7) ;
                ((bool[]) buf[9])[0] = rslt.wasNull(7);
                ((short[]) buf[10])[0] = rslt.getShort(8) ;
                ((int[]) buf[11])[0] = rslt.getInt(9) ;
                ((String[]) buf[12])[0] = rslt.getString(10, 8) ;
                ((DateTime[]) buf[13])[0] = rslt.getGXDate(11) ;
                ((int[]) buf[14])[0] = rslt.getInt(12) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(13) ;
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
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (DateTime)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (int)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                break;
       }
    }

 }

}
