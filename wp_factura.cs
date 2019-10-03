/*
               File: wp_factura
        Description: Facturación
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:7:55.54
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
   public class wp_factura : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public wp_factura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public wp_factura( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref int aP0_ConsultaId ,
                           ref int aP1_FacturaId ,
                           ref int aP2_PacienteId )
      {
         this.AV7ConsultaId = aP0_ConsultaId;
         this.AV8FacturaId = aP1_FacturaId;
         this.AV13PacienteId = aP2_PacienteId;
         executePrivate();
         aP0_ConsultaId=this.AV7ConsultaId;
         aP1_FacturaId=this.AV8FacturaId;
         aP2_PacienteId=this.AV13PacienteId;
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
               nGXsfl_75_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_75_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_75_idx, sGXsfl_75_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               Gx_time = context.localUtil.Time( ) ;
               Gx_date = DateTimeUtil.Today( ) ;
               context.Gx_err = 0 ;
               AV6ClinicaCodigo = GetNextPar( ) ;
               AV8FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( AV6ClinicaCodigo, AV8FacturaId) ;
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
               AV7ConsultaId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV8FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
                  AV13PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PacienteId), 9, 0)));
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
         PA2O2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START2O2( ) ;
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
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7ConsultaId) + "," + UrlEncode("" +AV8FacturaId) + "," + UrlEncode("" +AV13PacienteId) ;
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("wp_factura.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "vCLINICACODIGO", StringUtil.RTrim( AV6ClinicaCodigo));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            WebComp_Webcomp1.componentjscripts();
         }
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE2O2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT2O2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return false ;
      }

      public override String GetPgmname( )
      {
         return "wp_factura" ;
      }

      public override String GetPgmdesc( )
      {
         return "Facturación" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
         GXEncryptionTmp = UrlEncode("" +AV7ConsultaId) + "," + UrlEncode("" +AV8FacturaId) + "," + UrlEncode("" +AV13PacienteId) ;
         return formatLink("wp_factura.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
      }

      protected void WB2O0( )
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
            wb_table1_2_2O2( true) ;
         }
         else
         {
            wb_table1_2_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock2_Internalname, "Primer Nombre", "", "", lblTextblock2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
         }
         wbLoad = true ;
      }

      protected void START2O2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_8-58720", 0) ;
         Form.Meta.addItem("Description", "Facturación", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            OldWebcomp1 = cgiGet( "W0094") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "OldWebcomp1";
               WebComp_Webcomp1_Component = OldWebcomp1 ;
               WebComp_Webcomp1.componentrestorestate("W0094", "");
            }
         }
         wbErr = false ;
         STRUP2O0( ) ;
      }

      protected void WS2O2( )
      {
         START2O2( ) ;
         EVT2O2( ) ;
      }

      protected void EVT2O2( )
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
                           else if ( StringUtil.StrCmp(sEvt, "'CLIENTE'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E112O2 */
                              E112O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'RETORNAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E122O2 */
                              E122O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'FACTURAR'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E132O2 */
                              E132O2 ();
                           }
                           else if ( StringUtil.StrCmp(sEvt, "'PAGO'") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* Execute user event: E142O2 */
                              E142O2 ();
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
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 6), "CANCEL") == 0 ) )
                           {
                              nGXsfl_75_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
                              edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
                              edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
                              edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
                              edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
                              edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
                              edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
                              edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
                              edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
                              A41ClinicaCodigo = cgiGet( edtClinicaCodigo_Internalname) ;
                              A185FacturaId = (int)(context.localUtil.CToN( cgiGet( edtFacturaId_Internalname), ".", ",")) ;
                              A248FacturaDId = (int)(context.localUtil.CToN( cgiGet( edtFacturaDId_Internalname), ".", ",")) ;
                              A30ArticuloCodigo = cgiGet( edtArticuloCodigo_Internalname) ;
                              A31ArticuloDescripcion = cgiGet( edtArticuloDescripcion_Internalname) ;
                              A249FacturaDPrecio = context.localUtil.CToN( cgiGet( edtFacturaDPrecio_Internalname), ".", ",") ;
                              A250FacturaDCantidad = context.localUtil.CToN( cgiGet( edtFacturaDCantidad_Internalname), ".", ",") ;
                              A251FacturaDTotal = context.localUtil.CToN( cgiGet( edtFacturaDTotal_Internalname), ".", ",") ;
                              OldWebcomp1 = cgiGet( "W0094") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
                              {
                                 WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
                                 WebComp_Webcomp1.ComponentInit();
                                 WebComp_Webcomp1.Name = "OldWebcomp1";
                                 WebComp_Webcomp1_Component = OldWebcomp1 ;
                                 WebComp_Webcomp1.componentrestorestate("W0094", "");
                              }
                              OldWebcomp1 = cgiGet( "W0094") ;
                              if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
                              {
                                 WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
                                 WebComp_Webcomp1.ComponentInit();
                                 WebComp_Webcomp1.Name = "OldWebcomp1";
                                 WebComp_Webcomp1_Component = OldWebcomp1 ;
                                 WebComp_Webcomp1.componentrestorestate("W0094", "");
                              }
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E152O2 */
                                    E152O2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E162O2 */
                                    E162O2 ();
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
                     else if ( StringUtil.StrCmp(sEvtType, "W") == 0 )
                     {
                        sEvtType = StringUtil.Left( sEvt, 4) ;
                        sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                        nCmpId = (short)(NumberUtil.Val( sEvtType, ".")) ;
                        if ( nCmpId == 94 )
                        {
                           OldWebcomp1 = cgiGet( "W0094") ;
                           if ( ( StringUtil.Len( OldWebcomp1) == 0 ) || ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 ) )
                           {
                              WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
                              WebComp_Webcomp1.ComponentInit();
                              WebComp_Webcomp1.Name = "OldWebcomp1";
                              WebComp_Webcomp1_Component = OldWebcomp1 ;
                           }
                           if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
                           {
                              WebComp_Webcomp1.componentprocess("W0094", "", sEvt);
                           }
                           WebComp_Webcomp1_Component = OldWebcomp1 ;
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE2O2( )
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

      protected void PA2O2( )
      {
         if ( nDonePA == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
            {
               GxWebError = 1 ;
               context.HttpContext.Response.StatusDescription = 403.ToString();
               context.WriteHtmlText( "<title>403 Forbidden</title>") ;
               context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
               context.WriteHtmlText( "<p /><hr />") ;
            }
            if ( ( GxWebError == 0 ) && ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
               GXDecQS = Crypto.Decrypt64( context.GetRequestQueryString( ), GXKey) ;
               if ( StringUtil.StrCmp(StringUtil.Right( GXDecQS, 6), Crypto.CheckSum( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6)), 6)) == 0 )
               {
                  SetQueryString( StringUtil.Left( GXDecQS, (short)(StringUtil.Len( GXDecQS)-6))) ;
               }
               else
               {
                  GxWebError = 1 ;
                  context.HttpContext.Response.StatusDescription = 403.ToString();
                  context.WriteHtmlText( "<title>403 Forbidden</title>") ;
                  context.WriteHtmlText( "<h1>403 Forbidden</h1>") ;
                  context.WriteHtmlText( "<p /><hr />") ;
               }
            }
            if ( ! ( isAjaxCallMode( ) || isFullAjaxMode( ) ) )
            {
               if ( nGotPars == 0 )
               {
                  entryPointCalled = false ;
                  gxfirstwebparm = GetNextPar( ) ;
                  if ( ! entryPointCalled )
                  {
                     AV7ConsultaId = (int)(NumberUtil.Val( gxfirstwebparm, ".")) ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
                     if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
                     {
                        AV8FacturaId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
                        AV13PacienteId = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PacienteId), 9, 0)));
                     }
                  }
               }
            }
            GX_FocusControl = edtavClientecodigo_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_75_idx ,
                                       String sGXsfl_75_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
         edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
         while ( nGXsfl_75_idx <= nRC_Grid1 )
         {
            sendrow_752( ) ;
            nGXsfl_75_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_75_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_75_idx+1)) ;
            sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
            edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
            edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
            edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( String AV6ClinicaCodigo ,
                                        int AV8FacturaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         RF2O2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF2O2( ) ;
         /* End function Refresh */
      }

      protected void RF2O2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 75 ;
         nGXsfl_75_idx = 1 ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
         edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( 1 != 0 )
            {
               if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
               {
                  WebComp_Webcomp1.componentstart();
               }
            }
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
            edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
            edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
            edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
            edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
            edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
            edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
            edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
            /* Using cursor H002O2 */
            pr_default.execute(0, new Object[] {AV6ClinicaCodigo, AV8FacturaId});
            while ( (pr_default.getStatus(0) != 101) )
            {
               A31ArticuloDescripcion = H002O2_A31ArticuloDescripcion[0] ;
               A30ArticuloCodigo = H002O2_A30ArticuloCodigo[0] ;
               A248FacturaDId = H002O2_A248FacturaDId[0] ;
               A185FacturaId = H002O2_A185FacturaId[0] ;
               A41ClinicaCodigo = H002O2_A41ClinicaCodigo[0] ;
               A250FacturaDCantidad = H002O2_A250FacturaDCantidad[0] ;
               A249FacturaDPrecio = H002O2_A249FacturaDPrecio[0] ;
               A31ArticuloDescripcion = H002O2_A31ArticuloDescripcion[0] ;
               A251FacturaDTotal = (decimal)(A249FacturaDPrecio*A250FacturaDCantidad) ;
               /* Execute user event: E162O2 */
               E162O2 ();
               pr_default.readNext(0);
            }
            pr_default.close(0);
            wbEnd = 75 ;
            WB2O0( ) ;
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

      protected void STRUP2O0( )
      {
         /* Before Start, stand alone formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         edtavConsultaid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavConsultaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavConsultaid_Enabled), 5, 0)));
         edtavPacienteid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacienteid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacienteid_Enabled), 5, 0)));
         edtavPacientenombrec_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavPacientenombrec_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavPacientenombrec_Enabled), 5, 0)));
         edtavFacturaid_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFacturaid_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFacturaid_Enabled), 5, 0)));
         edtavFacturafecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFacturafecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFacturafecha_Enabled), 5, 0)));
         edtavFacturahora_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavFacturahora_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtavFacturahora_Enabled), 5, 0)));
         imgImage1_Link = "javascript:"+"gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vCLINICACODIGO"+"'), id:'"+"vCLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"vCLIENTECODIGO"+"'), id:'"+"vCLIENTECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImage1_Internalname, "Link", imgImage1_Link);
         imgImage1_Link = "javascript:"+"gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vCLINICACODIGO"+"'), id:'"+"vCLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"vCLIENTECODIGO"+"'), id:'"+"vCLIENTECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgImage1_Internalname, "Link", imgImage1_Link);
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E152O2 */
         E152O2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            AV18PacienteNombreC = cgiGet( edtavPacientenombrec_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PacienteNombreC", AV18PacienteNombreC);
            AV19FacturaFecha = context.localUtil.CToD( cgiGet( edtavFacturafecha_Internalname), 2) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
            AV20FacturaHora = cgiGet( edtavFacturahora_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
            AV21ClienteCodigo = cgiGet( edtavClientecodigo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ClienteCodigo", AV21ClienteCodigo);
            AV22ClienteNombre = cgiGet( edtavClientenombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ClienteNombre", AV22ClienteNombre);
            AV24ClienteDireccion = cgiGet( edtavClientedireccion_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ClienteDireccion", AV24ClienteDireccion);
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ".", ",")) ;
            OldWebcomp1 = cgiGet( "W0094") ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( WebComp_Webcomp1_Component)) && ! String.IsNullOrEmpty(StringUtil.RTrim( OldWebcomp1)) )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", OldWebcomp1, new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "OldWebcomp1";
               WebComp_Webcomp1_Component = OldWebcomp1 ;
               WebComp_Webcomp1.componentrestorestate("W0094", "");
            }
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
         /* Execute user event: E152O2 */
         E152O2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E152O2( )
      {
         /* Start Routine */
         bttButton5_Jsonclick = "confirm('¿Seguro de retornar? Se cancelará el proceso de facturación, sino se finalizo el proceso de facturación.')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton5_Internalname, "Jsonclick", bttButton5_Jsonclick);
         bttButton4_Jsonclick = "confirm('¿Seguro de iniciar el proceso de facturación?')" ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttButton4_Internalname, "Jsonclick", bttButton4_Jsonclick);
         GXt_SdtParametros3 = AV5Parametros ;
         new pobtienesesion(context ).execute( out  GXt_SdtParametros3) ;
         AV5Parametros = GXt_SdtParametros3 ;
         AV6ClinicaCodigo = AV5Parametros.gxTpr_Pclinicacodigo ;
         AV26CajaCodigo = AV5Parametros.gxTpr_Pcajacodigo ;
         new pobtieneinfopaciente(context ).execute( ref  AV6ClinicaCodigo, ref  AV13PacienteId, ref  AV15PacienteNombre1, ref  AV16PacienteNombre2, ref  AV9PacienteApellido1, ref  AV10PacienteApellido2, ref  AV11PacienteApellido3, ref  AV12PacienteGenero, ref  AV14PacienteNacimiento, ref  AV17ConsultaEdad) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PacienteId), 9, 0)));
         AV18PacienteNombreC = AV15PacienteNombre1 + " " + AV16PacienteNombre2 + ", " + AV9PacienteApellido1 + " " + AV10PacienteApellido2 + " " + AV11PacienteApellido3 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PacienteNombreC", AV18PacienteNombreC);
         AV19FacturaFecha = Gx_date ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
         AV20FacturaHora = Gx_time ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
         GXt_int4 = 0 ;
         GXt_char2 = "" ;
         GXt_int5 = 0 ;
         GXt_char1 = "CF" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_int8 = 1 ;
         new pregistrafactura(context ).execute( ref  AV6ClinicaCodigo, ref  AV8FacturaId, ref  AV19FacturaFecha, ref  AV20FacturaHora, ref  GXt_int4, ref  GXt_char2, ref  GXt_int5, ref  GXt_char1, ref  AV7ConsultaId, ref  GXt_char6, ref  GXt_char7, ref  GXt_int8) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
      }

      protected void E112O2( )
      {
         /* 'Cliente' Routine */
         new oobtienecliente(context ).execute( ref  AV6ClinicaCodigo, ref  AV21ClienteCodigo, ref  AV22ClienteNombre, ref  AV24ClienteDireccion) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ClienteCodigo", AV21ClienteCodigo);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ClienteNombre", AV22ClienteNombre);
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ClienteDireccion", AV24ClienteDireccion);
      }

      protected void E122O2( )
      {
         /* 'Retornar' Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV25FacturaEstado == 0 )
         {
            GXt_int8 = 3 ;
            GXt_char7 = "" ;
            GXt_int5 = 0 ;
            GXt_char6 = "CF" ;
            GXt_char2 = "" ;
            GXt_char1 = "" ;
            GXt_int4 = 3 ;
            new pregistrafactura(context ).execute( ref  AV6ClinicaCodigo, ref  AV8FacturaId, ref  AV19FacturaFecha, ref  AV20FacturaHora, ref  GXt_int8, ref  GXt_char7, ref  GXt_int5, ref  GXt_char6, ref  AV7ConsultaId, ref  GXt_char2, ref  GXt_char1, ref  GXt_int4) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         }
         context.wjLoc = formatLink("wp_paciente_fac.aspx")  ;
      }

      protected void E132O2( )
      {
         /* 'Facturar' Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV25FacturaEstado == 0 )
         {
            new pvalidapagofactura(context ).execute( ref  AV6ClinicaCodigo, ref  AV8FacturaId, ref  AV29Flag) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
            if ( AV29Flag == 1 )
            {
               new oobtienecorrelativosat(context ).execute( ref  AV6ClinicaCodigo, ref  AV26CajaCodigo, ref  AV28FacturaDocto, ref  AV27FacturaSerie, ref  AV29Flag) ;
               if ( AV29Flag == 1 )
               {
                  GXt_int8 = 1 ;
                  GXt_char7 = "" ;
                  GXt_char6 = "" ;
                  GXt_int4 = 2 ;
                  new pregistrafactura(context ).execute( ref  AV6ClinicaCodigo, ref  AV8FacturaId, ref  AV19FacturaFecha, ref  AV20FacturaHora, ref  GXt_int8, ref  AV27FacturaSerie, ref  AV28FacturaDocto, ref  AV21ClienteCodigo, ref  AV7ConsultaId, ref  GXt_char7, ref  GXt_char6, ref  GXt_int4) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ClienteCodigo", AV21ClienteCodigo);
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
                  if ( String.IsNullOrEmpty(StringUtil.RTrim( context.GetCookie( "GX_SESSION_ID"))) )
                  {
                     gxcookieaux = context.SetCookie( "GX_SESSION_ID", Crypto.Encrypt64( Crypto.GetEncryptionKey( ), Crypto.GetServerKey( )), "", (DateTime)(DateTime.MinValue), "", 0) ;
                  }
                  GXKey = Crypto.Decrypt64( context.GetCookie( "GX_SESSION_ID"), Crypto.GetServerKey( )) ;
                  GXEncryptionTmp = UrlEncode(StringUtil.RTrim(AV6ClinicaCodigo)) + "," + UrlEncode("" +AV8FacturaId) ;
                  context.wjLoc = formatLink("arfactura.aspx") + "?" + Crypto.Encrypt64( GXEncryptionTmp+Crypto.CheckSum( GXEncryptionTmp, 6), GXKey) ;
               }
            }
            else
            {
               GX_msglist.addItem("Factura no ha sido pagada en su totalidad.");
            }
         }
      }

      protected void E142O2( )
      {
         /* 'Pago' Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
         if ( AV25FacturaEstado == 0 )
         {
            /* Object Property */
            if ( StringUtil.StrCmp(WebComp_Webcomp1_Component, "wc_Pagos") != 0 )
            {
               WebComp_Webcomp1 = getWebComponent(GetType(), "GeneXus.Programs", "wc_pagos", new Object[] {context} );
               WebComp_Webcomp1.ComponentInit();
               WebComp_Webcomp1.Name = "wc_Pagos";
               WebComp_Webcomp1_Component = "wc_Pagos" ;
            }
            if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.setjustcreated();
            }
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.componentprepare(new Object[] {(String)"W0094",(String)"",(String)AV6ClinicaCodigo,(int)AV8FacturaId,(int)AV13PacienteId,(int)AV7ConsultaId});
               WebComp_Webcomp1.componentbind(new Object[] {(String)"",(String)"vFACTURAID",(String)"vPACIENTEID",(String)"vCONSULTAID"});
            }
         }
      }

      protected void S112( )
      {
         /* 'VALIDA ESTATUS' Routine */
         /* Using cursor H002O3 */
         pr_default.execute(1, new Object[] {AV6ClinicaCodigo, AV8FacturaId});
         while ( (pr_default.getStatus(1) != 101) )
         {
            A185FacturaId = H002O3_A185FacturaId[0] ;
            A41ClinicaCodigo = H002O3_A41ClinicaCodigo[0] ;
            A188FacturaEstado = H002O3_A188FacturaEstado[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A188FacturaEstado", StringUtil.Str( (decimal)(A188FacturaEstado), 1, 0));
            AV25FacturaEstado = A188FacturaEstado ;
            /* Exiting from a For First loop. */
            if (true) break;
         }
         pr_default.close(1);
      }

      private void E162O2( )
      {
         /* Load Routine */
         sendrow_752( ) ;
      }

      protected void wb_table1_2_2O2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "Facturación de Pacientes", "", "", lblTextblock1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
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
            wb_table2_11_2O2( true) ;
         }
         else
         {
            wb_table2_11_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table2_11_2O2e( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"75\">") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Factura") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Línea") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Artículo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Precio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Cantidad") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+"font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:bold; font-style:normal;"+"\" "+">") ;
               context.SendWebValue( "Total_Linea") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A30ArticuloCodigo));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A31ArticuloDescripcion));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", ((subGrid1_Allowcollapsing==1) ? "true" : "false"));
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 75 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_75_idx-1) ;
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
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 88,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton2_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(75), 3, 0)+","+"null"+");", "Nuevo Cliente", bttButton2_Jsonclick, 7, "Nuevo Cliente", "", StyleString, ClassString, 1, 1, "standard", "'"+""+"'"+",false,"+"'"+"e172o1_client"+"'", TempTags, "", 2, "HLP_wp_factura.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 89,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton3_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(75), 3, 0)+","+"null"+");", "Pago", bttButton3_Jsonclick, 5, "Pago", "", StyleString, ClassString, 1, 1, "standard", "E\\'PAGO\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_factura.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 90,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton4_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(75), 3, 0)+","+"null"+");", "Facturar", bttButton4_Jsonclick, 5, "Facturar", "", StyleString, ClassString, 1, 1, "standard", "E\\'FACTURAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_factura.htm");
            context.WriteHtmlText( "&nbsp;") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 91,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton5_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(75), 3, 0)+","+"null"+");", "Retornar", bttButton5_Jsonclick, 5, "Retornar", "", StyleString, ClassString, 1, 1, "standard", "E\\'RETORNAR\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* WebComponent */
            GxWebStd.gx_hidden_field( context, "W0094"+"", StringUtil.RTrim( WebComp_Webcomp1_Component));
            context.WriteHtmlText( "<div") ;
            context.WriteHtmlText( " id=\""+"gxHTMLWrpW0094"+""+"\""+"") ;
            context.WriteHtmlText( ">") ;
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspStartCmp("gxHTMLWrpW0094"+"");
               }
               WebComp_Webcomp1.componentdraw();
               if ( StringUtil.StrCmp(OldWebcomp1, WebComp_Webcomp1_Component) != 0 )
               {
                  context.httpAjaxContext.ajax_rspEndCmp();
               }
            }
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_2O2e( true) ;
         }
         else
         {
            wb_table1_2_2O2e( false) ;
         }
      }

      protected void wb_table2_11_2O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table3_14_2O2( true) ;
         }
         else
         {
            wb_table3_14_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table3_14_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table4_26_2O2( true) ;
         }
         else
         {
            wb_table4_26_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table4_26_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            wb_table5_34_2O2( true) ;
         }
         else
         {
            wb_table5_34_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table5_34_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table6_50_2O2( true) ;
         }
         else
         {
            wb_table6_50_2O2( false) ;
         }
         return  ;
      }

      protected void wb_table6_50_2O2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_11_2O2e( true) ;
         }
         else
         {
            wb_table2_11_2O2e( false) ;
         }
      }

      protected void wb_table6_50_2O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"width:52px\">") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock9_Internalname, "Cliente", "", "", lblTextblock9_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:3px\">") ;
            /* Static images/pictures */
            ClassString = "Image" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "42cb9bf4-7a07-40fe-892b-9db7e539737e", "", "Fantastic"), imgImage1_Link, "", "", "Fantastic", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV21ClienteCodigo", AV21ClienteCodigo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 57,'',false,'" + sGXsfl_75_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavClientecodigo_Internalname, StringUtil.RTrim( AV21ClienteCodigo), StringUtil.RTrim( context.localUtil.Format( AV21ClienteCodigo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(57);\"", "", "", "", "", edtavClientecodigo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 10, "chr", 1, "row", 10, 0, 0, 0, 1, -1, true, "left", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 59,'',false,'',0)\"" ;
            ClassString = "Button" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttButton1_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(75), 3, 0)+","+"null"+");", ">|", bttButton1_Jsonclick, 5, ">|", "", StyleString, ClassString, 1, 1, "standard", "E\\'CLIENTE\\'.", TempTags, "", context.GetButtonType( ), "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock8_Internalname, "Nombre", "", "", lblTextblock8_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV22ClienteNombre", AV22ClienteNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_75_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavClientenombre_Internalname, StringUtil.RTrim( AV22ClienteNombre), StringUtil.RTrim( context.localUtil.Format( AV22ClienteNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"", "", "", "", "", edtavClientenombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 100, 0, 0, 0, 1, -1, true, "left", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock3_Internalname, "Dirección", "", "", lblTextblock3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV24ClienteDireccion", AV24ClienteDireccion);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'" + sGXsfl_75_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavClientedireccion_Internalname, StringUtil.RTrim( AV24ClienteDireccion), StringUtil.RTrim( context.localUtil.Format( AV24ClienteDireccion, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(72);\"", "", "", "", "", edtavClientedireccion_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 80, "chr", 1, "row", 120, 0, 0, 0, 1, -1, true, "left", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_50_2O2e( true) ;
         }
         else
         {
            wb_table6_50_2O2e( false) ;
         }
      }

      protected void wb_table5_34_2O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock4_Internalname, "Factura Id", "", "", lblTextblock4_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavFacturaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8FacturaId), 9, 0, ".", "")), ((edtavFacturaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV8FacturaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV8FacturaId), "ZZZZZZZZ9")), "", "", "", "", "", edtavFacturaid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavFacturaid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock10_Internalname, "Fecha", "", "", lblTextblock10_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV19FacturaFecha", context.localUtil.Format(AV19FacturaFecha, "99/99/99"));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            context.WriteHtmlText( "<div id=\""+edtavFacturafecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtavFacturafecha_Internalname, context.localUtil.Format(AV19FacturaFecha, "99/99/99"), context.localUtil.Format( AV19FacturaFecha, "99/99/99"), "", "", "", "", "", edtavFacturafecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtavFacturafecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_wp_factura.htm");
            GxWebStd.gx_bitmap( context, edtavFacturafecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtavFacturafecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_wp_factura.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock11_Internalname, "Hora", "", "", lblTextblock11_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV20FacturaHora", AV20FacturaHora);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavFacturahora_Internalname, StringUtil.RTrim( AV20FacturaHora), StringUtil.RTrim( context.localUtil.Format( AV20FacturaHora, "XXXXXXXX")), "", "", "", "", "", edtavFacturahora_Jsonclick, 0, ClassString, StyleString, "", 1, edtavFacturahora_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "left", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_34_2O2e( true) ;
         }
         else
         {
            wb_table5_34_2O2e( false) ;
         }
      }

      protected void wb_table4_26_2O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock5_Internalname, "Paciente", "", "", lblTextblock5_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV18PacienteNombreC", AV18PacienteNombreC);
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacientenombrec_Internalname, StringUtil.RTrim( AV18PacienteNombreC), StringUtil.RTrim( context.localUtil.Format( AV18PacienteNombreC, "")), "", "", "", "", "", edtavPacientenombrec_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacientenombrec_Enabled, 0, 501, "px", 20, "px", 100, 0, 0, 0, 1, -1, true, "left", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_26_2O2e( true) ;
         }
         else
         {
            wb_table4_26_2O2e( false) ;
         }
      }

      protected void wb_table3_14_2O2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock7_Internalname, "ConsultaId", "", "", lblTextblock7_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavConsultaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7ConsultaId), 9, 0, ".", "")), ((edtavConsultaid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV7ConsultaId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV7ConsultaId), "ZZZZZZZZ9")), "", "", "", "", "", edtavConsultaid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavConsultaid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:bold; font-style:normal;" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock6_Internalname, "Paciente Id", "", "", lblTextblock6_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PacienteId), 9, 0)));
            ClassString = "Attribute" ;
            StyleString = "font-family:'Microsoft YaHei UI'; font-size:10.0pt; font-weight:normal; font-style:normal;" ;
            GxWebStd.gx_single_line_edit( context, edtavPacienteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13PacienteId), 9, 0, ".", "")), ((edtavPacienteid_Enabled!=0) ? StringUtil.LTrim( context.localUtil.Format( (decimal)(AV13PacienteId), "ZZZZZZZZ9")) : context.localUtil.Format( (decimal)(AV13PacienteId), "ZZZZZZZZ9")), "", "", "", "", "", edtavPacienteid_Jsonclick, 0, ClassString, StyleString, "", 1, edtavPacienteid_Enabled, 0, 9, "chr", 1, "row", 9, 0, 0, 0, 1, -1, true, "right", "HLP_wp_factura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_14_2O2e( true) ;
         }
         else
         {
            wb_table3_14_2O2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV7ConsultaId = Convert.ToInt32(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7ConsultaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7ConsultaId), 9, 0)));
         AV8FacturaId = Convert.ToInt32(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8FacturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8FacturaId), 9, 0)));
         AV13PacienteId = Convert.ToInt32(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13PacienteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13PacienteId), 9, 0)));
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
         PA2O2( ) ;
         WS2O2( ) ;
         WE2O2( ) ;
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
         if ( ! ( WebComp_Webcomp1 == null ) )
         {
            if ( StringUtil.Len( WebComp_Webcomp1_Component) != 0 )
            {
               WebComp_Webcomp1.componentthemes();
            }
         }
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?1575666");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?58720");
         context.AddJavascriptSource("gxdec.js", "?58720");
         context.AddJavascriptSource("wp_factura.js", "?1575666");
         /* End function include_jscripts */
      }

      protected void sendrow_752( )
      {
         WB2O0( ) ;
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
            if ( ((int)(nGXsfl_75_idx) % (2)) == 0 )
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
            context.WriteHtmlText( " gxrow=\""+sGXsfl_75_idx+"\">") ;
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
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtClinicaCodigo_Internalname,StringUtil.RTrim( A41ClinicaCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtClinicaCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A185FacturaId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A185FacturaId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A248FacturaDId), 9, 0, ".", "")),context.localUtil.Format( (decimal)(A248FacturaDId), "ZZZZZZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)9,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloCodigo_Internalname,StringUtil.RTrim( A30ArticuloCodigo),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloCodigo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)10,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtArticuloDescripcion_Internalname,StringUtil.RTrim( A31ArticuloDescripcion),(String)"",(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtArticuloDescripcion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"left"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDPrecio_Internalname,StringUtil.LTrim( StringUtil.NToC( A249FacturaDPrecio, 17, 2, ".", "")),context.localUtil.Format( A249FacturaDPrecio, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDPrecio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDCantidad_Internalname,StringUtil.LTrim( StringUtil.NToC( A250FacturaDCantidad, 17, 2, ".", "")),context.localUtil.Format( A250FacturaDCantidad, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDCantidad_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"right"});
         /* Subfile cell */
         if ( Grid1Container.GetWrapped() == 1 )
         {
            context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
         }
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "font-family:'Microsoft YaHei UI'; font-size:9.0pt; font-weight:normal; font-style:normal;" ;
         ROClassString = ClassString ;
         Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtFacturaDTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( A251FacturaDTotal, 17, 2, ".", "")),context.localUtil.Format( A251FacturaDTotal, "ZZZZZZZZZZZZZ9.99"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtFacturaDTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)17,(short)0,(short)0,(short)75,(short)1,(short)1,(bool)true,(String)"right"});
         Grid1Container.AddRow(Grid1Row);
         nGXsfl_75_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_75_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_75_idx+1)) ;
         sGXsfl_75_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_75_idx), 4, 0)), 4, "0") ;
         edtClinicaCodigo_Internalname = "CLINICACODIGO_"+sGXsfl_75_idx ;
         edtFacturaId_Internalname = "FACTURAID_"+sGXsfl_75_idx ;
         edtFacturaDId_Internalname = "FACTURADID_"+sGXsfl_75_idx ;
         edtArticuloCodigo_Internalname = "ARTICULOCODIGO_"+sGXsfl_75_idx ;
         edtArticuloDescripcion_Internalname = "ARTICULODESCRIPCION_"+sGXsfl_75_idx ;
         edtFacturaDPrecio_Internalname = "FACTURADPRECIO_"+sGXsfl_75_idx ;
         edtFacturaDCantidad_Internalname = "FACTURADCANTIDAD_"+sGXsfl_75_idx ;
         edtFacturaDTotal_Internalname = "FACTURADTOTAL_"+sGXsfl_75_idx ;
         /* End function sendrow_752 */
      }

      protected void init_default_properties( )
      {
         lblTextblock1_Internalname = "TEXTBLOCK1" ;
         lblTextblock7_Internalname = "TEXTBLOCK7" ;
         edtavConsultaid_Internalname = "vCONSULTAID" ;
         lblTextblock6_Internalname = "TEXTBLOCK6" ;
         edtavPacienteid_Internalname = "vPACIENTEID" ;
         tblTable3_Internalname = "TABLE3" ;
         lblTextblock5_Internalname = "TEXTBLOCK5" ;
         edtavPacientenombrec_Internalname = "vPACIENTENOMBREC" ;
         tblTable4_Internalname = "TABLE4" ;
         lblTextblock4_Internalname = "TEXTBLOCK4" ;
         edtavFacturaid_Internalname = "vFACTURAID" ;
         lblTextblock10_Internalname = "TEXTBLOCK10" ;
         edtavFacturafecha_Internalname = "vFACTURAFECHA" ;
         lblTextblock11_Internalname = "TEXTBLOCK11" ;
         edtavFacturahora_Internalname = "vFACTURAHORA" ;
         tblTable5_Internalname = "TABLE5" ;
         lblTextblock9_Internalname = "TEXTBLOCK9" ;
         imgImage1_Internalname = "IMAGE1" ;
         edtavClientecodigo_Internalname = "vCLIENTECODIGO" ;
         bttButton1_Internalname = "BUTTON1" ;
         lblTextblock8_Internalname = "TEXTBLOCK8" ;
         edtavClientenombre_Internalname = "vCLIENTENOMBRE" ;
         lblTextblock3_Internalname = "TEXTBLOCK3" ;
         edtavClientedireccion_Internalname = "vCLIENTEDIRECCION" ;
         tblTable6_Internalname = "TABLE6" ;
         tblTable2_Internalname = "TABLE2" ;
         bttButton2_Internalname = "BUTTON2" ;
         bttButton3_Internalname = "BUTTON3" ;
         bttButton4_Internalname = "BUTTON4" ;
         bttButton5_Internalname = "BUTTON5" ;
         tblTable1_Internalname = "TABLE1" ;
         lblTextblock2_Internalname = "TEXTBLOCK2" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtFacturaDTotal_Jsonclick = "" ;
         edtFacturaDCantidad_Jsonclick = "" ;
         edtFacturaDPrecio_Jsonclick = "" ;
         edtArticuloDescripcion_Jsonclick = "" ;
         edtArticuloCodigo_Jsonclick = "" ;
         edtFacturaDId_Jsonclick = "" ;
         edtFacturaId_Jsonclick = "" ;
         edtClinicaCodigo_Jsonclick = "" ;
         edtavPacienteid_Jsonclick = "" ;
         edtavPacienteid_Enabled = 0 ;
         edtavConsultaid_Jsonclick = "" ;
         edtavConsultaid_Enabled = 0 ;
         edtavPacientenombrec_Jsonclick = "" ;
         edtavPacientenombrec_Enabled = 0 ;
         edtavFacturahora_Jsonclick = "" ;
         edtavFacturahora_Enabled = 0 ;
         edtavFacturafecha_Jsonclick = "" ;
         edtavFacturafecha_Enabled = 0 ;
         edtavFacturaid_Jsonclick = "" ;
         edtavFacturaid_Enabled = 0 ;
         edtavClientedireccion_Jsonclick = "" ;
         edtavClientenombre_Jsonclick = "" ;
         edtavClientecodigo_Jsonclick = "" ;
         imgImage1_Link = "" ;
         subGrid1_Allowcollapsing = 0 ;
         subGrid1_Linesfont = "font-family:Microsoft YaHei UI;font-size:9pt;" ;
         subGrid1_Titlefont = "font-family:Microsoft YaHei UI;font-size:9pt;font-weight:bold;" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 0 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Facturación" ;
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
         Gx_time = "" ;
         Gx_date = DateTime.MinValue ;
         AV6ClinicaCodigo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXKey = "" ;
         GXEncryptionTmp = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock2_Jsonclick = "" ;
         OldWebcomp1 = "" ;
         WebComp_Webcomp1_Component = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtClinicaCodigo_Internalname = "" ;
         edtFacturaId_Internalname = "" ;
         edtFacturaDId_Internalname = "" ;
         edtArticuloCodigo_Internalname = "" ;
         edtArticuloDescripcion_Internalname = "" ;
         edtFacturaDPrecio_Internalname = "" ;
         edtFacturaDCantidad_Internalname = "" ;
         edtFacturaDTotal_Internalname = "" ;
         A41ClinicaCodigo = "" ;
         A30ArticuloCodigo = "" ;
         A31ArticuloDescripcion = "" ;
         GXDecQS = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         H002O2_A31ArticuloDescripcion = new String[] {""} ;
         H002O2_A30ArticuloCodigo = new String[] {""} ;
         H002O2_A248FacturaDId = new int[1] ;
         H002O2_A185FacturaId = new int[1] ;
         H002O2_A41ClinicaCodigo = new String[] {""} ;
         H002O2_A250FacturaDCantidad = new decimal[1] ;
         H002O2_A249FacturaDPrecio = new decimal[1] ;
         AV18PacienteNombreC = "" ;
         AV19FacturaFecha = DateTime.MinValue ;
         AV20FacturaHora = "" ;
         AV21ClienteCodigo = "" ;
         AV22ClienteNombre = "" ;
         AV24ClienteDireccion = "" ;
         bttButton5_Jsonclick = "" ;
         bttButton4_Jsonclick = "" ;
         AV5Parametros = new SdtParametros(context);
         GXt_SdtParametros3 = new SdtParametros(context);
         AV26CajaCodigo = "" ;
         AV15PacienteNombre1 = "" ;
         AV16PacienteNombre2 = "" ;
         AV9PacienteApellido1 = "" ;
         AV10PacienteApellido2 = "" ;
         AV11PacienteApellido3 = "" ;
         AV12PacienteGenero = "" ;
         AV14PacienteNacimiento = DateTime.MinValue ;
         AV27FacturaSerie = "" ;
         H002O3_A185FacturaId = new int[1] ;
         H002O3_A41ClinicaCodigo = new String[] {""} ;
         H002O3_A188FacturaEstado = new short[1] ;
         sStyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char9 = "" ;
         Grid1Column = new GXWebColumn();
         TempTags = "" ;
         bttButton2_Jsonclick = "" ;
         bttButton3_Jsonclick = "" ;
         GXt_char11 = "" ;
         GXt_char10 = "" ;
         lblTextblock9_Jsonclick = "" ;
         bttButton1_Jsonclick = "" ;
         lblTextblock8_Jsonclick = "" ;
         lblTextblock3_Jsonclick = "" ;
         lblTextblock4_Jsonclick = "" ;
         lblTextblock10_Jsonclick = "" ;
         lblTextblock11_Jsonclick = "" ;
         lblTextblock5_Jsonclick = "" ;
         lblTextblock7_Jsonclick = "" ;
         lblTextblock6_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char12 = "" ;
         ROClassString = "" ;
         GXt_char13 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.wp_factura__default(),
            new Object[][] {
                new Object[] {
               H002O2_A31ArticuloDescripcion, H002O2_A30ArticuloCodigo, H002O2_A248FacturaDId, H002O2_A185FacturaId, H002O2_A41ClinicaCodigo, H002O2_A250FacturaDCantidad, H002O2_A249FacturaDPrecio
               }
               , new Object[] {
               H002O3_A185FacturaId, H002O3_A41ClinicaCodigo, H002O3_A188FacturaEstado
               }
            }
         );
         WebComp_Webcomp1 = new GeneXus.Http.GXNullWebComponent();
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
         imgImage1_Link = "javascript:"+"gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vCLINICACODIGO"+"'), id:'"+"vCLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"vCLIENTECODIGO"+"'), id:'"+"vCLIENTECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");" ;
         imgImage1_Link = "javascript:"+"gx.popup.openPrompt('"+"gx01c0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"vCLINICACODIGO"+"'), id:'"+"vCLINICACODIGO"+"'"+",isOut: true}"+","+"{Ctrl:gx.dom.el('"+"vCLIENTECODIGO"+"'), id:'"+"vCLIENTECODIGO"+"'"+",isOut: true}"+"],"+"null"+","+"'', false"+","+"false"+");" ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_75_idx=1 ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short wbEnd ;
      private short wbStart ;
      private short nCmpId ;
      private short nDonePA ;
      private short AV17ConsultaEdad ;
      private short AV25FacturaEstado ;
      private short AV29Flag ;
      private short GXt_int8 ;
      private short GXt_int4 ;
      private short gxcookieaux ;
      private short A188FacturaEstado ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Allowcollapsing ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int AV7ConsultaId ;
      private int AV8FacturaId ;
      private int AV13PacienteId ;
      private int wcpOAV7ConsultaId ;
      private int wcpOAV8FacturaId ;
      private int wcpOAV13PacienteId ;
      private int A185FacturaId ;
      private int A248FacturaDId ;
      private int subGrid1_Islastpage ;
      private int GRID1_nFirstRecordOnPage ;
      private int GRID1_nCurrentRecord ;
      private int edtavConsultaid_Enabled ;
      private int edtavPacienteid_Enabled ;
      private int edtavPacientenombrec_Enabled ;
      private int edtavFacturaid_Enabled ;
      private int edtavFacturafecha_Enabled ;
      private int edtavFacturahora_Enabled ;
      private int GXt_int5 ;
      private int AV28FacturaDocto ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private decimal A249FacturaDPrecio ;
      private decimal A250FacturaDCantidad ;
      private decimal A251FacturaDTotal ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_75_idx="0001" ;
      private String Gx_time ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXKey ;
      private String GXEncryptionTmp ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock2_Internalname ;
      private String lblTextblock2_Jsonclick ;
      private String OldWebcomp1 ;
      private String WebComp_Webcomp1_Component ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtClinicaCodigo_Internalname ;
      private String edtFacturaId_Internalname ;
      private String edtFacturaDId_Internalname ;
      private String edtArticuloCodigo_Internalname ;
      private String edtArticuloDescripcion_Internalname ;
      private String edtFacturaDPrecio_Internalname ;
      private String edtFacturaDCantidad_Internalname ;
      private String edtFacturaDTotal_Internalname ;
      private String GXDecQS ;
      private String edtavClientecodigo_Internalname ;
      private String scmdbuf ;
      private String edtavConsultaid_Internalname ;
      private String edtavPacienteid_Internalname ;
      private String edtavPacientenombrec_Internalname ;
      private String edtavFacturaid_Internalname ;
      private String edtavFacturafecha_Internalname ;
      private String edtavFacturahora_Internalname ;
      private String imgImage1_Link ;
      private String imgImage1_Internalname ;
      private String AV20FacturaHora ;
      private String edtavClientenombre_Internalname ;
      private String edtavClientedireccion_Internalname ;
      private String bttButton5_Jsonclick ;
      private String bttButton5_Internalname ;
      private String bttButton4_Jsonclick ;
      private String bttButton4_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char9 ;
      private String subGrid1_Titlefont ;
      private String subGrid1_Linesfont ;
      private String TempTags ;
      private String bttButton2_Internalname ;
      private String bttButton2_Jsonclick ;
      private String bttButton3_Internalname ;
      private String bttButton3_Jsonclick ;
      private String GXt_char11 ;
      private String GXt_char10 ;
      private String tblTable2_Internalname ;
      private String tblTable6_Internalname ;
      private String lblTextblock9_Internalname ;
      private String lblTextblock9_Jsonclick ;
      private String edtavClientecodigo_Jsonclick ;
      private String bttButton1_Internalname ;
      private String bttButton1_Jsonclick ;
      private String lblTextblock8_Internalname ;
      private String lblTextblock8_Jsonclick ;
      private String edtavClientenombre_Jsonclick ;
      private String lblTextblock3_Internalname ;
      private String lblTextblock3_Jsonclick ;
      private String edtavClientedireccion_Jsonclick ;
      private String tblTable5_Internalname ;
      private String lblTextblock4_Internalname ;
      private String lblTextblock4_Jsonclick ;
      private String edtavFacturaid_Jsonclick ;
      private String lblTextblock10_Internalname ;
      private String lblTextblock10_Jsonclick ;
      private String edtavFacturafecha_Jsonclick ;
      private String lblTextblock11_Internalname ;
      private String lblTextblock11_Jsonclick ;
      private String edtavFacturahora_Jsonclick ;
      private String tblTable4_Internalname ;
      private String lblTextblock5_Internalname ;
      private String lblTextblock5_Jsonclick ;
      private String edtavPacientenombrec_Jsonclick ;
      private String tblTable3_Internalname ;
      private String lblTextblock7_Internalname ;
      private String lblTextblock7_Jsonclick ;
      private String edtavConsultaid_Jsonclick ;
      private String lblTextblock6_Internalname ;
      private String lblTextblock6_Jsonclick ;
      private String edtavPacienteid_Jsonclick ;
      private String GXt_char12 ;
      private String ROClassString ;
      private String edtClinicaCodigo_Jsonclick ;
      private String edtFacturaId_Jsonclick ;
      private String edtFacturaDId_Jsonclick ;
      private String edtArticuloCodigo_Jsonclick ;
      private String edtArticuloDescripcion_Jsonclick ;
      private String edtFacturaDPrecio_Jsonclick ;
      private String edtFacturaDCantidad_Jsonclick ;
      private String edtFacturaDTotal_Jsonclick ;
      private String GXt_char13 ;
      private DateTime Gx_date ;
      private DateTime AV19FacturaFecha ;
      private DateTime AV14PacienteNacimiento ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV6ClinicaCodigo ;
      private String A41ClinicaCodigo ;
      private String A30ArticuloCodigo ;
      private String A31ArticuloDescripcion ;
      private String AV18PacienteNombreC ;
      private String AV21ClienteCodigo ;
      private String AV22ClienteNombre ;
      private String AV24ClienteDireccion ;
      private String AV26CajaCodigo ;
      private String AV15PacienteNombre1 ;
      private String AV16PacienteNombre2 ;
      private String AV9PacienteApellido1 ;
      private String AV10PacienteApellido2 ;
      private String AV11PacienteApellido3 ;
      private String AV12PacienteGenero ;
      private String AV27FacturaSerie ;
      private GXWebComponent WebComp_Webcomp1 ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private int aP0_ConsultaId ;
      private int aP1_FacturaId ;
      private int aP2_PacienteId ;
      private IDataStoreProvider pr_default ;
      private String[] H002O2_A31ArticuloDescripcion ;
      private String[] H002O2_A30ArticuloCodigo ;
      private int[] H002O2_A248FacturaDId ;
      private int[] H002O2_A185FacturaId ;
      private String[] H002O2_A41ClinicaCodigo ;
      private decimal[] H002O2_A250FacturaDCantidad ;
      private decimal[] H002O2_A249FacturaDPrecio ;
      private int[] H002O3_A185FacturaId ;
      private String[] H002O3_A41ClinicaCodigo ;
      private short[] H002O3_A188FacturaEstado ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private GXWebForm Form ;
      private SdtParametros AV5Parametros ;
      private SdtParametros GXt_SdtParametros3 ;
   }

   public class wp_factura__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH002O2 ;
          prmH002O2 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8FacturaId",SqlDbType.Int,9,0}
          } ;
          Object[] prmH002O3 ;
          prmH002O3 = new Object[] {
          new Object[] {"@AV6ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV8FacturaId",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H002O2", "SELECT T2.[ArticuloDescripcion], T1.[ArticuloCodigo], T1.[FacturaDId], T1.[FacturaId], T1.[ClinicaCodigo], T1.[FacturaDCantidad], T1.[FacturaDPrecio] FROM ([FacturaDetalle] T1 WITH (NOLOCK) INNER JOIN [Articulo] T2 WITH (NOLOCK) ON T2.[ClinicaCodigo] = T1.[ClinicaCodigo] AND T2.[ArticuloCodigo] = T1.[ArticuloCodigo]) WHERE T1.[ClinicaCodigo] = @AV6ClinicaCodigo and T1.[FacturaId] = @AV8FacturaId ORDER BY T1.[ClinicaCodigo], T1.[FacturaId], T1.[FacturaDId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O2,11,0,true,false )
             ,new CursorDef("H002O3", "SELECT [FacturaId], [ClinicaCodigo], [FacturaEstado] FROM [Factura] WITH (NOLOCK) WHERE [ClinicaCodigo] = @AV6ClinicaCodigo and [FacturaId] = @AV8FacturaId ORDER BY [ClinicaCodigo], [FacturaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH002O3,1,0,true,true )
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                ((int[]) buf[3])[0] = rslt.getInt(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((decimal[]) buf[5])[0] = rslt.getDecimal(6) ;
                ((decimal[]) buf[6])[0] = rslt.getDecimal(7) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                break;
       }
    }

 }

}
