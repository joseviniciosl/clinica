/*
               File: wp_paciente
        Description: Consulta de Pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:41.0
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
   public class wp_paciente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_paciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_paciente( IGxContext context )
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
         cmbPacienteSexo = new GXCombobox();
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
               GXCCtl = "PACIENTESEXO_" + sGXsfl_36_idx ;
               cmbPacienteSexo.Name = GXCCtl ;
               cmbPacienteSexo.WebTags = "" ;
               cmbPacienteSexo.addItem("M", "Masculino", 0);
               cmbPacienteSexo.addItem("F", "Femenino", 0);
               if ( ( cmbPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A326PacienteSexo)) )
               {
                  A326PacienteSexo = cmbPacienteSexo.getItemValue(1) ;
               }
               Grid1_PageSize36 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV7PacienteNombre1 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteNombre1", AV7PacienteNombre1);
               AV8PacienteNombre2 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteNombre2", AV8PacienteNombre2);
               AV9PacienteApellido1 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteApellido1", AV9PacienteApellido1);
               AV10PacienteApellido2 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteApellido2", AV10PacienteApellido2);
               AV11PacienteApellido3 = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteApellido3", AV11PacienteApellido3);
               AV6ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize36, AV7PacienteNombre1, AV8PacienteNombre2, AV9PacienteApellido1, AV10PacienteApellido2, AV11PacienteApellido3, AV6ClinicaCodigo) ;
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
         PA1E2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START1E2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_paciente.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vPACIENTENOMBRE1", StringUtil.RTrim( AV7PacienteNombre1));
         GxWebStd.gx_hidden_field( context, "GXH_vPACIENTENOMBRE2", StringUtil.RTrim( AV8PacienteNombre2));
         GxWebStd.gx_hidden_field( context, "GXH_vPACIENTEAPELLIDO1", StringUtil.RTrim( AV9PacienteApellido1));
         GxWebStd.gx_hidden_field( context, "GXH_vPACIENTEAPELLIDO2", StringUtil.RTrim( AV10PacienteApellido2));
         GxWebStd.gx_hidden_field( context, "GXH_vPACIENTEAPELLIDO3", StringUtil.RTrim( AV11PacienteApellido3));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV6ClinicaCodigo));
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
            WE1E2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT1E2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_paciente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Consulta de Pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_paciente.aspx")  ;
      }

      protected void WB1E0( )
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
            wb_table1_2_1E2( true) ;
         }
         else
         {
            wb_table1_2_1E2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_1E2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START1E2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Consulta de Pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP1E0( ) ;
      }

      protected void WS1E2( )
      {
         START1E2( ) ;
         EVT1E2( ) ;
      }

      protected void EVT1E2( )
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
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTENOMBRE1"), AV7PacienteNombre1) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTENOMBRE2"), AV8PacienteNombre2) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO1"), AV9PacienteApellido1) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO2"), AV10PacienteApellido2) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO3"), AV11PacienteApellido3) != 0 )
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
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FIRST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E111E2 */
                              E111E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PREVIOUS'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E121E2 */
                              E121E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NEXT'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E131E2 */
                              E131E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'LAST'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E141E2 */
                              E141E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E151E2 */
                              E151E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVO PACIENTE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E161E2 */
                              E161E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E171E2 */
                              E171E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'NUEVA CONSULTA'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E181E2 */
                              E181E2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 10), "'MODIFICA'") == 0 ) )
                           {
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
                              edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
                              edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
                              edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
                              edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
                              edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
                              edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
                              edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
                              cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
                              A68PacienteNombre1 = cgiGet( edtPacienteNombre1_Internalname) ;
                              A69PacienteNombre2 = cgiGet( edtPacienteNombre2_Internalname) ;
                              A70PacienteApellido1 = cgiGet( edtPacienteApellido1_Internalname) ;
                              A71PacienteApellido2 = cgiGet( edtPacienteApellido2_Internalname) ;
                              A72PacienteApellido3 = cgiGet( edtPacienteApellido3_Internalname) ;
                              A74PacienteNacimiento = context.localUtil.CToD( cgiGet( edtPacienteNacimiento_Internalname), 2) ;
                              cmbPacienteSexo.Name = cmbPacienteSexo_Internalname ;
                              cmbPacienteSexo.CurrentValue = cgiGet( cmbPacienteSexo_Internalname) ;
                              A326PacienteSexo = cgiGet( cmbPacienteSexo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E191E2 */
                                    E191E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E201E2 */
                                    E201E2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Pacientenombre1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTENOMBRE1"), AV7PacienteNombre1) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Pacientenombre2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTENOMBRE2"), AV8PacienteNombre2) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Pacienteapellido1 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO1"), AV9PacienteApellido1) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Pacienteapellido2 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO2"), AV10PacienteApellido2) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Pacienteapellido3 Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vPACIENTEAPELLIDO3"), AV11PacienteApellido3) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "'MODIFICA'") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E171E2 */
                                    E171E2 ();
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

      protected void WE1E2( )
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

      protected void PA1E2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXCCtl = "PACIENTESEXO_" + sGXsfl_36_idx ;
            cmbPacienteSexo.Name = GXCCtl ;
            cmbPacienteSexo.WebTags = "" ;
            cmbPacienteSexo.addItem("M", "Masculino", 0);
            cmbPacienteSexo.addItem("F", "Femenino", 0);
            if ( ( cmbPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A326PacienteSexo)) )
            {
               A326PacienteSexo = cmbPacienteSexo.getItemValue(1) ;
            }
            GX_FocusControl = edtavPacientenombre1_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_36_idx ,
                                       String sGXsfl_36_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
         edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
         edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
         edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
         edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
         edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
         edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
         cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
            edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
            cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize36 ,
                                        String AV7PacienteNombre1 ,
                                        String AV8PacienteNombre2 ,
                                        String AV9PacienteApellido1 ,
                                        String AV10PacienteApellido2 ,
                                        String AV11PacienteApellido3 ,
                                        String AV6ClinicaCodigo )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize36) ;
         RF1E2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF1E2( ) ;
         /* End function Refresh */
      }

      protected void RF1E2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
         edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
         edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
         edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
         edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
         edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
         edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
         cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
            edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
            cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
            lV7PacienteNombre1 = StringUtil.PadR( StringUtil.RTrim( AV7PacienteNombre1), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteNombre1", AV7PacienteNombre1);
            lV8PacienteNombre2 = StringUtil.PadR( StringUtil.RTrim( AV8PacienteNombre2), 70, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteNombre2", AV8PacienteNombre2);
            lV9PacienteApellido1 = StringUtil.PadR( StringUtil.RTrim( AV9PacienteApellido1), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteApellido1", AV9PacienteApellido1);
            lV10PacienteApellido2 = StringUtil.PadR( StringUtil.RTrim( AV10PacienteApellido2), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteApellido2", AV10PacienteApellido2);
            lV11PacienteApellido3 = StringUtil.PadR( StringUtil.RTrim( AV11PacienteApellido3), 30, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteApellido3", AV11PacienteApellido3);
            /* Using cursor H001E2 */
            pr_default.execute(0, new Object[] {AV6ClinicaCodigo, lV7PacienteNombre1, AV7PacienteNombre1, lV8PacienteNombre2, AV8PacienteNombre2, lV9PacienteApellido1, AV9PacienteApellido1, lV10PacienteApellido2, AV10PacienteApellido2, lV11PacienteApellido3, AV11PacienteApellido3});
            nGXsfl_36_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 12 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A326PacienteSexo = H001E2_A326PacienteSexo[0] ;
               A74PacienteNacimiento = H001E2_A74PacienteNacimiento[0] ;
               A72PacienteApellido3 = H001E2_A72PacienteApellido3[0] ;
               A71PacienteApellido2 = H001E2_A71PacienteApellido2[0] ;
               A70PacienteApellido1 = H001E2_A70PacienteApellido1[0] ;
               A69PacienteNombre2 = H001E2_A69PacienteNombre2[0] ;
               A68PacienteNombre1 = H001E2_A68PacienteNombre1[0] ;
               A67PacienteId = H001E2_A67PacienteId[0] ;
               A41ClinicaCodigo = H001E2_A41ClinicaCodigo[0] ;
               /* Execute user event: E201E2 */
               E201E2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 36 ;
            WB1E0( ) ;
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
         lV7PacienteNombre1 = StringUtil.PadR( StringUtil.RTrim( AV7PacienteNombre1), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteNombre1", AV7PacienteNombre1);
         lV8PacienteNombre2 = StringUtil.PadR( StringUtil.RTrim( AV8PacienteNombre2), 70, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteNombre2", AV8PacienteNombre2);
         lV9PacienteApellido1 = StringUtil.PadR( StringUtil.RTrim( AV9PacienteApellido1), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteApellido1", AV9PacienteApellido1);
         lV10PacienteApellido2 = StringUtil.PadR( StringUtil.RTrim( AV10PacienteApellido2), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteApellido2", AV10PacienteApellido2);
         lV11PacienteApellido3 = StringUtil.PadR( StringUtil.RTrim( AV11PacienteApellido3), 30, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteApellido3", AV11PacienteApellido3);
         /* Using cursor H001E3 */
         pr_default.execute(1, new Object[] {AV6ClinicaCodigo, lV7PacienteNombre1, AV7PacienteNombre1, lV8PacienteNombre2, AV8PacienteNombre2, lV9PacienteApellido1, AV9PacienteApellido1, lV10PacienteApellido2, AV10PacienteApellido2, lV11PacienteApellido3, AV11PacienteApellido3});
         GRID1_nRecordCount = H001E3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 12 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(12*1) ;
            }
            else
            {
               return (int)(12) ;
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

      protected void STRUP1E0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E191E2 */
         E191E2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV7PacienteNombre1 = cgiGet( edtavPacientenombre1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteNombre1", AV7PacienteNombre1);
            AV8PacienteNombre2 = cgiGet( edtavPacientenombre2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteNombre2", AV8PacienteNombre2);
            AV9PacienteApellido1 = cgiGet( edtavPacienteapellido1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteApellido1", AV9PacienteApellido1);
            AV10PacienteApellido2 = cgiGet( edtavPacienteapellido2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteApellido2", AV10PacienteApellido2);
            AV11PacienteApellido3 = cgiGet( edtavPacienteapellido3_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteApellido3", AV11PacienteApellido3);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ".", ",")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ".", ",")) ;
            /* Read subfile selected row values. */
            nGXsfl_36_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ".", ",")) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
            edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
            cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
            if ( nGXsfl_36_idx > 0 )
            {
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               A67PacienteId = (int)(context.localUtil.CToN( cgiGet( edtPacienteId_Internalname), ".", ",")) ;
               A68PacienteNombre1 = cgiGet( edtPacienteNombre1_Internalname) ;
               A69PacienteNombre2 = cgiGet( edtPacienteNombre2_Internalname) ;
               A70PacienteApellido1 = cgiGet( edtPacienteApellido1_Internalname) ;
               A71PacienteApellido2 = cgiGet( edtPacienteApellido2_Internalname) ;
               A72PacienteApellido3 = cgiGet( edtPacienteApellido3_Internalname) ;
               A74PacienteNacimiento = context.localUtil.CToD( cgiGet( edtPacienteNacimiento_Internalname), 2) ;
               cmbPacienteSexo.Name = cmbPacienteSexo_Internalname ;
               cmbPacienteSexo.CurrentValue = cgiGet( cmbPacienteSexo_Internalname) ;
               A326PacienteSexo = cgiGet( cmbPacienteSexo_Internalname) ;
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E191E2 */
         E191E2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E191E2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV5Parametros = GXt_SdtParametros4 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
      }

      protected void E111E2( )
      {
         /* 'First' Routine */
         subgrid1_firstpage( ) ;
      }

      protected void E121E2( )
      {
         /* 'Previous' Routine */
         subgrid1_previouspage( ) ;
      }

      protected void E131E2( )
      {
         /* 'Next' Routine */
         subgrid1_nextpage( ) ;
      }

      protected void E141E2( )
      {
         /* 'Last' Routine */
         subgrid1_lastpage( ) ;
      }

      protected void E151E2( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E161E2( )
      {
         /* 'Nuevo Paciente' Routine */
         GXt_int5 = AV12PacienteId ;
         new oobtienecorrelativo(context ).execute(  AV6ClinicaCodigo,  3, out  GXt_int5) ;
         AV12PacienteId = GXt_int5 ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
         {
            gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
         }
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV12PacienteId) + "," + UrlEncode(StringUtil.RTrim("INS")) + "," + UrlEncode("" +1) ;
         context.wjLoc = formatLink("paciente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void E171E2( )
      {
         /* 'Modifica' Routine */
         if ( A67PacienteId > 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode("" +A67PacienteId) + "," + UrlEncode(StringUtil.RTrim("UPD")) + "," + UrlEncode("" +1) ;
            context.wjLoc = formatLink("paciente.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
      }

      protected void E181E2( )
      {
         /* 'Nueva Consulta' Routine */
         if ( A67PacienteId > 0 )
         {
            GXt_int5 = AV13ConsultaId ;
            new oobtienecorrelativo(context ).execute(  AV6ClinicaCodigo,  6, out  GXt_int5) ;
            AV13ConsultaId = GXt_int5 ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXEncryptionTmp = UrlEncode("" +A67PacienteId) + "," + UrlEncode("" +AV13ConsultaId) ;
            context.wjLoc = formatLink("wp_registraconsulta.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
         }
      }

      private void E201E2( )
      {
         /* Load Routine */
         if ( ( subGrid1_Islastpage == 1 ) || ( 12 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_362( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      protected void wb_table1_2_1E2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Pacientes", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table2_11_1E2( true) ;
         }
         else
         {
            wb_table2_11_1E2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_1E2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"36\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 2, sStyleString, "", 0);
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Paciente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Primer Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Segundo Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Primer Apellido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Segundo Apellido") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Apellido de Casada") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Fecha_Nacimiento") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Paciente Sexo") ;
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
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("Titlefont", StringUtil.RTrim( subGrid1_Titlefont));
               Grid1Container.AddObjectProperty("Linesfont", StringUtil.RTrim( subGrid1_Linesfont));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A68PacienteNombre1));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A69PacienteNombre2));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A70PacienteApellido1));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A71PacienteApellido2));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A72PacienteApellido3));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.localUtil.Format(A74PacienteNacimiento, "99/99/99"));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A326PacienteSexo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "true");
               Grid1Container.AddObjectProperty("Selectioncolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Selectioncolor), 9, 0, ".", "")));
               Grid1Container.AddObjectProperty("Allowhover", "true");
               Grid1Container.AddObjectProperty("Hovercolor", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Hoveringcolor), 9, 0, ".", "")));
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
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "|<", bttButton1_Jsonclick, 5, "|<", "", StyleString, ClassString, 1, 1, "standard", "E\\'FIRST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 49,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "<", bttButton2_Jsonclick, 5, "<", "", StyleString, ClassString, 1, 1, "standard", "E\\'PREVIOUS\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 50,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", ">", bttButton3_Jsonclick, 5, ">", "", StyleString, ClassString, 1, 1, "standard", "E\\'NEXT\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 51,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", ">|", bttButton4_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'LAST\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 56,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Nuevo Paciente", bttButton5_Jsonclick, 5, "Nuevo Paciente", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVO PACIENTE\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton6_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Nueva Consulta", bttButton6_Jsonclick, 5, "Nueva Consulta", "", StyleString, ClassString, 1, 1, "standard", "E\\'NUEVA CONSULTA\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton7_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Regresar", bttButton7_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_1E2e( true) ;
         }
         else
         {
            wb_table1_2_1E2e( false) ;
         }
      }

      protected void wb_table2_11_1E2( bool wbgen )
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
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Primer Nombre", "", "", lblTextblock2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Segundo Nombre", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Primer Apellido", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Segundo Apellido", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Apellido de Casada", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7PacienteNombre1", AV7PacienteNombre1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre1_Internalname, StringUtil.RTrim( AV7PacienteNombre1), StringUtil.RTrim( context.localUtil.Format( AV7PacienteNombre1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", "", "", "", "", edtavPacientenombre1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8PacienteNombre2", AV8PacienteNombre2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombre2_Internalname, StringUtil.RTrim( AV8PacienteNombre2), StringUtil.RTrim( context.localUtil.Format( AV8PacienteNombre2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", "", "", "", "", edtavPacientenombre2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9PacienteApellido1", AV9PacienteApellido1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido1_Internalname, StringUtil.RTrim( AV9PacienteApellido1), StringUtil.RTrim( context.localUtil.Format( AV9PacienteApellido1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavPacienteapellido1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10PacienteApellido2", AV10PacienteApellido2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido2_Internalname, StringUtil.RTrim( AV10PacienteApellido2), StringUtil.RTrim( context.localUtil.Format( AV10PacienteApellido2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(31);\"", "", "", "", "", edtavPacienteapellido2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11PacienteApellido3", AV11PacienteApellido3);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteapellido3_Internalname, StringUtil.RTrim( AV11PacienteApellido3), StringUtil.RTrim( context.localUtil.Format( AV11PacienteApellido3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(33);\"", "", "", "", "", edtavPacienteapellido3_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_paciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_1E2e( true) ;
         }
         else
         {
            wb_table2_11_1E2e( false) ;
         }
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
         PA1E2( ) ;
         WS1E2( ) ;
         WE1E2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1574183");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_paciente.js", "?1574183");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB1E0( ) ;
         if ( ( 12 * 1 == 0 ) || ( nGXsfl_36_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               subGrid1_Backcolor = (int)(0x0) ;
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
                  subGrid1_Backcolor = (int)(0x0) ;
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
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A67PacienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A67PacienteId), "ZZZZZZZZ9"),(String)"","E\\'MODIFICA\\'."+sGXsfl_36_idx,(String)"",(String)"",(String)"",(String)edtPacienteId_Jsonclick,(short)5,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteNombre1_Internalname,StringUtil.RTrim( A68PacienteNombre1),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteNombre1_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteNombre2_Internalname,StringUtil.RTrim( A69PacienteNombre2),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteNombre2_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteApellido1_Internalname,StringUtil.RTrim( A70PacienteApellido1),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteApellido1_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteApellido2_Internalname,StringUtil.RTrim( A71PacienteApellido2),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteApellido2_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteApellido3_Internalname,StringUtil.RTrim( A72PacienteApellido3),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteApellido3_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPacienteNacimiento_Internalname,context.localUtil.Format(A74PacienteNacimiento, "99/99/99"),context.localUtil.Format( A74PacienteNacimiento, "99/99/99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPacienteNacimiento_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)8,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
            if ( ( nGXsfl_36_idx == 1 ) && isAjaxCallMode( ) )
            {
               GXCCtl = "PACIENTESEXO_" + sGXsfl_36_idx ;
               cmbPacienteSexo.Name = GXCCtl ;
               cmbPacienteSexo.WebTags = "" ;
               cmbPacienteSexo.addItem("M", "Masculino", 0);
               cmbPacienteSexo.addItem("F", "Femenino", 0);
               if ( ( cmbPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A326PacienteSexo)) )
               {
                  A326PacienteSexo = cmbPacienteSexo.getItemValue(1) ;
               }
            }
            /* ComboBox */
            Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbPacienteSexo,(String)cmbPacienteSexo_Internalname,(String)A326PacienteSexo,(short)1,(String)cmbPacienteSexo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
            cmbPacienteSexo.CurrentValue = A326PacienteSexo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbPacienteSexo_Internalname, "Values", (String)(cmbPacienteSexo.ToJavascriptSource()));
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtPacienteId_Internalname = "PACIENTEID_"+sGXsfl_36_idx ;
            edtPacienteNombre1_Internalname = "PACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtPacienteNombre2_Internalname = "PACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtPacienteApellido1_Internalname = "PACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtPacienteApellido2_Internalname = "PACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtPacienteApellido3_Internalname = "PACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            edtPacienteNacimiento_Internalname = "PACIENTENACIMIENTO_"+sGXsfl_36_idx ;
            cmbPacienteSexo_Internalname = "PACIENTESEXO_"+sGXsfl_36_idx ;
         }
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavPacientenombre1_Internalname = "vPACIENTENOMBRE1" ;
         edtavPacientenombre2_Internalname = "vPACIENTENOMBRE2" ;
         edtavPacienteapellido1_Internalname = "vPACIENTEAPELLIDO1" ;
         edtavPacienteapellido2_Internalname = "vPACIENTEAPELLIDO2" ;
         edtavPacienteapellido3_Internalname = "vPACIENTEAPELLIDO3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         bttButton6_Internalname = "BUTTON6" ;
         bttButton7_Internalname = "BUTTON7" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbPacienteSexo_Jsonclick = "" ;
         edtPacienteNacimiento_Jsonclick = "" ;
         edtPacienteApellido3_Jsonclick = "" ;
         edtPacienteApellido2_Jsonclick = "" ;
         edtPacienteApellido1_Jsonclick = "" ;
         edtPacienteNombre2_Jsonclick = "" ;
         edtPacienteNombre1_Jsonclick = "" ;
         edtPacienteId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavPacienteapellido3_Jsonclick = "" ;
         edtavPacienteapellido2_Jsonclick = "" ;
         edtavPacienteapellido1_Jsonclick = "" ;
         edtavPacientenombre2_Jsonclick = "" ;
         edtavPacientenombre1_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Consulta de Pacientes" ;
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
         A326PacienteSexo = "" ;
         AV7PacienteNombre1 = "" ;
         AV8PacienteNombre2 = "" ;
         AV9PacienteApellido1 = "" ;
         AV10PacienteApellido2 = "" ;
         AV11PacienteApellido3 = "" ;
         AV6ClinicaCodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtPacienteId_Internalname = "" ;
         edtPacienteNombre1_Internalname = "" ;
         edtPacienteNombre2_Internalname = "" ;
         edtPacienteApellido1_Internalname = "" ;
         edtPacienteApellido2_Internalname = "" ;
         edtPacienteApellido3_Internalname = "" ;
         edtPacienteNacimiento_Internalname = "" ;
         cmbPacienteSexo_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A68PacienteNombre1 = "" ;
         A69PacienteNombre2 = "" ;
         A70PacienteApellido1 = "" ;
         A71PacienteApellido2 = "" ;
         A72PacienteApellido3 = "" ;
         A74PacienteNacimiento = DateTime.MinValue ;
         GXKey = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7PacienteNombre1 = "" ;
         lV8PacienteNombre2 = "" ;
         lV9PacienteApellido1 = "" ;
         lV10PacienteApellido2 = "" ;
         lV11PacienteApellido3 = "" ;
         H001E2_A326PacienteSexo = new String[] {""} ;
         H001E2_A74PacienteNacimiento = new DateTime[] {DateTime.MinValue} ;
         H001E2_A72PacienteApellido3 = new String[] {""} ;
         H001E2_A71PacienteApellido2 = new String[] {""} ;
         H001E2_A70PacienteApellido1 = new String[] {""} ;
         H001E2_A69PacienteNombre2 = new String[] {""} ;
         H001E2_A68PacienteNombre1 = new String[] {""} ;
         H001E2_A67PacienteId = new int[1] ;
         H001E2_A41ClinicaCodigo = new String[] {""} ;
         H001E3_AGRID1_nRecordCount = new int[1] ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         GXEncryptionTmp = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         GXt_char9 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char10 = "" ;
         TempTags = "" ;
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton6_Jsonclick = "" ;
         bttButton7_Jsonclick = "" ;
         lblTextblock2_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char11 = "" ;
         ROClassString = "" ;
         GXt_char12 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_paciente__default(),
            new Object[][] {
                new Object[] {
               H001E2_A326PacienteSexo, H001E2_A74PacienteNacimiento, H001E2_A72PacienteApellido3, H001E2_A71PacienteApellido2, H001E2_A70PacienteApellido1, H001E2_A69PacienteNombre2, H001E2_A68PacienteNombre1, H001E2_A67PacienteId, H001E2_A41ClinicaCodigo
               }
               , new Object[] {
               H001E3_AGRID1_nRecordCount
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
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize36 ;
      private int GRID1_nFirstRecordOnPage ;
      private int A67PacienteId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int AV12PacienteId ;
      private int AV13ConsultaId ;
      private int GXt_int5 ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
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
      private String edtClinicaCodigo_Internalname ;
      private String edtPacienteId_Internalname ;
      private String edtPacienteNombre1_Internalname ;
      private String edtPacienteNombre2_Internalname ;
      private String edtPacienteApellido1_Internalname ;
      private String edtPacienteApellido2_Internalname ;
      private String edtPacienteApellido3_Internalname ;
      private String edtPacienteNacimiento_Internalname ;
      private String cmbPacienteSexo_Internalname ;
      private String GXKey ;
      private String edtavPacientenombre1_Internalname ;
      private String scmdbuf ;
      private String edtavPacientenombre2_Internalname ;
      private String edtavPacienteapellido1_Internalname ;
      private String edtavPacienteapellido2_Internalname ;
      private String edtavPacienteapellido3_Internalname ;
      private String subGrid1_Internalname ;
      private String GXEncryptionTmp ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String GXt_char9 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String GXt_char10 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String bttButton4_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton6_Internalname ;
      private String bttButton6_Jsonclick ;
      private String bttButton7_Internalname ;
      private String bttButton7_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavPacientenombre1_Jsonclick ;
      private String edtavPacientenombre2_Jsonclick ;
      private String edtavPacienteapellido1_Jsonclick ;
      private String edtavPacienteapellido2_Jsonclick ;
      private String edtavPacienteapellido3_Jsonclick ;
      private String GXt_char11 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtPacienteId_Jsonclick ;
      private String edtPacienteNombre1_Jsonclick ;
      private String edtPacienteNombre2_Jsonclick ;
      private String edtPacienteApellido1_Jsonclick ;
      private String edtPacienteApellido2_Jsonclick ;
      private String edtPacienteApellido3_Jsonclick ;
      private String edtPacienteNacimiento_Jsonclick ;
      private String cmbPacienteSexo_Jsonclick ;
      private String GXt_char12 ;
      private DateTime A74PacienteNacimiento ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String A326PacienteSexo ;
      private String AV7PacienteNombre1 ;
      private String AV8PacienteNombre2 ;
      private String AV9PacienteApellido1 ;
      private String AV10PacienteApellido2 ;
      private String AV11PacienteApellido3 ;
      private String AV6ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A68PacienteNombre1 ;
      private String A69PacienteNombre2 ;
      private String A70PacienteApellido1 ;
      private String A71PacienteApellido2 ;
      private String A72PacienteApellido3 ;
      private String lV7PacienteNombre1 ;
      private String lV8PacienteNombre2 ;
      private String lV9PacienteApellido1 ;
      private String lV10PacienteApellido2 ;
      private String lV11PacienteApellido3 ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbPacienteSexo ;
      private IDataStoreProvider pr_default ;
      private String[] H001E2_A326PacienteSexo ;
      private DateTime[] H001E2_A74PacienteNacimiento ;
      private String[] H001E2_A72PacienteApellido3 ;
      private String[] H001E2_A71PacienteApellido2 ;
      private String[] H001E2_A70PacienteApellido1 ;
      private String[] H001E2_A69PacienteNombre2 ;
      private String[] H001E2_A68PacienteNombre1 ;
      private int[] H001E2_A67PacienteId ;
      private String[] H001E2_A41ClinicaCodigo ;
      private int[] H001E3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_paciente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH001E2 ;
          prmH001E2 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV7PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV8PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV8PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV9PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV9PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@lV10PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV10PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@lV11PacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV11PacienteApellido3",SqlDbType.VarChar,30,0}
          } ;
          Object[] prmH001E3 ;
          prmH001E3 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@lV7PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV7PacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV8PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@AV8PacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@lV9PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV9PacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@lV10PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV10PacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@lV11PacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV11PacienteApellido3",SqlDbType.VarChar,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H001E2", "SELECT [PacienteSexo], [PacienteNacimiento], [PacienteApellido3], [PacienteApellido2], [PacienteApellido1], [PacienteNombre2], [PacienteNombre1], [PacienteId], [ClinicaCodigo] FROM [Paciente] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV6ClinicaCodigo) AND ([PacienteNombre1] like @lV7PacienteNombre1 or (@AV7PacienteNombre1 = '')) AND ([PacienteNombre2] like @lV8PacienteNombre2 or (@AV8PacienteNombre2 = '')) AND ([PacienteApellido1] like @lV9PacienteApellido1 or (@AV9PacienteApellido1 = '')) AND ([PacienteApellido2] like @lV10PacienteApellido2 or (@AV10PacienteApellido2 = '')) AND ([PacienteApellido3] like @lV11PacienteApellido3 or (@AV11PacienteApellido3 = '')) ORDER BY [ClinicaCodigo], [PacienteId]  OPTION (FAST 13)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E2,13,0,true,false )
             ,new CursorDef("H001E3", "SELECT COUNT(*) FROM [Paciente] WITH (NOLOCK) WHERE ([ClinicaCodigo] = @AV6ClinicaCodigo) AND ([PacienteNombre1] like @lV7PacienteNombre1 or (@AV7PacienteNombre1 = '')) AND ([PacienteNombre2] like @lV8PacienteNombre2 or (@AV8PacienteNombre2 = '')) AND ([PacienteApellido1] like @lV9PacienteApellido1 or (@AV9PacienteApellido1 = '')) AND ([PacienteApellido2] like @lV10PacienteApellido2 or (@AV10PacienteApellido2 = '')) AND ([PacienteApellido3] like @lV11PacienteApellido3 or (@AV11PacienteApellido3 = '')) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH001E3,1,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((int[]) buf[7])[0] = rslt.getInt(8) ;
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (String)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                break;
       }
    }

 }

}
