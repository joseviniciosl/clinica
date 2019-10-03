/*
               File: wp_npaciente
        Description: Registro de notas de pacientes
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:14.84
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
   public class wp_npaciente : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_npaciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_npaciente( IGxContext context )
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
         cmbavNpacientesexo = new GXCombobox();
         cmbavNpacienteestaturaen = new GXCombobox();
         cmbavNpacientepesoen = new GXCombobox();
         dynavProfesionid = new GXCombobox();
         dynavReligionid = new GXCombobox();
         chkavNpacienteanestesiageneral = new GXCheckbox();
         chkavNpacienteanestesiaepidural = new GXCheckbox();
         chkavNpacienteanestesiaraquidea = new GXCheckbox();
         chkavNpacientefuma = new GXCheckbox();
         chkavNpacientealcohol = new GXCheckbox();
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vPROFESIONID") == 0 )
            {
               AV5ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvPROFESIONID3H2( AV5ClinicaCodigo) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxCallCrl"+"_"+"vRELIGIONID") == 0 )
            {
               AV5ClinicaCodigo = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               GXDLVvRELIGIONID3H2( AV5ClinicaCodigo) ;
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
         PA3H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3H2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_npaciente.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV5ClinicaCodigo));
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
            WE3H2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_npaciente" ;
      }

      public override String GetPgmdesc( )
      {
         return "Registro de notas de pacientes" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_npaciente.aspx")  ;
      }

      protected void WB3H0( )
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
            wb_table1_2_3H2( true) ;
         }
         else
         {
            wb_table1_2_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true ;
      }

      protected void START3H2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Registro de notas de pacientes", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP3H0( ) ;
      }

      protected void WS3H2( )
      {
         START3H2( ) ;
         EVT3H2( ) ;
      }

      protected void EVT3H2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E113H2 */
                              E113H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'RETORNAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E123H2 */
                              E123H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'CONFIRMAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E133H2 */
                              E133H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E143H2 */
                              E143H2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                           {
                              context.wbHandled = 1 ;
                              if ( ! wbErr )
                              {
                                 Rfr0gs = false ;
                                 if ( ! Rfr0gs )
                                 {
                                 }
                                 dynload_actions( ) ;
                              }
                              /* No code required for Cancel button. It is implemented as the Reset button. */
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
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE3H2( )
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

      protected void PA3H2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            cmbavNpacientesexo.Name = "vNPACIENTESEXO" ;
            cmbavNpacientesexo.WebTags = "" ;
            cmbavNpacientesexo.addItem("M", "Masculino", 0);
            cmbavNpacientesexo.addItem("F", "Femenino", 0);
            if ( ( cmbavNpacientesexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV22NPacienteSexo)) )
            {
               AV22NPacienteSexo = cmbavNpacientesexo.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22NPacienteSexo", AV22NPacienteSexo);
            }
            cmbavNpacienteestaturaen.Name = "vNPACIENTEESTATURAEN" ;
            cmbavNpacienteestaturaen.WebTags = "" ;
            cmbavNpacienteestaturaen.addItem("ME", "Metros", 0);
            cmbavNpacienteestaturaen.addItem("CM", "Centímetros", 0);
            if ( ( cmbavNpacienteestaturaen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV19NPacienteEstaturaEn)) )
            {
               AV19NPacienteEstaturaEn = cmbavNpacienteestaturaen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19NPacienteEstaturaEn", AV19NPacienteEstaturaEn);
            }
            cmbavNpacientepesoen.Name = "vNPACIENTEPESOEN" ;
            cmbavNpacientepesoen.WebTags = "" ;
            cmbavNpacientepesoen.addItem("Lb", "Libras", 0);
            cmbavNpacientepesoen.addItem("Gr", "Gramos", 0);
            cmbavNpacientepesoen.addItem("Kg", "Kilogramos", 0);
            if ( ( cmbavNpacientepesoen.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( AV17NPacientePesoEn)) )
            {
               AV17NPacientePesoEn = cmbavNpacientepesoen.getItemValue(1) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17NPacientePesoEn", AV17NPacientePesoEn);
            }
            dynavProfesionid.Name = "vPROFESIONID" ;
            dynavProfesionid.WebTags = "" ;
            dynavReligionid.Name = "vRELIGIONID" ;
            dynavReligionid.WebTags = "" ;
            chkavNpacienteanestesiageneral.Name = "vNPACIENTEANESTESIAGENERAL" ;
            chkavNpacienteanestesiageneral.WebTags = "" ;
            chkavNpacienteanestesiageneral.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavNpacienteanestesiageneral_Internalname, "Caption", chkavNpacienteanestesiageneral.Caption);
            chkavNpacienteanestesiageneral.CheckedValue = "0" ;
            chkavNpacienteanestesiaepidural.Name = "vNPACIENTEANESTESIAEPIDURAL" ;
            chkavNpacienteanestesiaepidural.WebTags = "" ;
            chkavNpacienteanestesiaepidural.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavNpacienteanestesiaepidural_Internalname, "Caption", chkavNpacienteanestesiaepidural.Caption);
            chkavNpacienteanestesiaepidural.CheckedValue = "0" ;
            chkavNpacienteanestesiaraquidea.Name = "vNPACIENTEANESTESIARAQUIDEA" ;
            chkavNpacienteanestesiaraquidea.WebTags = "" ;
            chkavNpacienteanestesiaraquidea.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavNpacienteanestesiaraquidea_Internalname, "Caption", chkavNpacienteanestesiaraquidea.Caption);
            chkavNpacienteanestesiaraquidea.CheckedValue = "0" ;
            chkavNpacientefuma.Name = "vNPACIENTEFUMA" ;
            chkavNpacientefuma.WebTags = "" ;
            chkavNpacientefuma.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavNpacientefuma_Internalname, "Caption", chkavNpacientefuma.Caption);
            chkavNpacientefuma.CheckedValue = "0" ;
            chkavNpacientealcohol.Name = "vNPACIENTEALCOHOL" ;
            chkavNpacientealcohol.WebTags = "" ;
            chkavNpacientealcohol.Caption = "" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, chkavNpacientealcohol_Internalname, "Caption", chkavNpacientealcohol.Caption);
            chkavNpacientealcohol.CheckedValue = "0" ;
            GX_FocusControl = edtavNpacientenombre1_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void GXDLVvPROFESIONID3H2( String AV5ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvPROFESIONID_data3H2( AV5ClinicaCodigo) ;
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

      protected void GXVvPROFESIONID_html3H2( String AV5ClinicaCodigo )
      {
         int gxdynajaxvalue ;
         GXDLVvPROFESIONID_data3H2( AV5ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavProfesionid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynavProfesionid.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavProfesionid.ItemCount > 0 ) && (0==AV20ProfesionId) )
            {
               AV20ProfesionId = (int)(NumberUtil.Val( dynavProfesionid.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0)));
            }
         }
      }

      protected void GXDLVvPROFESIONID_data3H2( String AV5ClinicaCodigo )
      {
         /* Using cursor H003H2 */
         pr_default.execute(0, new Object[] {AV5ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(0) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H003H2_A313ProfesionId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H003H2_A314ProfesionNombre[0]));
            pr_default.readNext(0);
         }
         pr_default.close(0);
      }

      protected void GXDLVvRELIGIONID3H2( String AV5ClinicaCodigo )
      {
         if ( ! context.isAjaxRequest( ) )
         {
            context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
         }
         context.GX_webresponse.AddString("(new Array( new Array(");
         GXDLVvRELIGIONID_data3H2( AV5ClinicaCodigo) ;
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

      protected void GXVvRELIGIONID_html3H2( String AV5ClinicaCodigo )
      {
         int gxdynajaxvalue ;
         GXDLVvRELIGIONID_data3H2( AV5ClinicaCodigo) ;
         gxdynajaxindex = 1 ;
         dynavReligionid.removeAllItems();
         while ( gxdynajaxindex <= gxdynajaxctrlcodr.Count )
         {
            gxdynajaxvalue = (int)(NumberUtil.Val( gxdynajaxctrlcodr.Item(gxdynajaxindex), ".")) ;
            dynavReligionid.addItem(StringUtil.Str( (decimal)(gxdynajaxvalue), 9, 0), gxdynajaxctrldescr.Item(gxdynajaxindex), 0);
            gxdynajaxindex = (int)(gxdynajaxindex+1) ;
         }
         if ( ! context.isAjaxRequest( ) )
         {
            if ( ( dynavReligionid.ItemCount > 0 ) && (0==AV21ReligionId) )
            {
               AV21ReligionId = (int)(NumberUtil.Val( dynavReligionid.getItemValue(1), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ReligionId), 9, 0)));
            }
         }
      }

      protected void GXDLVvRELIGIONID_data3H2( String AV5ClinicaCodigo )
      {
         /* Using cursor H003H3 */
         pr_default.execute(1, new Object[] {AV5ClinicaCodigo});
         gxdynajaxctrlcodr.Clear();
         gxdynajaxctrldescr.Clear();
         while ( (pr_default.getStatus(1) != 101) )
         {
            gxdynajaxctrlcodr.Add(StringUtil.LTrim( StringUtil.NToC( (decimal)(H003H3_A315ReligionId[0]), 9, 0, ".", "")));
            gxdynajaxctrldescr.Add(StringUtil.RTrim( H003H3_A316ReligionNombre[0]));
            pr_default.readNext(1);
         }
         pr_default.close(1);
      }

      protected void Refresh( )
      {
         RF3H2( ) ;
         /* End function Refresh */
      }

      protected void RF3H2( )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E143H2 */
            E143H2 ();
            WB3H0( ) ;
         }
      }

      protected void STRUP3H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E113H2 */
         E113H2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         GXVvPROFESIONID_html3H2( AV5ClinicaCodigo) ;
         GXVvRELIGIONID_html3H2( AV5ClinicaCodigo) ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10NPacienteNombre1 = cgiGet( edtavNpacientenombre1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10NPacienteNombre1", AV10NPacienteNombre1);
            AV11NPacienteNombre2 = cgiGet( edtavNpacientenombre2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NPacienteNombre2", AV11NPacienteNombre2);
            AV12NPacienteApellido1 = cgiGet( edtavNpacienteapellido1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NPacienteApellido1", AV12NPacienteApellido1);
            AV13NPacienteApellido2 = cgiGet( edtavNpacienteapellido2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13NPacienteApellido2", AV13NPacienteApellido2);
            AV14NPacienteApellido3 = cgiGet( edtavNpacienteapellido3_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14NPacienteApellido3", AV14NPacienteApellido3);
            if ( context.localUtil.VCDate( cgiGet( edtavNpacientefechanac_Internalname), 2) == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"NPaciente Fecha Nac"}), 1, "vNPACIENTEFECHANAC");
               GX_FocusControl = edtavNpacientefechanac_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15NPacienteFechaNac = DateTime.MinValue ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15NPacienteFechaNac", context.localUtil.Format(AV15NPacienteFechaNac, "99/99/99"));
            }
            else
            {
               AV15NPacienteFechaNac = context.localUtil.CToD( cgiGet( edtavNpacientefechanac_Internalname), 2) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15NPacienteFechaNac", context.localUtil.Format(AV15NPacienteFechaNac, "99/99/99"));
            }
            cmbavNpacientesexo.CurrentValue = cgiGet( cmbavNpacientesexo_Internalname) ;
            AV22NPacienteSexo = cgiGet( cmbavNpacientesexo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22NPacienteSexo", AV22NPacienteSexo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacienteestatura_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacienteestatura_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEESTATURA");
               GX_FocusControl = edtavNpacienteestatura_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV18NPacienteEstatura = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( AV18NPacienteEstatura, 17, 2)));
            }
            else
            {
               AV18NPacienteEstatura = context.localUtil.CToN( cgiGet( edtavNpacienteestatura_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( AV18NPacienteEstatura, 17, 2)));
            }
            cmbavNpacienteestaturaen.CurrentValue = cgiGet( cmbavNpacienteestaturaen_Internalname) ;
            AV19NPacienteEstaturaEn = cgiGet( cmbavNpacienteestaturaen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19NPacienteEstaturaEn", AV19NPacienteEstaturaEn);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacientepeso_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacientepeso_Internalname), ".", ",") > 99999999999999.99m ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEPESO");
               GX_FocusControl = edtavNpacientepeso_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV16NPacientePeso = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16NPacientePeso", StringUtil.LTrim( StringUtil.Str( AV16NPacientePeso, 17, 2)));
            }
            else
            {
               AV16NPacientePeso = context.localUtil.CToN( cgiGet( edtavNpacientepeso_Internalname), ".", ",") ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16NPacientePeso", StringUtil.LTrim( StringUtil.Str( AV16NPacientePeso, 17, 2)));
            }
            cmbavNpacientepesoen.CurrentValue = cgiGet( cmbavNpacientepesoen_Internalname) ;
            AV17NPacientePesoEn = cgiGet( cmbavNpacientepesoen_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17NPacientePesoEn", AV17NPacientePesoEn);
            dynavProfesionid.CurrentValue = cgiGet( dynavProfesionid_Internalname) ;
            AV20ProfesionId = (int)(NumberUtil.Val( cgiGet( dynavProfesionid_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0)));
            dynavReligionid.CurrentValue = cgiGet( dynavReligionid_Internalname) ;
            AV21ReligionId = (int)(NumberUtil.Val( cgiGet( dynavReligionid_Internalname), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ReligionId), 9, 0)));
            AV23NPacienteDireccion = cgiGet( edtavNpacientedireccion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23NPacienteDireccion", AV23NPacienteDireccion);
            AV24NPacienteCorreo = cgiGet( edtavNpacientecorreo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24NPacienteCorreo", AV24NPacienteCorreo);
            AV25NPacienteFacebook = cgiGet( edtavNpacientefacebook_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25NPacienteFacebook", AV25NPacienteFacebook);
            AV26NPacienteTelefono = cgiGet( edtavNpacientetelefono_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NPacienteTelefono", AV26NPacienteTelefono);
            AV27NPacienteCelular = cgiGet( edtavNpacientecelular_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NPacienteCelular", AV27NPacienteCelular);
            AV28NPacienteEnfermedad = cgiGet( edtavNpacienteenfermedad_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28NPacienteEnfermedad", AV28NPacienteEnfermedad);
            AV29NPacienteMedicamento = cgiGet( edtavNpacientemedicamento_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29NPacienteMedicamento", AV29NPacienteMedicamento);
            AV30NPacienteOperacion = cgiGet( edtavNpacienteoperacion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30NPacienteOperacion", AV30NPacienteOperacion);
            AV31NPacienteAlergia = cgiGet( edtavNpacientealergia_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NPacienteAlergia", AV31NPacienteAlergia);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacientegesta_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacientegesta_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEGESTA");
               GX_FocusControl = edtavNpacientegesta_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV33NPacienteGesta = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33NPacienteGesta), 4, 0)));
            }
            else
            {
               AV33NPacienteGesta = (short)(context.localUtil.CToN( cgiGet( edtavNpacientegesta_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33NPacienteGesta), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacienteparto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacienteparto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEPARTO");
               GX_FocusControl = edtavNpacienteparto_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV32NPacienteParto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32NPacienteParto), 4, 0)));
            }
            else
            {
               AV32NPacienteParto = (short)(context.localUtil.CToN( cgiGet( edtavNpacienteparto_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32NPacienteParto), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacientecesarea_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacientecesarea_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTECESAREA");
               GX_FocusControl = edtavNpacientecesarea_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV34NPacienteCesarea = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34NPacienteCesarea), 4, 0)));
            }
            else
            {
               AV34NPacienteCesarea = (short)(context.localUtil.CToN( cgiGet( edtavNpacientecesarea_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34NPacienteCesarea), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacienteaborto_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacienteaborto_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEABORTO");
               GX_FocusControl = edtavNpacienteaborto_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV35NPacienteAborto = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35NPacienteAborto), 4, 0)));
            }
            else
            {
               AV35NPacienteAborto = (short)(context.localUtil.CToN( cgiGet( edtavNpacienteaborto_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35NPacienteAborto), 4, 0)));
            }
            if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiageneral_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiageneral_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEANESTESIAGENERAL");
               GX_FocusControl = chkavNpacienteanestesiageneral_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV36NPacienteAnestesiaGeneral = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(AV36NPacienteAnestesiaGeneral), 1, 0));
            }
            else
            {
               AV36NPacienteAnestesiaGeneral = (short)(((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiageneral_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(AV36NPacienteAnestesiaGeneral), 1, 0));
            }
            if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaepidural_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaepidural_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEANESTESIAEPIDURAL");
               GX_FocusControl = chkavNpacienteanestesiaepidural_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV37NPacienteAnestesiaEpidural = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(AV37NPacienteAnestesiaEpidural), 1, 0));
            }
            else
            {
               AV37NPacienteAnestesiaEpidural = (short)(((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaepidural_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(AV37NPacienteAnestesiaEpidural), 1, 0));
            }
            if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaraquidea_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaraquidea_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEANESTESIARAQUIDEA");
               GX_FocusControl = chkavNpacienteanestesiaraquidea_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV38NPacienteAnestesiaRaquidea = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(AV38NPacienteAnestesiaRaquidea), 1, 0));
            }
            else
            {
               AV38NPacienteAnestesiaRaquidea = (short)(((StringUtil.StrCmp(cgiGet( chkavNpacienteanestesiaraquidea_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(AV38NPacienteAnestesiaRaquidea), 1, 0));
            }
            AV39NPacienteAnestesiaOtro = cgiGet( edtavNpacienteanestesiaotro_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39NPacienteAnestesiaOtro", AV39NPacienteAnestesiaOtro);
            AV40NPacienteAnestesiaComplica = cgiGet( edtavNpacienteanestesiacomplica_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40NPacienteAnestesiaComplica", AV40NPacienteAnestesiaComplica);
            if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacientefuma_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacientefuma_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEFUMA");
               GX_FocusControl = chkavNpacientefuma_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV41NPacienteFuma = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41NPacienteFuma", StringUtil.Str( (decimal)(AV41NPacienteFuma), 1, 0));
            }
            else
            {
               AV41NPacienteFuma = (short)(((StringUtil.StrCmp(cgiGet( chkavNpacientefuma_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41NPacienteFuma", StringUtil.Str( (decimal)(AV41NPacienteFuma), 1, 0));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavNpacientecigarros_Internalname), ".", ",") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavNpacientecigarros_Internalname), ".", ",") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTECIGARROS");
               GX_FocusControl = edtavNpacientecigarros_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV42NPacienteCigarros = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42NPacienteCigarros), 4, 0)));
            }
            else
            {
               AV42NPacienteCigarros = (short)(context.localUtil.CToN( cgiGet( edtavNpacientecigarros_Internalname), ".", ",")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42NPacienteCigarros), 4, 0)));
            }
            if ( ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacientealcohol_Internalname), "1")==0) ? 1 : 0) < 0 ) ) || ( ( ((StringUtil.StrCmp(cgiGet( chkavNpacientealcohol_Internalname), "1")==0) ? 1 : 0) > 9 ) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum", ""), 1, "vNPACIENTEALCOHOL");
               GX_FocusControl = chkavNpacientealcohol_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV43NPacienteAlcohol = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43NPacienteAlcohol", StringUtil.Str( (decimal)(AV43NPacienteAlcohol), 1, 0));
            }
            else
            {
               AV43NPacienteAlcohol = (short)(((StringUtil.StrCmp(cgiGet( chkavNpacientealcohol_Internalname), "1")==0) ? 1 : 0)) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43NPacienteAlcohol", StringUtil.Str( (decimal)(AV43NPacienteAlcohol), 1, 0));
            }
            AV44NPacienteOtros = cgiGet( edtavNpacienteotros_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44NPacienteOtros", AV44NPacienteOtros);
            /* Read saved values. */
            /* Read subfile selected row values. */
            /* Read hidden variables. */
            GXVvPROFESIONID_html3H2( AV5ClinicaCodigo) ;
            GXVvRELIGIONID_html3H2( AV5ClinicaCodigo) ;
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E113H2 */
         E113H2 ();
         if (returnInSub) return;
      }

      protected void E113H2( )
      {
         /* Start Routine */
         GXt_SdtParametros4 = AV6Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros4) ;
         AV6Parametros = GXt_SdtParametros4 ;
         AV5ClinicaCodigo = AV6Parametros.gxTpr_Pclinicacodigo ;
         AV8UsuarioCodigo = AV6Parametros.gxTpr_Pusuariocodigo ;
         GXt_int5 = AV9NPacienteId ;
         new oobtienecorrelativo(context ).execute(  AV5ClinicaCodigo,  3, out  GXt_int5) ;
         AV9NPacienteId = GXt_int5 ;
         bttButton1_Enabled = 1 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttButton1_Enabled), 5, 0)));
         bttButton1_Jsonclick = "confirm('La información registrada en el formulario es importante, ¿seguro de confirmar sus datos?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Jsonclick", bttButton1_Jsonclick);
      }

      protected void E123H2( )
      {
         /* 'Retornar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      protected void E133H2( )
      {
         /* 'Confirmar' Routine */
         new pregistranotapaciente(context ).execute( ref  AV5ClinicaCodigo, ref  AV9NPacienteId, ref  AV10NPacienteNombre1, ref  AV11NPacienteNombre2, ref  AV12NPacienteApellido1, ref  AV13NPacienteApellido2, ref  AV14NPacienteApellido3, ref  AV15NPacienteFechaNac, ref  AV22NPacienteSexo, ref  AV18NPacienteEstatura, ref  AV19NPacienteEstaturaEn, ref  AV16NPacientePeso, ref  AV17NPacientePesoEn, ref  AV20ProfesionId, ref  AV21ReligionId, ref  AV23NPacienteDireccion, ref  AV24NPacienteCorreo, ref  AV25NPacienteFacebook, ref  AV26NPacienteTelefono, ref  AV27NPacienteCelular, ref  AV28NPacienteEnfermedad, ref  AV29NPacienteMedicamento, ref  AV30NPacienteOperacion, ref  AV31NPacienteAlergia, ref  AV33NPacienteGesta, ref  AV32NPacienteParto, ref  AV34NPacienteCesarea, ref  AV35NPacienteAborto, ref  AV36NPacienteAnestesiaGeneral, ref  AV37NPacienteAnestesiaEpidural, ref  AV38NPacienteAnestesiaRaquidea, ref  AV39NPacienteAnestesiaOtro, ref  AV40NPacienteAnestesiaComplica, ref  AV41NPacienteFuma, ref  AV42NPacienteCigarros, ref  AV43NPacienteAlcohol, ref  AV44NPacienteOtros, ref  AV8UsuarioCodigo) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10NPacienteNombre1", AV10NPacienteNombre1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NPacienteNombre2", AV11NPacienteNombre2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NPacienteApellido1", AV12NPacienteApellido1);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13NPacienteApellido2", AV13NPacienteApellido2);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14NPacienteApellido3", AV14NPacienteApellido3);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15NPacienteFechaNac", context.localUtil.Format(AV15NPacienteFechaNac, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22NPacienteSexo", AV22NPacienteSexo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( AV18NPacienteEstatura, 17, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19NPacienteEstaturaEn", AV19NPacienteEstaturaEn);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16NPacientePeso", StringUtil.LTrim( StringUtil.Str( AV16NPacientePeso, 17, 2)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17NPacientePesoEn", AV17NPacientePesoEn);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ReligionId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23NPacienteDireccion", AV23NPacienteDireccion);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24NPacienteCorreo", AV24NPacienteCorreo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25NPacienteFacebook", AV25NPacienteFacebook);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NPacienteTelefono", AV26NPacienteTelefono);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NPacienteCelular", AV27NPacienteCelular);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28NPacienteEnfermedad", AV28NPacienteEnfermedad);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29NPacienteMedicamento", AV29NPacienteMedicamento);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30NPacienteOperacion", AV30NPacienteOperacion);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NPacienteAlergia", AV31NPacienteAlergia);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33NPacienteGesta), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32NPacienteParto), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34NPacienteCesarea), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35NPacienteAborto), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(AV36NPacienteAnestesiaGeneral), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(AV37NPacienteAnestesiaEpidural), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(AV38NPacienteAnestesiaRaquidea), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39NPacienteAnestesiaOtro", AV39NPacienteAnestesiaOtro);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40NPacienteAnestesiaComplica", AV40NPacienteAnestesiaComplica);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41NPacienteFuma", StringUtil.Str( (decimal)(AV41NPacienteFuma), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42NPacienteCigarros), 4, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43NPacienteAlcohol", StringUtil.Str( (decimal)(AV43NPacienteAlcohol), 1, 0));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44NPacienteOtros", AV44NPacienteOtros);
         GX_msglist.addItem("Registro almacenado exitosamente.");
         bttButton1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(bttButton1_Enabled), 5, 0)));
      }

      protected void nextLoad( )
      {
      }

      protected void E143H2( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Verdana'; font-size:16.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Pacientes", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
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
            context.WriteHtmlText( "<td>") ;
            wb_table2_11_3H2( true) ;
         }
         else
         {
            wb_table2_11_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table3_48_3H2( true) ;
         }
         else
         {
            wb_table3_48_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_71_3H2( true) ;
         }
         else
         {
            wb_table4_71_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table4_71_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table5_99_3H2( true) ;
         }
         else
         {
            wb_table5_99_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table5_99_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table6_122_3H2( true) ;
         }
         else
         {
            wb_table6_122_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table6_122_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table7_161_3H2( true) ;
         }
         else
         {
            wb_table7_161_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table7_161_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table8_169_3H2( true) ;
         }
         else
         {
            wb_table8_169_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table8_169_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 197,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "", "Confirmar", bttButton1_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, 1, bttButton1_Enabled, "standard", "E\\'CONFIRMAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 198,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "", "Retornar", bttButton2_Jsonclick, 5, "Retornar", "", StyleString, ClassString, 1, 1, "standard", "E\\'RETORNAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3H2e( true) ;
         }
         else
         {
            wb_table1_2_3H2e( false) ;
         }
      }

      protected void wb_table8_169_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable8_Internalname, tblTable8_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:96px\">") ;
            wb_table9_172_3H2( true) ;
         }
         else
         {
            wb_table9_172_3H2( false) ;
         }
         return  ;
      }

      protected void wb_table9_172_3H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:16px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_169_3H2e( true) ;
         }
         else
         {
            wb_table8_169_3H2e( false) ;
         }
      }

      protected void wb_table9_172_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable9_Internalname, tblTable9_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock34_Internalname, "Fuma", "", "", lblTextblock34_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV41NPacienteFuma", StringUtil.Str( (decimal)(AV41NPacienteFuma), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 177,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavNpacientefuma_Internalname, StringUtil.Str( (decimal)(AV41NPacienteFuma), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(177, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(177);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock35_Internalname, "Cigarros Diarios", "", "", lblTextblock35_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV42NPacienteCigarros", StringUtil.LTrim( StringUtil.Str( (decimal)(AV42NPacienteCigarros), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 182,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientecigarros_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV42NPacienteCigarros), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV42NPacienteCigarros), "ZZZ9")) : context.localUtil.Format( (decimal)(AV42NPacienteCigarros), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(182);\"", "", "", "", "", edtavNpacientecigarros_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock36_Internalname, "Alcohol", "", "", lblTextblock36_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV43NPacienteAlcohol", StringUtil.Str( (decimal)(AV43NPacienteAlcohol), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 187,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavNpacientealcohol_Internalname, StringUtil.Str( (decimal)(AV43NPacienteAlcohol), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(187, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(187);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock40_Internalname, "Otros", "", "", lblTextblock40_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV44NPacienteOtros", AV44NPacienteOtros);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 192,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteotros_Internalname, StringUtil.RTrim( AV44NPacienteOtros), StringUtil.RTrim( context.localUtil.Format( AV44NPacienteOtros, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(192);\"", "", "", "", "", edtavNpacienteotros_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_172_3H2e( true) ;
         }
         else
         {
            wb_table9_172_3H2e( false) ;
         }
      }

      protected void wb_table7_161_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock41_Internalname, "Complicaciones por Anestesía", "", "", lblTextblock41_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV40NPacienteAnestesiaComplica", AV40NPacienteAnestesiaComplica);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 166,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavNpacienteanestesiacomplica_Internalname, StringUtil.RTrim( AV40NPacienteAnestesiaComplica), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(166);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_161_3H2e( true) ;
         }
         else
         {
            wb_table7_161_3H2e( false) ;
         }
      }

      protected void wb_table6_122_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock28_Internalname, "Gestas", "", "", lblTextblock28_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock27_Internalname, "Partos", "", "", lblTextblock27_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock25_Internalname, "Cesáreas", "", "", lblTextblock25_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock26_Internalname, "Abortos", "", "", lblTextblock26_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV33NPacienteGesta", StringUtil.LTrim( StringUtil.Str( (decimal)(AV33NPacienteGesta), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 134,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientegesta_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV33NPacienteGesta), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV33NPacienteGesta), "ZZZ9")) : context.localUtil.Format( (decimal)(AV33NPacienteGesta), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(134);\"", "", "", "", "", edtavNpacientegesta_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV32NPacienteParto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV32NPacienteParto), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 136,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteparto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV32NPacienteParto), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV32NPacienteParto), "ZZZ9")) : context.localUtil.Format( (decimal)(AV32NPacienteParto), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(136);\"", "", "", "", "", edtavNpacienteparto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV34NPacienteCesarea", StringUtil.LTrim( StringUtil.Str( (decimal)(AV34NPacienteCesarea), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 138,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientecesarea_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV34NPacienteCesarea), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV34NPacienteCesarea), "ZZZ9")) : context.localUtil.Format( (decimal)(AV34NPacienteCesarea), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(138);\"", "", "", "", "", edtavNpacientecesarea_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV35NPacienteAborto", StringUtil.LTrim( StringUtil.Str( (decimal)(AV35NPacienteAborto), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 140,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteaborto_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV35NPacienteAborto), 4, 0, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV35NPacienteAborto), "ZZZ9")) : context.localUtil.Format( (decimal)(AV35NPacienteAborto), "ZZZ9")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(140);\"", "", "", "", "", edtavNpacienteaborto_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:21px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock22_Internalname, "Anestesía General", "", "", lblTextblock22_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock21_Internalname, "Anestesía Epidural", "", "", lblTextblock21_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Anestesía Raquídea", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock42_Internalname, "Otra Anestesía", "", "", lblTextblock42_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:24px\">") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV36NPacienteAnestesiaGeneral", StringUtil.Str( (decimal)(AV36NPacienteAnestesiaGeneral), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 152,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavNpacienteanestesiageneral_Internalname, StringUtil.Str( (decimal)(AV36NPacienteAnestesiaGeneral), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(152, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(152);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV37NPacienteAnestesiaEpidural", StringUtil.Str( (decimal)(AV37NPacienteAnestesiaEpidural), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 154,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavNpacienteanestesiaepidural_Internalname, StringUtil.Str( (decimal)(AV37NPacienteAnestesiaEpidural), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(154, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(154);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Check box */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV38NPacienteAnestesiaRaquidea", StringUtil.Str( (decimal)(AV38NPacienteAnestesiaRaquidea), 1, 0));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 156,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_checkbox_ctrl( context, chkavNpacienteanestesiaraquidea_Internalname, StringUtil.Str( (decimal)(AV38NPacienteAnestesiaRaquidea), 1, 0), "", 1, 1, "1", "", StyleString, ClassString, TempTags+" onclick=\"gx.fn.checkboxClick(156, this, 1, 0);gx.evt.onchange(this);\" "+" onblur=\""+"gx.num.valid_integer( this,',');"+";gx.evt.onblur(156);\"");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV39NPacienteAnestesiaOtro", AV39NPacienteAnestesiaOtro);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 158,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteanestesiaotro_Internalname, StringUtil.RTrim( AV39NPacienteAnestesiaOtro), StringUtil.RTrim( context.localUtil.Format( AV39NPacienteAnestesiaOtro, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(158);\"", "", "", "", "", edtavNpacienteanestesiaotro_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_122_3H2e( true) ;
         }
         else
         {
            wb_table6_122_3H2e( false) ;
         }
      }

      protected void wb_table5_99_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock30_Internalname, "Enfermedades", "", "", lblTextblock30_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV28NPacienteEnfermedad", AV28NPacienteEnfermedad);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 104,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavNpacienteenfermedad_Internalname, StringUtil.RTrim( AV28NPacienteEnfermedad), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(104);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock24_Internalname, "Medicamentos", "", "", lblTextblock24_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV29NPacienteMedicamento", AV29NPacienteMedicamento);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 109,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavNpacientemedicamento_Internalname, StringUtil.RTrim( AV29NPacienteMedicamento), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(109);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock29_Internalname, "Operaciones", "", "", lblTextblock29_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV30NPacienteOperacion", AV30NPacienteOperacion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 114,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavNpacienteoperacion_Internalname, StringUtil.RTrim( AV30NPacienteOperacion), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(114);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock23_Internalname, "Alergías", "", "", lblTextblock23_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Multiple line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV31NPacienteAlergia", AV31NPacienteAlergia);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 119,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_html_textarea( context, edtavNpacientealergia_Internalname, StringUtil.RTrim( AV31NPacienteAlergia), "", TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(119);\"", 0, 1, 1, 0, 80, "chr", 8, "row", StyleString, ClassString, "600", -1, "", true, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_99_3H2e( true) ;
         }
         else
         {
            wb_table5_99_3H2e( false) ;
         }
      }

      protected void wb_table4_71_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Dirección", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV23NPacienteDireccion", AV23NPacienteDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 76,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientedireccion_Internalname, StringUtil.RTrim( AV23NPacienteDireccion), StringUtil.RTrim( context.localUtil.Format( AV23NPacienteDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(76);\"", "", "", "", "", edtavNpacientedireccion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Correo", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24NPacienteCorreo", AV24NPacienteCorreo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 81,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientecorreo_Internalname, StringUtil.RTrim( AV24NPacienteCorreo), StringUtil.RTrim( context.localUtil.Format( AV24NPacienteCorreo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(81);\"", "", "", "", "", edtavNpacientecorreo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Facebook", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV25NPacienteFacebook", AV25NPacienteFacebook);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 86,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientefacebook_Internalname, StringUtil.RTrim( AV25NPacienteFacebook), StringUtil.RTrim( context.localUtil.Format( AV25NPacienteFacebook, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(86);\"", "", "", "", "", edtavNpacientefacebook_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 80, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Teléfono", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV26NPacienteTelefono", AV26NPacienteTelefono);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientetelefono_Internalname, StringUtil.RTrim( AV26NPacienteTelefono), StringUtil.RTrim( context.localUtil.Format( AV26NPacienteTelefono, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(91);\"", "", "", "", "", edtavNpacientetelefono_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Celular", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV27NPacienteCelular", AV27NPacienteCelular);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 96,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientecelular_Internalname, StringUtil.RTrim( AV27NPacienteCelular), StringUtil.RTrim( context.localUtil.Format( AV27NPacienteCelular, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(96);\"", "", "", "", "", edtavNpacientecelular_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_71_3H2e( true) ;
         }
         else
         {
            wb_table4_71_3H2e( false) ;
         }
      }

      protected void wb_table3_48_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock13_Internalname, "Estatura", "", "", lblTextblock13_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock12_Internalname, "Peso", "", "", lblTextblock12_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Profesión", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Religión", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18NPacienteEstatura", StringUtil.LTrim( StringUtil.Str( AV18NPacienteEstatura, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 60,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteestatura_Internalname, StringUtil.LTrim( StringUtil.NToC( AV18NPacienteEstatura, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV18NPacienteEstatura, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV18NPacienteEstatura, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(60);\"", "", "", "", "", edtavNpacienteestatura_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19NPacienteEstaturaEn", AV19NPacienteEstaturaEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 61,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavNpacienteestaturaen, cmbavNpacienteestaturaen_Internalname, AV19NPacienteEstaturaEn, 1, cmbavNpacienteestaturaen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(61);\"", "", true, "HLP_wp_npaciente.htm");
            cmbavNpacienteestaturaen.CurrentValue = AV19NPacienteEstaturaEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavNpacienteestaturaen_Internalname, "Values", (String)(cmbavNpacienteestaturaen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16NPacientePeso", StringUtil.LTrim( StringUtil.Str( AV16NPacientePeso, 17, 2)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientepeso_Internalname, StringUtil.LTrim( StringUtil.NToC( AV16NPacientePeso, 17, 2, ".", "")), ((1!=0) ? StringUtil.LTrim( context.localUtil.Format( AV16NPacientePeso, "ZZZZZZZZZZZZZ9.99")) : context.localUtil.Format( AV16NPacientePeso, "ZZZZZZZZZZZZZ9.99")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_decimal( this, ',','.','2');"+";gx.evt.onblur(63);\"", "", "", "", "", edtavNpacientepeso_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 17, "chr", 1, "row", 17, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "&nbsp;") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV17NPacientePesoEn", AV17NPacientePesoEn);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 64,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavNpacientepesoen, cmbavNpacientepesoen_Internalname, AV17NPacientePesoEn, 1, cmbavNpacientepesoen_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 2, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(64);\"", "", true, "HLP_wp_npaciente.htm");
            cmbavNpacientepesoen.CurrentValue = AV17NPacientePesoEn ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavNpacientepesoen_Internalname, "Values", (String)(cmbavNpacientepesoen.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20ProfesionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavProfesionid, dynavProfesionid_Internalname, StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0), 1, dynavProfesionid_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(66);\"", "", true, "HLP_wp_npaciente.htm");
            dynavProfesionid.CurrentValue = StringUtil.Str( (decimal)(AV20ProfesionId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavProfesionid_Internalname, "Values", (String)(dynavProfesionid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ReligionId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV21ReligionId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, dynavReligionid, dynavReligionid_Internalname, StringUtil.Str( (decimal)(AV21ReligionId), 9, 0), 1, dynavReligionid_Jsonclick, 0, "", "int", "", 1, 1, 0, 0, 70, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(68);\"", "", true, "HLP_wp_npaciente.htm");
            dynavReligionid.CurrentValue = StringUtil.Str( (decimal)(AV21ReligionId), 9, 0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, dynavReligionid_Internalname, "Values", (String)(dynavReligionid.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_3H2e( true) ;
         }
         else
         {
            wb_table3_48_3H2e( false) ;
         }
      }

      protected void wb_table2_11_3H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "center", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock19_Internalname, "Primer Nombre", "", "", lblTextblock19_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10NPacienteNombre1", AV10NPacienteNombre1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientenombre1_Internalname, StringUtil.RTrim( AV10NPacienteNombre1), StringUtil.RTrim( context.localUtil.Format( AV10NPacienteNombre1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(16);\"", "", "", "", "", edtavNpacientenombre1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock18_Internalname, "Segundo Nombre", "", "", lblTextblock18_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NPacienteNombre2", AV11NPacienteNombre2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientenombre2_Internalname, StringUtil.RTrim( AV11NPacienteNombre2), StringUtil.RTrim( context.localUtil.Format( AV11NPacienteNombre2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(20);\"", "", "", "", "", edtavNpacientenombre2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock17_Internalname, "Primer Apellido", "", "", lblTextblock17_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12NPacienteApellido1", AV12NPacienteApellido1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido1_Internalname, StringUtil.RTrim( AV12NPacienteApellido1), StringUtil.RTrim( context.localUtil.Format( AV12NPacienteApellido1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", "", "", "", "", edtavNpacienteapellido1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock16_Internalname, "Segundo Apellido", "", "", lblTextblock16_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13NPacienteApellido2", AV13NPacienteApellido2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido2_Internalname, StringUtil.RTrim( AV13NPacienteApellido2), StringUtil.RTrim( context.localUtil.Format( AV13NPacienteApellido2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavNpacienteapellido2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock15_Internalname, "Apellido de Casada", "", "", lblTextblock15_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14NPacienteApellido3", AV14NPacienteApellido3);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido3_Internalname, StringUtil.RTrim( AV14NPacienteApellido3), StringUtil.RTrim( context.localUtil.Format( AV14NPacienteApellido3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", "", "", "", edtavNpacienteapellido3_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock14_Internalname, "Fecha Nacimiento", "", "", lblTextblock14_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15NPacienteFechaNac", context.localUtil.Format(AV15NPacienteFechaNac, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtavNpacientefechanac_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientefechanac_Internalname, context.localUtil.Format(AV15NPacienteFechaNac, "99/99/99"), context.localUtil.Format( AV15NPacienteFechaNac, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(38);\"", "", "", "", "", edtavNpacientefechanac_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_npaciente.htm");
            GxWebStd.gx_bitmap( context, edtavNpacientefechanac_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(1==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_npaciente.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock20_Internalname, "Sexo", "", "", lblTextblock20_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_npaciente.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22NPacienteSexo", AV22NPacienteSexo);
            ClassString = "Attribute" ;
            StyleString = "" ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            /* ComboBox */
            GxWebStd.gx_combobox_ctrl1( context, cmbavNpacientesexo, cmbavNpacientesexo_Internalname, AV22NPacienteSexo, 1, cmbavNpacientesexo_Jsonclick, 0, "", "svchar", "", 1, 1, 0, 0, 1, "chr", 0, "", StyleString, ClassString, TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", true, "HLP_wp_npaciente.htm");
            cmbavNpacientesexo.CurrentValue = AV22NPacienteSexo ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbavNpacientesexo_Internalname, "Values", (String)(cmbavNpacientesexo.ToJavascriptSource()));
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_3H2e( true) ;
         }
         else
         {
            wb_table2_11_3H2e( false) ;
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
         PA3H2( ) ;
         WS3H2( ) ;
         WE3H2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1581669");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("wp_npaciente.js", "?1581670");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock19_Internalname = "TEXTBLOCK19" ;
         edtavNpacientenombre1_Internalname = "vNPACIENTENOMBRE1" ;
         lblTextblock18_Internalname = "TEXTBLOCK18" ;
         edtavNpacientenombre2_Internalname = "vNPACIENTENOMBRE2" ;
         lblTextblock17_Internalname = "TEXTBLOCK17" ;
         edtavNpacienteapellido1_Internalname = "vNPACIENTEAPELLIDO1" ;
         lblTextblock16_Internalname = "TEXTBLOCK16" ;
         edtavNpacienteapellido2_Internalname = "vNPACIENTEAPELLIDO2" ;
         lblTextblock15_Internalname = "TEXTBLOCK15" ;
         edtavNpacienteapellido3_Internalname = "vNPACIENTEAPELLIDO3" ;
         lblTextblock14_Internalname = "TEXTBLOCK14" ;
         edtavNpacientefechanac_Internalname = "vNPACIENTEFECHANAC" ;
         lblTextblock20_Internalname = "TEXTBLOCK20" ;
         cmbavNpacientesexo_Internalname = "vNPACIENTESEXO" ;
         tblTable2_Internalname = "TABLE2" ;
         lblTextblock13_Internalname = "TEXTBLOCK13" ;
         lblTextblock12_Internalname = "TEXTBLOCK12" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtavNpacienteestatura_Internalname = "vNPACIENTEESTATURA" ;
         cmbavNpacienteestaturaen_Internalname = "vNPACIENTEESTATURAEN" ;
         edtavNpacientepeso_Internalname = "vNPACIENTEPESO" ;
         cmbavNpacientepesoen_Internalname = "vNPACIENTEPESOEN" ;
         dynavProfesionid_Internalname = "vPROFESIONID" ;
         dynavReligionid_Internalname = "vRELIGIONID" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         edtavNpacientedireccion_Internalname = "vNPACIENTEDIRECCION" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtavNpacientecorreo_Internalname = "vNPACIENTECORREO" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavNpacientefacebook_Internalname = "vNPACIENTEFACEBOOK" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavNpacientetelefono_Internalname = "vNPACIENTETELEFONO" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavNpacientecelular_Internalname = "vNPACIENTECELULAR" ;
         tblTable4_Internalname = "TABLE4" ;
         lblTextblock30_Internalname = "TEXTBLOCK30" ;
         edtavNpacienteenfermedad_Internalname = "vNPACIENTEENFERMEDAD" ;
         lblTextblock24_Internalname = "TEXTBLOCK24" ;
         edtavNpacientemedicamento_Internalname = "vNPACIENTEMEDICAMENTO" ;
         lblTextblock29_Internalname = "TEXTBLOCK29" ;
         edtavNpacienteoperacion_Internalname = "vNPACIENTEOPERACION" ;
         lblTextblock23_Internalname = "TEXTBLOCK23" ;
         edtavNpacientealergia_Internalname = "vNPACIENTEALERGIA" ;
         tblTable5_Internalname = "TABLE5" ;
         lblTextblock28_Internalname = "TEXTBLOCK28" ;
         lblTextblock27_Internalname = "TEXTBLOCK27" ;
         lblTextblock25_Internalname = "TEXTBLOCK25" ;
         lblTextblock26_Internalname = "TEXTBLOCK26" ;
         edtavNpacientegesta_Internalname = "vNPACIENTEGESTA" ;
         edtavNpacienteparto_Internalname = "vNPACIENTEPARTO" ;
         edtavNpacientecesarea_Internalname = "vNPACIENTECESAREA" ;
         edtavNpacienteaborto_Internalname = "vNPACIENTEABORTO" ;
         lblTextblock22_Internalname = "TEXTBLOCK22" ;
         lblTextblock21_Internalname = "TEXTBLOCK21" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         lblTextblock42_Internalname = "TEXTBLOCK42" ;
         chkavNpacienteanestesiageneral_Internalname = "vNPACIENTEANESTESIAGENERAL" ;
         chkavNpacienteanestesiaepidural_Internalname = "vNPACIENTEANESTESIAEPIDURAL" ;
         chkavNpacienteanestesiaraquidea_Internalname = "vNPACIENTEANESTESIARAQUIDEA" ;
         edtavNpacienteanestesiaotro_Internalname = "vNPACIENTEANESTESIAOTRO" ;
         tblTable6_Internalname = "TABLE6" ;
         lblTextblock41_Internalname = "TEXTBLOCK41" ;
         edtavNpacienteanestesiacomplica_Internalname = "vNPACIENTEANESTESIACOMPLICA" ;
         tblTable7_Internalname = "TABLE7" ;
         lblTextblock34_Internalname = "TEXTBLOCK34" ;
         chkavNpacientefuma_Internalname = "vNPACIENTEFUMA" ;
         lblTextblock35_Internalname = "TEXTBLOCK35" ;
         edtavNpacientecigarros_Internalname = "vNPACIENTECIGARROS" ;
         lblTextblock36_Internalname = "TEXTBLOCK36" ;
         chkavNpacientealcohol_Internalname = "vNPACIENTEALCOHOL" ;
         lblTextblock40_Internalname = "TEXTBLOCK40" ;
         edtavNpacienteotros_Internalname = "vNPACIENTEOTROS" ;
         tblTable9_Internalname = "TABLE9" ;
         tblTable8_Internalname = "TABLE8" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbavNpacientesexo_Jsonclick = "" ;
         edtavNpacientefechanac_Jsonclick = "" ;
         edtavNpacienteapellido3_Jsonclick = "" ;
         edtavNpacienteapellido2_Jsonclick = "" ;
         edtavNpacienteapellido1_Jsonclick = "" ;
         edtavNpacientenombre2_Jsonclick = "" ;
         edtavNpacientenombre1_Jsonclick = "" ;
         dynavReligionid_Jsonclick = "" ;
         dynavProfesionid_Jsonclick = "" ;
         cmbavNpacientepesoen_Jsonclick = "" ;
         edtavNpacientepeso_Jsonclick = "" ;
         cmbavNpacienteestaturaen_Jsonclick = "" ;
         edtavNpacienteestatura_Jsonclick = "" ;
         edtavNpacientecelular_Jsonclick = "" ;
         edtavNpacientetelefono_Jsonclick = "" ;
         edtavNpacientefacebook_Jsonclick = "" ;
         edtavNpacientecorreo_Jsonclick = "" ;
         edtavNpacientedireccion_Jsonclick = "" ;
         edtavNpacienteanestesiaotro_Jsonclick = "" ;
         edtavNpacienteaborto_Jsonclick = "" ;
         edtavNpacientecesarea_Jsonclick = "" ;
         edtavNpacienteparto_Jsonclick = "" ;
         edtavNpacientegesta_Jsonclick = "" ;
         edtavNpacienteotros_Jsonclick = "" ;
         edtavNpacientecigarros_Jsonclick = "" ;
         bttButton1_Enabled = 1 ;
         chkavNpacientealcohol.Caption = "" ;
         chkavNpacientefuma.Caption = "" ;
         chkavNpacienteanestesiaraquidea.Caption = "" ;
         chkavNpacienteanestesiaepidural.Caption = "" ;
         chkavNpacienteanestesiageneral.Caption = "" ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Registro de notas de pacientes" ;
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
         AV5ClinicaCodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         GXKey = "" ;
         AV22NPacienteSexo = "" ;
         AV19NPacienteEstaturaEn = "" ;
         AV17NPacientePesoEn = "" ;
         gxdynajaxctrlcodr = new GeneXus.Utils.GxStringCollection();
         gxdynajaxctrldescr = new GeneXus.Utils.GxStringCollection();
         gxwrpcisep = "" ;
         scmdbuf = "" ;
         H003H2_A313ProfesionId = new int[1] ;
         H003H2_A314ProfesionNombre = new String[] {""} ;
         H003H2_A41ClinicaCodigo = new String[] {""} ;
         H003H3_A315ReligionId = new int[1] ;
         H003H3_A316ReligionNombre = new String[] {""} ;
         H003H3_A41ClinicaCodigo = new String[] {""} ;
         AV10NPacienteNombre1 = "" ;
         AV11NPacienteNombre2 = "" ;
         AV12NPacienteApellido1 = "" ;
         AV13NPacienteApellido2 = "" ;
         AV14NPacienteApellido3 = "" ;
         AV15NPacienteFechaNac = DateTime.MinValue ;
         AV23NPacienteDireccion = "" ;
         AV24NPacienteCorreo = "" ;
         AV25NPacienteFacebook = "" ;
         AV26NPacienteTelefono = "" ;
         AV27NPacienteCelular = "" ;
         AV28NPacienteEnfermedad = "" ;
         AV29NPacienteMedicamento = "" ;
         AV30NPacienteOperacion = "" ;
         AV31NPacienteAlergia = "" ;
         AV39NPacienteAnestesiaOtro = "" ;
         AV40NPacienteAnestesiaComplica = "" ;
         AV44NPacienteOtros = "" ;
         AV6Parametros = new SdtParametros(context);
         GXt_SdtParametros4 = new SdtParametros(context);
         AV8UsuarioCodigo = "" ;
         bttButton1_Jsonclick = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock34_Jsonclick = "" ;
         lblTextblock35_Jsonclick = "" ;
         lblTextblock36_Jsonclick = "" ;
         lblTextblock40_Jsonclick = "" ;
         lblTextblock41_Jsonclick = "" ;
         lblTextblock28_Jsonclick = "" ;
         lblTextblock27_Jsonclick = "" ;
         lblTextblock25_Jsonclick = "" ;
         lblTextblock26_Jsonclick = "" ;
         lblTextblock22_Jsonclick = "" ;
         lblTextblock21_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock42_Jsonclick = "" ;
         lblTextblock30_Jsonclick = "" ;
         lblTextblock24_Jsonclick = "" ;
         lblTextblock29_Jsonclick = "" ;
         lblTextblock23_Jsonclick = "" ;
         lblTextblock9_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock13_Jsonclick = "" ;
         lblTextblock12_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock19_Jsonclick = "" ;
         lblTextblock18_Jsonclick = "" ;
         lblTextblock17_Jsonclick = "" ;
         lblTextblock16_Jsonclick = "" ;
         lblTextblock15_Jsonclick = "" ;
         lblTextblock14_Jsonclick = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         lblTextblock20_Jsonclick = "" ;
         GXt_char3 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_npaciente__default(),
            new Object[][] {
                new Object[] {
               H003H2_A313ProfesionId, H003H2_A314ProfesionNombre, H003H2_A41ClinicaCodigo
               }
               , new Object[] {
               H003H3_A315ReligionId, H003H3_A316ReligionNombre, H003H3_A41ClinicaCodigo
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short AV33NPacienteGesta ;
      private short AV32NPacienteParto ;
      private short AV34NPacienteCesarea ;
      private short AV35NPacienteAborto ;
      private short AV36NPacienteAnestesiaGeneral ;
      private short AV37NPacienteAnestesiaEpidural ;
      private short AV38NPacienteAnestesiaRaquidea ;
      private short AV41NPacienteFuma ;
      private short AV42NPacienteCigarros ;
      private short AV43NPacienteAlcohol ;
      private short nGXWrapped ;
      private int gxdynajaxindex ;
      private int AV20ProfesionId ;
      private int AV21ReligionId ;
      private int AV9NPacienteId ;
      private int GXt_int5 ;
      private int bttButton1_Enabled ;
      private int idxLst ;
      private decimal AV18NPacienteEstatura ;
      private decimal AV16NPacientePeso ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String GXKey ;
      private String chkavNpacienteanestesiageneral_Internalname ;
      private String chkavNpacienteanestesiaepidural_Internalname ;
      private String chkavNpacienteanestesiaraquidea_Internalname ;
      private String chkavNpacientefuma_Internalname ;
      private String chkavNpacientealcohol_Internalname ;
      private String edtavNpacientenombre1_Internalname ;
      private String gxwrpcisep ;
      private String scmdbuf ;
      private String edtavNpacientenombre2_Internalname ;
      private String edtavNpacienteapellido1_Internalname ;
      private String edtavNpacienteapellido2_Internalname ;
      private String edtavNpacienteapellido3_Internalname ;
      private String edtavNpacientefechanac_Internalname ;
      private String cmbavNpacientesexo_Internalname ;
      private String edtavNpacienteestatura_Internalname ;
      private String cmbavNpacienteestaturaen_Internalname ;
      private String edtavNpacientepeso_Internalname ;
      private String cmbavNpacientepesoen_Internalname ;
      private String dynavProfesionid_Internalname ;
      private String dynavReligionid_Internalname ;
      private String edtavNpacientedireccion_Internalname ;
      private String edtavNpacientecorreo_Internalname ;
      private String edtavNpacientefacebook_Internalname ;
      private String edtavNpacientetelefono_Internalname ;
      private String edtavNpacientecelular_Internalname ;
      private String edtavNpacienteenfermedad_Internalname ;
      private String edtavNpacientemedicamento_Internalname ;
      private String edtavNpacienteoperacion_Internalname ;
      private String edtavNpacientealergia_Internalname ;
      private String edtavNpacientegesta_Internalname ;
      private String edtavNpacienteparto_Internalname ;
      private String edtavNpacientecesarea_Internalname ;
      private String edtavNpacienteaborto_Internalname ;
      private String edtavNpacienteanestesiaotro_Internalname ;
      private String edtavNpacienteanestesiacomplica_Internalname ;
      private String edtavNpacientecigarros_Internalname ;
      private String edtavNpacienteotros_Internalname ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String TempTags ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable8_Internalname ;
      private String tblTable9_Internalname ;
      private String lblTextblock34_Internalname ;
      private String lblTextblock34_Jsonclick ;
      private String lblTextblock35_Internalname ;
      private String lblTextblock35_Jsonclick ;
      private String edtavNpacientecigarros_Jsonclick ;
      private String lblTextblock36_Internalname ;
      private String lblTextblock36_Jsonclick ;
      private String lblTextblock40_Internalname ;
      private String lblTextblock40_Jsonclick ;
      private String edtavNpacienteotros_Jsonclick ;
      private String tblTable7_Internalname ;
      private String lblTextblock41_Internalname ;
      private String lblTextblock41_Jsonclick ;
      private String tblTable6_Internalname ;
      private String lblTextblock28_Internalname ;
      private String lblTextblock28_Jsonclick ;
      private String lblTextblock27_Internalname ;
      private String lblTextblock27_Jsonclick ;
      private String lblTextblock25_Internalname ;
      private String lblTextblock25_Jsonclick ;
      private String lblTextblock26_Internalname ;
      private String lblTextblock26_Jsonclick ;
      private String edtavNpacientegesta_Jsonclick ;
      private String edtavNpacienteparto_Jsonclick ;
      private String edtavNpacientecesarea_Jsonclick ;
      private String edtavNpacienteaborto_Jsonclick ;
      private String lblTextblock22_Internalname ;
      private String lblTextblock22_Jsonclick ;
      private String lblTextblock21_Internalname ;
      private String lblTextblock21_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock42_Internalname ;
      private String lblTextblock42_Jsonclick ;
      private String edtavNpacienteanestesiaotro_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblock30_Internalname ;
      private String lblTextblock30_Jsonclick ;
      private String lblTextblock24_Internalname ;
      private String lblTextblock24_Jsonclick ;
      private String lblTextblock29_Internalname ;
      private String lblTextblock29_Jsonclick ;
      private String lblTextblock23_Internalname ;
      private String lblTextblock23_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavNpacientedireccion_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavNpacientecorreo_Jsonclick ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavNpacientefacebook_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavNpacientetelefono_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavNpacientecelular_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock13_Internalname ;
      private String lblTextblock13_Jsonclick ;
      private String lblTextblock12_Internalname ;
      private String lblTextblock12_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavNpacienteestatura_Jsonclick ;
      private String cmbavNpacienteestaturaen_Jsonclick ;
      private String edtavNpacientepeso_Jsonclick ;
      private String cmbavNpacientepesoen_Jsonclick ;
      private String dynavProfesionid_Jsonclick ;
      private String dynavReligionid_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock19_Internalname ;
      private String lblTextblock19_Jsonclick ;
      private String edtavNpacientenombre1_Jsonclick ;
      private String lblTextblock18_Internalname ;
      private String lblTextblock18_Jsonclick ;
      private String edtavNpacientenombre2_Jsonclick ;
      private String lblTextblock17_Internalname ;
      private String lblTextblock17_Jsonclick ;
      private String edtavNpacienteapellido1_Jsonclick ;
      private String lblTextblock16_Internalname ;
      private String lblTextblock16_Jsonclick ;
      private String edtavNpacienteapellido2_Jsonclick ;
      private String lblTextblock15_Internalname ;
      private String lblTextblock15_Jsonclick ;
      private String edtavNpacienteapellido3_Jsonclick ;
      private String lblTextblock14_Internalname ;
      private String lblTextblock14_Jsonclick ;
      private String GXt_char2 ;
      private String edtavNpacientefechanac_Jsonclick ;
      private String GXt_char1 ;
      private String lblTextblock20_Internalname ;
      private String lblTextblock20_Jsonclick ;
      private String cmbavNpacientesexo_Jsonclick ;
      private String GXt_char3 ;
      private DateTime AV15NPacienteFechaNac ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV5ClinicaCodigo ;
      private String AV22NPacienteSexo ;
      private String AV19NPacienteEstaturaEn ;
      private String AV17NPacientePesoEn ;
      private String AV10NPacienteNombre1 ;
      private String AV11NPacienteNombre2 ;
      private String AV12NPacienteApellido1 ;
      private String AV13NPacienteApellido2 ;
      private String AV14NPacienteApellido3 ;
      private String AV23NPacienteDireccion ;
      private String AV24NPacienteCorreo ;
      private String AV25NPacienteFacebook ;
      private String AV26NPacienteTelefono ;
      private String AV27NPacienteCelular ;
      private String AV28NPacienteEnfermedad ;
      private String AV29NPacienteMedicamento ;
      private String AV30NPacienteOperacion ;
      private String AV31NPacienteAlergia ;
      private String AV39NPacienteAnestesiaOtro ;
      private String AV40NPacienteAnestesiaComplica ;
      private String AV44NPacienteOtros ;
      private String AV8UsuarioCodigo ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrlcodr ;
      private GeneXus.Utils.GxStringCollection gxdynajaxctrldescr ;
      private GXMasterPage MasterPageObj ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbavNpacientesexo ;
      private GXCombobox cmbavNpacienteestaturaen ;
      private GXCombobox cmbavNpacientepesoen ;
      private GXCombobox dynavProfesionid ;
      private GXCombobox dynavReligionid ;
      private GXCheckbox chkavNpacienteanestesiageneral ;
      private GXCheckbox chkavNpacienteanestesiaepidural ;
      private GXCheckbox chkavNpacienteanestesiaraquidea ;
      private GXCheckbox chkavNpacientefuma ;
      private GXCheckbox chkavNpacientealcohol ;
      private IDataStoreProvider pr_default ;
      private int[] H003H2_A313ProfesionId ;
      private String[] H003H2_A314ProfesionNombre ;
      private String[] H003H2_A41ClinicaCodigo ;
      private int[] H003H3_A315ReligionId ;
      private String[] H003H3_A316ReligionNombre ;
      private String[] H003H3_A41ClinicaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV6Parametros ;
      private SdtParametros GXt_SdtParametros4 ;
   }

   public class wp_npaciente__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH003H2 ;
          prmH003H2 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          Object[] prmH003H3 ;
          prmH003H3 = new Object[] {
          new Object[] {"@AV5ClinicaCodigo",SqlDbType.VarChar,10,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H003H2", "SELECT [ProfesionId], [ProfesionNombre], [ClinicaCodigo] FROM [Profesion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV5ClinicaCodigo ORDER BY [ProfesionNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H2,0,0,true,false )
             ,new CursorDef("H003H3", "SELECT [ReligionId], [ReligionNombre], [ClinicaCodigo] FROM [Religion] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV5ClinicaCodigo ORDER BY [ReligionNombre] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003H3,0,0,true,false )
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
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                break;
       }
    }

 }

}
