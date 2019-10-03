using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\GeneXus.Programs.Common.rsp");
      return sc ;
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\arbalancegeneral.dll", cs_path + @"\arbalancegeneral.rsp");
      sc.Add( @"bin\arpartidacontable.dll", cs_path + @"\arpartidacontable.rsp");
      sc.Add( @"bin\arfactura.dll", cs_path + @"\arfactura.rsp");
      sc.Add( @"bin\arrecetamedica.dll", cs_path + @"\arrecetamedica.rsp");
      sc.Add( @"bin\aloadeventssampleproc.dll", cs_path + @"\aloadeventssampleproc.rsp");
      sc.Add( @"bin\aschedulerrequesthandler.dll", cs_path + @"\aschedulerrequesthandler.rsp");
      sc.Add( @"bin\gx0260.dll", cs_path + @"\gx0260.rsp");
      sc.Add( @"bin\gx00b1.dll", cs_path + @"\gx00b1.rsp");
      sc.Add( @"bin\gx0252.dll", cs_path + @"\gx0252.rsp");
      sc.Add( @"bin\gx0240.dll", cs_path + @"\gx0240.rsp");
      sc.Add( @"bin\wp_chequeomedico.dll", cs_path + @"\wp_chequeomedico.rsp");
      sc.Add( @"bin\wp_npaciente.dll", cs_path + @"\wp_npaciente.rsp");
      sc.Add( @"bin\gx0230.dll", cs_path + @"\gx0230.rsp");
      sc.Add( @"bin\gx0220.dll", cs_path + @"\gx0220.rsp");
      sc.Add( @"bin\gx0210.dll", cs_path + @"\gx0210.rsp");
      sc.Add( @"bin\gx0200.dll", cs_path + @"\gx0200.rsp");
      sc.Add( @"bin\gx01z0.dll", cs_path + @"\gx01z0.rsp");
      sc.Add( @"bin\wp_reportescontables.dll", cs_path + @"\wp_reportescontables.rsp");
      sc.Add( @"bin\wp_autopartidas.dll", cs_path + @"\wp_autopartidas.rsp");
      sc.Add( @"bin\wp_cierrecontable.dll", cs_path + @"\wp_cierrecontable.rsp");
      sc.Add( @"bin\gx01y0.dll", cs_path + @"\gx01y0.rsp");
      sc.Add( @"bin\wp_reversapartida.dll", cs_path + @"\wp_reversapartida.rsp");
      sc.Add( @"bin\wp_registrapartida.dll", cs_path + @"\wp_registrapartida.rsp");
      sc.Add( @"bin\wp_consultapartidas.dll", cs_path + @"\wp_consultapartidas.rsp");
      sc.Add( @"bin\wp_registramovinv.dll", cs_path + @"\wp_registramovinv.rsp");
      sc.Add( @"bin\gx01x0.dll", cs_path + @"\gx01x0.rsp");
      sc.Add( @"bin\wp_depositobancario.dll", cs_path + @"\wp_depositobancario.rsp");
      sc.Add( @"bin\wp_reportescortecaja.dll", cs_path + @"\wp_reportescortecaja.rsp");
      sc.Add( @"bin\wp_generacortecaja.dll", cs_path + @"\wp_generacortecaja.rsp");
      sc.Add( @"bin\wp_cortecaja.dll", cs_path + @"\wp_cortecaja.rsp");
      sc.Add( @"bin\wp_movimientoinv.dll", cs_path + @"\wp_movimientoinv.rsp");
      sc.Add( @"bin\gx01v0.dll", cs_path + @"\gx01v0.rsp");
      sc.Add( @"bin\gx01u3.dll", cs_path + @"\gx01u3.rsp");
      sc.Add( @"bin\gx01t0.dll", cs_path + @"\gx01t0.rsp");
      sc.Add( @"bin\gx01s0.dll", cs_path + @"\gx01s0.rsp");
      sc.Add( @"bin\gx01r0.dll", cs_path + @"\gx01r0.rsp");
      sc.Add( @"bin\wc_pagos.dll", cs_path + @"\wc_pagos.rsp");
      sc.Add( @"bin\gx00c1.dll", cs_path + @"\gx00c1.rsp");
      sc.Add( @"bin\wp_factura.dll", cs_path + @"\wp_factura.rsp");
      sc.Add( @"bin\wp_paciente_fac.dll", cs_path + @"\wp_paciente_fac.rsp");
      sc.Add( @"bin\gx01p0.dll", cs_path + @"\gx01p0.rsp");
      sc.Add( @"bin\gx01o2.dll", cs_path + @"\gx01o2.rsp");
      sc.Add( @"bin\wp_cita.dll", cs_path + @"\wp_cita.rsp");
      sc.Add( @"bin\gx01n0.dll", cs_path + @"\gx01n0.rsp");
      sc.Add( @"bin\appmastersd.dll", cs_path + @"\appmastersd.rsp");
      sc.Add( @"bin\tabbedview.dll", cs_path + @"\tabbedview.rsp");
      sc.Add( @"bin\home.dll", cs_path + @"\home.rsp");
      sc.Add( @"bin\notauthorized.dll", cs_path + @"\notauthorized.rsp");
      sc.Add( @"bin\gx01l0.dll", cs_path + @"\gx01l0.rsp");
      sc.Add( @"bin\wp_agenda.dll", cs_path + @"\wp_agenda.rsp");
      sc.Add( @"bin\schedulerdetailsform.dll", cs_path + @"\schedulerdetailsform.rsp");
      sc.Add( @"bin\gx01k0.dll", cs_path + @"\gx01k0.rsp");
      sc.Add( @"bin\gx01j0.dll", cs_path + @"\gx01j0.rsp");
      sc.Add( @"bin\gx01i3.dll", cs_path + @"\gx01i3.rsp");
      sc.Add( @"bin\gx01h0.dll", cs_path + @"\gx01h0.rsp");
      sc.Add( @"bin\gx01e1.dll", cs_path + @"\gx01e1.rsp");
      sc.Add( @"bin\gx01g2.dll", cs_path + @"\gx01g2.rsp");
      sc.Add( @"bin\gx01f0.dll", cs_path + @"\gx01f0.rsp");
      sc.Add( @"bin\gx01e0.dll", cs_path + @"\gx01e0.rsp");
      sc.Add( @"bin\gx01d0.dll", cs_path + @"\gx01d0.rsp");
      sc.Add( @"bin\gx01c0.dll", cs_path + @"\gx01c0.rsp");
      sc.Add( @"bin\wp_registraexpediente.dll", cs_path + @"\wp_registraexpediente.rsp");
      sc.Add( @"bin\gx01b2.dll", cs_path + @"\gx01b2.rsp");
      sc.Add( @"bin\gx01a0.dll", cs_path + @"\gx01a0.rsp");
      sc.Add( @"bin\wp_expediente.dll", cs_path + @"\wp_expediente.rsp");
      sc.Add( @"bin\wp_paciente_emf.dll", cs_path + @"\wp_paciente_emf.rsp");
      sc.Add( @"bin\gx0190.dll", cs_path + @"\gx0190.rsp");
      sc.Add( @"bin\wc_cargos.dll", cs_path + @"\wc_cargos.rsp");
      sc.Add( @"bin\wc_recetas.dll", cs_path + @"\wc_recetas.rsp");
      sc.Add( @"bin\wc_signosvitales.dll", cs_path + @"\wc_signosvitales.rsp");
      sc.Add( @"bin\wp_registraconsulta.dll", cs_path + @"\wp_registraconsulta.rsp");
      sc.Add( @"bin\gx0183.dll", cs_path + @"\gx0183.rsp");
      sc.Add( @"bin\gx0170.dll", cs_path + @"\gx0170.rsp");
      sc.Add( @"bin\gx00m1.dll", cs_path + @"\gx00m1.rsp");
      sc.Add( @"bin\wp_paciente.dll", cs_path + @"\wp_paciente.rsp");
      sc.Add( @"bin\gx0160.dll", cs_path + @"\gx0160.rsp");
      sc.Add( @"bin\gx0150.dll", cs_path + @"\gx0150.rsp");
      sc.Add( @"bin\gx0140.dll", cs_path + @"\gx0140.rsp");
      sc.Add( @"bin\gx0130.dll", cs_path + @"\gx0130.rsp");
      sc.Add( @"bin\gx0120.dll", cs_path + @"\gx0120.rsp");
      sc.Add( @"bin\gx0112.dll", cs_path + @"\gx0112.rsp");
      sc.Add( @"bin\gx0100.dll", cs_path + @"\gx0100.rsp");
      sc.Add( @"bin\gx00z0.dll", cs_path + @"\gx00z0.rsp");
      sc.Add( @"bin\gx00y0.dll", cs_path + @"\gx00y0.rsp");
      sc.Add( @"bin\gx00x0.dll", cs_path + @"\gx00x0.rsp");
      sc.Add( @"bin\gx00v0.dll", cs_path + @"\gx00v0.rsp");
      sc.Add( @"bin\gx00w2.dll", cs_path + @"\gx00w2.rsp");
      sc.Add( @"bin\gx00v1.dll", cs_path + @"\gx00v1.rsp");
      sc.Add( @"bin\gx00u0.dll", cs_path + @"\gx00u0.rsp");
      sc.Add( @"bin\gx00t2.dll", cs_path + @"\gx00t2.rsp");
      sc.Add( @"bin\gx00s0.dll", cs_path + @"\gx00s0.rsp");
      sc.Add( @"bin\gx00r0.dll", cs_path + @"\gx00r0.rsp");
      sc.Add( @"bin\gx00q2.dll", cs_path + @"\gx00q2.rsp");
      sc.Add( @"bin\gx00p0.dll", cs_path + @"\gx00p0.rsp");
      sc.Add( @"bin\gx00n0.dll", cs_path + @"\gx00n0.rsp");
      sc.Add( @"bin\gx00m0.dll", cs_path + @"\gx00m0.rsp");
      sc.Add( @"bin\gx00l2.dll", cs_path + @"\gx00l2.rsp");
      sc.Add( @"bin\gx00k0.dll", cs_path + @"\gx00k0.rsp");
      sc.Add( @"bin\gx00i0.dll", cs_path + @"\gx00i0.rsp");
      sc.Add( @"bin\gx00f0.dll", cs_path + @"\gx00f0.rsp");
      sc.Add( @"bin\gx00f2.dll", cs_path + @"\gx00f2.rsp");
      sc.Add( @"bin\gx00e0.dll", cs_path + @"\gx00e0.rsp");
      sc.Add( @"bin\gx00d0.dll", cs_path + @"\gx00d0.rsp");
      sc.Add( @"bin\gx00c0.dll", cs_path + @"\gx00c0.rsp");
      sc.Add( @"bin\gx00b0.dll", cs_path + @"\gx00b0.rsp");
      sc.Add( @"bin\gx00b2.dll", cs_path + @"\gx00b2.rsp");
      sc.Add( @"bin\gx00a0.dll", cs_path + @"\gx00a0.rsp");
      sc.Add( @"bin\gx0080.dll", cs_path + @"\gx0080.rsp");
      sc.Add( @"bin\gx0062.dll", cs_path + @"\gx0062.rsp");
      sc.Add( @"bin\gx0050.dll", cs_path + @"\gx0050.rsp");
      sc.Add( @"bin\gx0041.dll", cs_path + @"\gx0041.rsp");
      sc.Add( @"bin\gx0030.dll", cs_path + @"\gx0030.rsp");
      sc.Add( @"bin\gx0020.dll", cs_path + @"\gx0020.rsp");
      sc.Add( @"bin\gx0010.dll", cs_path + @"\gx0010.rsp");
      sc.Add( @"bin\gx00h0.dll", cs_path + @"\gx00h0.rsp");
      sc.Add( @"bin\gx00g0.dll", cs_path + @"\gx00g0.rsp");
      sc.Add( @"bin\principal.dll", cs_path + @"\principal.rsp");
      sc.Add( @"bin\ingreso.dll", cs_path + @"\ingreso.rsp");
      sc.Add( @"bin\promptmasterpage.dll", cs_path + @"\promptmasterpage.rsp");
      sc.Add( @"bin\recentlinks.dll", cs_path + @"\recentlinks.rsp");
      sc.Add( @"bin\appmasterpage.dll", cs_path + @"\appmasterpage.rsp");
      sc.Add( @"bin\unidadmedida.dll", cs_path + @"\unidadmedida.rsp");
      sc.Add( @"bin\tipovendedor.dll", cs_path + @"\tipovendedor.rsp");
      sc.Add( @"bin\notapaciente.dll", cs_path + @"\notapaciente.rsp");
      sc.Add( @"bin\vendedor.dll", cs_path + @"\vendedor.rsp");
      sc.Add( @"bin\religion.dll", cs_path + @"\religion.rsp");
      sc.Add( @"bin\profesion.dll", cs_path + @"\profesion.rsp");
      sc.Add( @"bin\repbalanceestado.dll", cs_path + @"\repbalanceestado.rsp");
      sc.Add( @"bin\movimientoreversado.dll", cs_path + @"\movimientoreversado.rsp");
      sc.Add( @"bin\depositobancario.dll", cs_path + @"\depositobancario.rsp");
      sc.Add( @"bin\inventario.dll", cs_path + @"\inventario.rsp");
      sc.Add( @"bin\movimientoinv.dll", cs_path + @"\movimientoinv.rsp");
      sc.Add( @"bin\emisortarjeta.dll", cs_path + @"\emisortarjeta.rsp");
      sc.Add( @"bin\facturapago.dll", cs_path + @"\facturapago.rsp");
      sc.Add( @"bin\resolucionsat.dll", cs_path + @"\resolucionsat.rsp");
      sc.Add( @"bin\agenda.dll", cs_path + @"\agenda.rsp");
      sc.Add( @"bin\cierremensualc.dll", cs_path + @"\cierremensualc.rsp");
      sc.Add( @"bin\movimientomayorizado.dll", cs_path + @"\movimientomayorizado.rsp");
      sc.Add( @"bin\partidaenc.dll", cs_path + @"\partidaenc.rsp");
      sc.Add( @"bin\tipopartida.dll", cs_path + @"\tipopartida.rsp");
      sc.Add( @"bin\cuentacontable.dll", cs_path + @"\cuentacontable.rsp");
      sc.Add( @"bin\factura.dll", cs_path + @"\factura.rsp");
      sc.Add( @"bin\cliente.dll", cs_path + @"\cliente.rsp");
      sc.Add( @"bin\expediente.dll", cs_path + @"\expediente.rsp");
      sc.Add( @"bin\cargo.dll", cs_path + @"\cargo.rsp");
      sc.Add( @"bin\cortecaja.dll", cs_path + @"\cortecaja.rsp");
      sc.Add( @"bin\tipoorden.dll", cs_path + @"\tipoorden.rsp");
      sc.Add( @"bin\tipoadmision.dll", cs_path + @"\tipoadmision.rsp");
      sc.Add( @"bin\tipopaciente.dll", cs_path + @"\tipopaciente.rsp");
      sc.Add( @"bin\tipoproveedor.dll", cs_path + @"\tipoproveedor.rsp");
      sc.Add( @"bin\tipocliente.dll", cs_path + @"\tipocliente.rsp");
      sc.Add( @"bin\caja.dll", cs_path + @"\caja.rsp");
      sc.Add( @"bin\cuentabancaria.dll", cs_path + @"\cuentabancaria.rsp");
      sc.Add( @"bin\banco.dll", cs_path + @"\banco.rsp");
      sc.Add( @"bin\aseguradora.dll", cs_path + @"\aseguradora.rsp");
      sc.Add( @"bin\especialidad.dll", cs_path + @"\especialidad.rsp");
      sc.Add( @"bin\bodega.dll", cs_path + @"\bodega.rsp");
      sc.Add( @"bin\tipomovinventario.dll", cs_path + @"\tipomovinventario.rsp");
      sc.Add( @"bin\receta.dll", cs_path + @"\receta.rsp");
      sc.Add( @"bin\consulta.dll", cs_path + @"\consulta.rsp");
      sc.Add( @"bin\paciente.dll", cs_path + @"\paciente.rsp");
      sc.Add( @"bin\formapago.dll", cs_path + @"\formapago.rsp");
      sc.Add( @"bin\correlativo.dll", cs_path + @"\correlativo.rsp");
      sc.Add( @"bin\tipocita.dll", cs_path + @"\tipocita.rsp");
      sc.Add( @"bin\cie10.dll", cs_path + @"\cie10.rsp");
      sc.Add( @"bin\clinica.dll", cs_path + @"\clinica.rsp");
      sc.Add( @"bin\departamento.dll", cs_path + @"\departamento.rsp");
      sc.Add( @"bin\pais.dll", cs_path + @"\pais.rsp");
      sc.Add( @"bin\articulo.dll", cs_path + @"\articulo.rsp");
      sc.Add( @"bin\categoria.dll", cs_path + @"\categoria.rsp");
      sc.Add( @"bin\medico.dll", cs_path + @"\medico.rsp");
      sc.Add( @"bin\acceso.dll", cs_path + @"\acceso.rsp");
      sc.Add( @"bin\menu.dll", cs_path + @"\menu.rsp");
      sc.Add( @"bin\usuario.dll", cs_path + @"\usuario.rsp");
      sc.Add( @"bin\grupousuario.dll", cs_path + @"\grupousuario.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtMessages_Message.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtLinkList_LinkItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtParametros.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuData_SlideDownMenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuData_SlideDownMenuDataItem_SectionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSlideDownMenuSelectedItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_event.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSchedulerEvents_Day.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtContext.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtProgramNames_ProgramName.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtTabOptions_TabOptionsItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtAgenda.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTrnMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINHttpMethod.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

