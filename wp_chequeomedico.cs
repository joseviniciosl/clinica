/*
               File: wp_ChequeoMedico
        Description: Chequeo Médico
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:8:18.18
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
   public class wp_chequeomedico : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_chequeomedico( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_chequeomedico( IGxContext context )
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
         cmbNPacienteSexo = new GXCombobox();
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
         PA3I2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START3I2( ) ;
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
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,false,false)\" onkeydown=\"gx.evt.onkeypress(null,false,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_chequeomedico.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
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
            WE3I2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT3I2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_ChequeoMedico" ;
      }

      public override String GetPgmdesc( )
      {
         return "Chequeo Médico" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("wp_chequeomedico.aspx")  ;
      }

      protected void WB3I0( )
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
            wb_table1_2_3I2( true) ;
         }
         else
         {
            wb_table1_2_3I2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_3I2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START3I2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Chequeo Médico", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP3I0( ) ;
      }

      protected void WS3I2( )
      {
         START3I2( ) ;
         EVT3I2( ) ;
      }

      protected void EVT3I2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'REGRESAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E113I2 */
                              E113I2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_36_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
                              edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
                              edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
                              edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
                              edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
                              edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
                              edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
                              cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A327NPacienteId = (int)(context.localUtil.CToN( cgiGet( edtNPacienteId_Internalname), ".", ",")) ;
                              A328NPacienteNombre1 = cgiGet( edtNPacienteNombre1_Internalname) ;
                              A329NPacienteNombre2 = cgiGet( edtNPacienteNombre2_Internalname) ;
                              A330NPacienteApellido1 = cgiGet( edtNPacienteApellido1_Internalname) ;
                              A331NPacienteApellido2 = cgiGet( edtNPacienteApellido2_Internalname) ;
                              A332NPacienteApellido3 = cgiGet( edtNPacienteApellido3_Internalname) ;
                              cmbNPacienteSexo.Name = cmbNPacienteSexo_Internalname ;
                              cmbNPacienteSexo.CurrentValue = cgiGet( cmbNPacienteSexo_Internalname) ;
                              A334NPacienteSexo = cgiGet( cmbNPacienteSexo_Internalname) ;
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E123I2 */
                                    E123I2 ();
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
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "CANCEL") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
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

      protected void WE3I2( )
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

      protected void PA3I2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
            }
            GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
            GXCCtl = "NPACIENTESEXO_" + sGXsfl_36_idx ;
            cmbNPacienteSexo.Name = GXCCtl ;
            cmbNPacienteSexo.WebTags = "" ;
            cmbNPacienteSexo.addItem("M", "Masculino", 0);
            cmbNPacienteSexo.addItem("F", "Femenino", 0);
            if ( ( cmbNPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A334NPacienteSexo)) )
            {
               A334NPacienteSexo = cmbNPacienteSexo.getItemValue(1) ;
            }
            GX_FocusControl = edtavNpacientenombre1_Internalname ;
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
         edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
         edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
         edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
         edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
         edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
         edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
         cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
         while ( nGXsfl_36_idx <= nRC_Grid1 )
         {
            sendrow_362( ) ;
            nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
            edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void Refresh( )
      {
         RF3I2( ) ;
         /* End function Refresh */
      }

      protected void RF3I2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 36 ;
         nGXsfl_36_idx = 1 ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
         edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
         edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
         edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
         edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
         edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
         cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
            edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
            /* Using cursor H003I2 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               A334NPacienteSexo = H003I2_A334NPacienteSexo[0] ;
               A332NPacienteApellido3 = H003I2_A332NPacienteApellido3[0] ;
               A331NPacienteApellido2 = H003I2_A331NPacienteApellido2[0] ;
               A330NPacienteApellido1 = H003I2_A330NPacienteApellido1[0] ;
               A329NPacienteNombre2 = H003I2_A329NPacienteNombre2[0] ;
               A328NPacienteNombre1 = H003I2_A328NPacienteNombre1[0] ;
               A327NPacienteId = H003I2_A327NPacienteId[0] ;
               A41ClinicaCodigo = H003I2_A41ClinicaCodigo[0] ;
               /* Execute user event: E123I2 */
               E123I2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 36 ;
            WB3I0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(-1) ;
      }

      protected void STRUP3I0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV10NPacienteNombre1 = cgiGet( edtavNpacientenombre1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10NPacienteNombre1", AV10NPacienteNombre1);
            AV11NPacienteNombre2 = cgiGet( edtavNpacientenombre2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NPacienteNombre2", AV11NPacienteNombre2);
            AV6NPacienteApellido1 = cgiGet( edtavNpacienteapellido1_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NPacienteApellido1", AV6NPacienteApellido1);
            AV7NPacienteApellido2 = cgiGet( edtavNpacienteapellido2_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7NPacienteApellido2", AV7NPacienteApellido2);
            AV8NPacienteApellido3 = cgiGet( edtavNpacienteapellido3_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8NPacienteApellido3", AV8NPacienteApellido3);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            /* Read subfile selected row values. */
            nGXsfl_36_idx = (short)(context.localUtil.CToN( cgiGet( subGrid1_Internalname+"_ROW"), ".", ",")) ;
            sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
            edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
            edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
            edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
            edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
            edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
            edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
            cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
            if ( nGXsfl_36_idx > 0 )
            {
               A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
               A327NPacienteId = (int)(context.localUtil.CToN( cgiGet( edtNPacienteId_Internalname), ".", ",")) ;
               A328NPacienteNombre1 = cgiGet( edtNPacienteNombre1_Internalname) ;
               A329NPacienteNombre2 = cgiGet( edtNPacienteNombre2_Internalname) ;
               A330NPacienteApellido1 = cgiGet( edtNPacienteApellido1_Internalname) ;
               A331NPacienteApellido2 = cgiGet( edtNPacienteApellido2_Internalname) ;
               A332NPacienteApellido3 = cgiGet( edtNPacienteApellido3_Internalname) ;
               cmbNPacienteSexo.Name = cmbNPacienteSexo_Internalname ;
               cmbNPacienteSexo.CurrentValue = cgiGet( cmbNPacienteSexo_Internalname) ;
               A334NPacienteSexo = cgiGet( cmbNPacienteSexo_Internalname) ;
            }
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void E113I2( )
      {
         /* 'Regresar' Routine */
         context.wjLoc = formatLink("principal.aspx")  ;
      }

      private void E123I2( )
      {
         /* Load Routine */
         sendrow_362( ) ;
      }

      protected void wb_table1_2_3I2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Chequeos Médicos", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
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
            wb_table2_11_3I2( true) ;
         }
         else
         {
            wb_table2_11_3I2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_3I2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
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
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Código") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Paciente") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre_1") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Nombre_2") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido_1") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido_2") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Apellido_3") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Sexo") ;
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
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A41ClinicaCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A327NPacienteId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A328NPacienteNombre1));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A329NPacienteNombre2));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A330NPacienteApellido1));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A331NPacienteApellido2));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A332NPacienteApellido3));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A334NPacienteSexo));
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
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 47,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Chequeo Médico", bttButton1_Jsonclick, 7, "Chequeo Médico", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e133i1_client"+"'", TempTags, "", 2, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(36), 3, 0)+","+"null"+");", "Regresar", bttButton2_Jsonclick, 5, "Regresar", "", StyleString, ClassString, 1, 1, "standard", "E\\'REGRESAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_3I2e( true) ;
         }
         else
         {
            wb_table1_2_3I2e( false) ;
         }
      }

      protected void wb_table2_11_3I2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "Primer Nombre", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Segundo Nombre", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Primer Apellido", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Segundo Apellido", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Apellido de Casada", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10NPacienteNombre1", AV10NPacienteNombre1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 25,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientenombre1_Internalname, StringUtil.RTrim( AV10NPacienteNombre1), StringUtil.RTrim( context.localUtil.Format( AV10NPacienteNombre1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(25);\"", "", "", "", "", edtavNpacientenombre1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11NPacienteNombre2", AV11NPacienteNombre2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 27,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacientenombre2_Internalname, StringUtil.RTrim( AV11NPacienteNombre2), StringUtil.RTrim( context.localUtil.Format( AV11NPacienteNombre2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(27);\"", "", "", "", "", edtavNpacientenombre2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 70, "chr", 1, "row", 70, 0, 0, 0, 1, -1, true, "left", "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6NPacienteApellido1", AV6NPacienteApellido1);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido1_Internalname, StringUtil.RTrim( AV6NPacienteApellido1), StringUtil.RTrim( context.localUtil.Format( AV6NPacienteApellido1, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(29);\"", "", "", "", "", edtavNpacienteapellido1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7NPacienteApellido2", AV7NPacienteApellido2);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 31,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido2_Internalname, StringUtil.RTrim( AV7NPacienteApellido2), StringUtil.RTrim( context.localUtil.Format( AV7NPacienteApellido2, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(31);\"", "", "", "", "", edtavNpacienteapellido2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8NPacienteApellido3", AV8NPacienteApellido3);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 33,'',false,'" + sGXsfl_36_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavNpacienteapellido3_Internalname, StringUtil.RTrim( AV8NPacienteApellido3), StringUtil.RTrim( context.localUtil.Format( AV8NPacienteApellido3, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(33);\"", "", "", "", "", edtavNpacienteapellido3_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 30, "chr", 1, "row", 30, 0, 0, 0, 1, -1, true, "left", "HLP_wp_ChequeoMedico.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_3I2e( true) ;
         }
         else
         {
            wb_table2_11_3I2e( false) ;
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
         PA3I2( ) ;
         WS3I2( ) ;
         WE3I2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1581867");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("wp_chequeomedico.js", "?1581867");
         /* End function include_jscripts */
      }

      protected void sendrow_362( )
      {
         WB3I0( ) ;
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
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A327NPacienteId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A327NPacienteId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteNombre1_Internalname,StringUtil.RTrim( A328NPacienteNombre1),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteNombre1_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteNombre2_Internalname,StringUtil.RTrim( A329NPacienteNombre2),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteNombre2_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)70,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteApellido1_Internalname,StringUtil.RTrim( A330NPacienteApellido1),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteApellido1_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteApellido2_Internalname,StringUtil.RTrim( A331NPacienteApellido2),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteApellido2_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtNPacienteApellido3_Internalname,StringUtil.RTrim( A332NPacienteApellido3),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtNPacienteApellido3_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)30,(short)0,(short)0,(short)36,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         ClassString = "Attribute" ;
         StyleString = "" ;
         if ( ( nGXsfl_36_idx == 1 ) && isAjaxCallMode( ) )
         {
            GXCCtl = "NPACIENTESEXO_" + sGXsfl_36_idx ;
            cmbNPacienteSexo.Name = GXCCtl ;
            cmbNPacienteSexo.WebTags = "" ;
            cmbNPacienteSexo.addItem("M", "Masculino", 0);
            cmbNPacienteSexo.addItem("F", "Femenino", 0);
            if ( ( cmbNPacienteSexo.ItemCount > 0 ) && String.IsNullOrEmpty(StringUtil.RTrim( A334NPacienteSexo)) )
            {
               A334NPacienteSexo = cmbNPacienteSexo.getItemValue(1) ;
            }
         }
         /* ComboBox */
         Grid1Row.AddColumnProperties("combobox", 2, isAjaxCallMode( ), new Object[] {(GXCombobox)cmbNPacienteSexo,(String)cmbNPacienteSexo_Internalname,(String)A334NPacienteSexo,(short)1,(String)cmbNPacienteSexo_Jsonclick,(short)0,(String)"",(String)"svchar",(String)"",(short)-1,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)0,(String)"px",(String)StyleString,(String)ClassString,(String)"",(String)"",(bool)true});
         cmbNPacienteSexo.CurrentValue = A334NPacienteSexo ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, cmbNPacienteSexo_Internalname, "Values", (String)(cmbNPacienteSexo.ToJavascriptSource()));
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_36_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_36_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_36_idx+1)) ;
         sGXsfl_36_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_36_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_36_idx ;
         edtNPacienteId_Internalname = "NPACIENTEID_"+sGXsfl_36_idx ;
         edtNPacienteNombre1_Internalname = "NPACIENTENOMBRE1_"+sGXsfl_36_idx ;
         edtNPacienteNombre2_Internalname = "NPACIENTENOMBRE2_"+sGXsfl_36_idx ;
         edtNPacienteApellido1_Internalname = "NPACIENTEAPELLIDO1_"+sGXsfl_36_idx ;
         edtNPacienteApellido2_Internalname = "NPACIENTEAPELLIDO2_"+sGXsfl_36_idx ;
         edtNPacienteApellido3_Internalname = "NPACIENTEAPELLIDO3_"+sGXsfl_36_idx ;
         cmbNPacienteSexo_Internalname = "NPACIENTESEXO_"+sGXsfl_36_idx ;
         /* End function sendrow_362 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavNpacientenombre1_Internalname = "vNPACIENTENOMBRE1" ;
         edtavNpacientenombre2_Internalname = "vNPACIENTENOMBRE2" ;
         edtavNpacienteapellido1_Internalname = "vNPACIENTEAPELLIDO1" ;
         edtavNpacienteapellido2_Internalname = "vNPACIENTEAPELLIDO2" ;
         edtavNpacienteapellido3_Internalname = "vNPACIENTEAPELLIDO3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton1_Internalname = "BUTTON1" ;
         bttButton2_Internalname = "BUTTON2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         cmbNPacienteSexo_Jsonclick = "" ;
         edtNPacienteApellido3_Jsonclick = "" ;
         edtNPacienteApellido2_Jsonclick = "" ;
         edtNPacienteApellido1_Jsonclick = "" ;
         edtNPacienteNombre2_Jsonclick = "" ;
         edtNPacienteNombre1_Jsonclick = "" ;
         edtNPacienteId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavNpacienteapellido3_Jsonclick = "" ;
         edtavNpacienteapellido2_Jsonclick = "" ;
         edtavNpacienteapellido1_Jsonclick = "" ;
         edtavNpacientenombre2_Jsonclick = "" ;
         edtavNpacientenombre1_Jsonclick = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Hoveringcolor = (int)(0x00C0C0) ;
         subGrid1_Selectioncolor = (int)(0x80FFFF) ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Chequeo Médico" ;
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
         edtNPacienteId_Internalname = "" ;
         edtNPacienteNombre1_Internalname = "" ;
         edtNPacienteNombre2_Internalname = "" ;
         edtNPacienteApellido1_Internalname = "" ;
         edtNPacienteApellido2_Internalname = "" ;
         edtNPacienteApellido3_Internalname = "" ;
         cmbNPacienteSexo_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A328NPacienteNombre1 = "" ;
         A329NPacienteNombre2 = "" ;
         A330NPacienteApellido1 = "" ;
         A331NPacienteApellido2 = "" ;
         A332NPacienteApellido3 = "" ;
         A334NPacienteSexo = "" ;
         GXKey = "" ;
         GXCCtl = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H003I2_A334NPacienteSexo = new String[] {""} ;
         H003I2_A332NPacienteApellido3 = new String[] {""} ;
         H003I2_A331NPacienteApellido2 = new String[] {""} ;
         H003I2_A330NPacienteApellido1 = new String[] {""} ;
         H003I2_A329NPacienteNombre2 = new String[] {""} ;
         H003I2_A328NPacienteNombre1 = new String[] {""} ;
         H003I2_A327NPacienteId = new int[1] ;
         H003I2_A41ClinicaCodigo = new String[] {""} ;
         AV10NPacienteNombre1 = "" ;
         AV11NPacienteNombre2 = "" ;
         AV6NPacienteApellido1 = "" ;
         AV7NPacienteApellido2 = "" ;
         AV8NPacienteApellido3 = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
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
         bttButton1_Jsonclick = "" ;
         bttButton2_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_chequeomedico__default(),
            new Object[][] {
                new Object[] {
               H003I2_A334NPacienteSexo, H003I2_A332NPacienteApellido3, H003I2_A331NPacienteApellido2, H003I2_A330NPacienteApellido1, H003I2_A329NPacienteNombre2, H003I2_A328NPacienteNombre1, H003I2_A327NPacienteId, H003I2_A41ClinicaCodigo
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
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short gxcookieaux ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int A327NPacienteId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int subGrid1_Selectioncolor ;
      private int subGrid1_Hoveringcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_36_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtNPacienteId_Internalname ;
      private String edtNPacienteNombre1_Internalname ;
      private String edtNPacienteNombre2_Internalname ;
      private String edtNPacienteApellido1_Internalname ;
      private String edtNPacienteApellido2_Internalname ;
      private String edtNPacienteApellido3_Internalname ;
      private String cmbNPacienteSexo_Internalname ;
      private String GXKey ;
      private String GXCCtl ;
      private String edtavNpacientenombre1_Internalname ;
      private String scmdbuf ;
      private String edtavNpacientenombre2_Internalname ;
      private String edtavNpacienteapellido1_Internalname ;
      private String edtavNpacienteapellido2_Internalname ;
      private String edtavNpacienteapellido3_Internalname ;
      private String subGrid1_Internalname ;
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
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String TempTags ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavNpacientenombre1_Jsonclick ;
      private String edtavNpacientenombre2_Jsonclick ;
      private String edtavNpacienteapellido1_Jsonclick ;
      private String edtavNpacienteapellido2_Jsonclick ;
      private String edtavNpacienteapellido3_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtNPacienteId_Jsonclick ;
      private String edtNPacienteNombre1_Jsonclick ;
      private String edtNPacienteNombre2_Jsonclick ;
      private String edtNPacienteApellido1_Jsonclick ;
      private String edtNPacienteApellido2_Jsonclick ;
      private String edtNPacienteApellido3_Jsonclick ;
      private String cmbNPacienteSexo_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private String A41ClinicaCodigo ;
      private String A328NPacienteNombre1 ;
      private String A329NPacienteNombre2 ;
      private String A330NPacienteApellido1 ;
      private String A331NPacienteApellido2 ;
      private String A332NPacienteApellido3 ;
      private String A334NPacienteSexo ;
      private String AV10NPacienteNombre1 ;
      private String AV11NPacienteNombre2 ;
      private String AV6NPacienteApellido1 ;
      private String AV7NPacienteApellido2 ;
      private String AV8NPacienteApellido3 ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private GXCombobox cmbNPacienteSexo ;
      private IDataStoreProvider pr_default ;
      private String[] H003I2_A334NPacienteSexo ;
      private String[] H003I2_A332NPacienteApellido3 ;
      private String[] H003I2_A331NPacienteApellido2 ;
      private String[] H003I2_A330NPacienteApellido1 ;
      private String[] H003I2_A329NPacienteNombre2 ;
      private String[] H003I2_A328NPacienteNombre1 ;
      private int[] H003I2_A327NPacienteId ;
      private String[] H003I2_A41ClinicaCodigo ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
   }

   public class wp_chequeomedico__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH003I2 ;
          prmH003I2 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("H003I2", "SELECT [NPacienteSexo], [NPacienteApellido3], [NPacienteApellido2], [NPacienteApellido1], [NPacienteNombre2], [NPacienteNombre1], [NPacienteId], [ClinicaCodigo] FROM [NotaPaciente] WITH (NOLOCK) ORDER BY [ClinicaCodigo], [NPacienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH003I2,11,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
       }
    }

 }

}
