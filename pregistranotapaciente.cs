/*
               File: pRegistraNotaPaciente
        Description: Registra información de nota paciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 10/2/2019 15:4:1.73
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class pregistranotapaciente : GXProcedure
   {
      public pregistranotapaciente( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Fantastic");
      }

      public pregistranotapaciente( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_ClinicaCodigo ,
                           ref int aP1_NPacienteId ,
                           ref String aP2_NPacienteNombre1 ,
                           ref String aP3_NPacienteNombre2 ,
                           ref String aP4_NPacienteApellido1 ,
                           ref String aP5_NPacienteApellido2 ,
                           ref String aP6_NPacienteApellido3 ,
                           ref DateTime aP7_NPacienteFechaNac ,
                           ref String aP8_NPacienteSexo ,
                           ref decimal aP9_NPacienteEstatura ,
                           ref String aP10_NPacienteEstaturaEn ,
                           ref decimal aP11_NPacientePeso ,
                           ref String aP12_NPacientePesoEn ,
                           ref int aP13_ProfesionId ,
                           ref int aP14_ReligionId ,
                           ref String aP15_NPacienteDireccion ,
                           ref String aP16_NPacienteCorreo ,
                           ref String aP17_NPacienteFacebook ,
                           ref String aP18_NPacienteTelefono ,
                           ref String aP19_NPacienteCelular ,
                           ref String aP20_NPacienteEnfermedad ,
                           ref String aP21_NPacienteMedicamento ,
                           ref String aP22_NPacienteOperacion ,
                           ref String aP23_NPacienteAlergia ,
                           ref short aP24_NPacienteGesta ,
                           ref short aP25_NPacienteParto ,
                           ref short aP26_NPacienteCesarea ,
                           ref short aP27_NPacienteAborto ,
                           ref short aP28_NPacienteAnestesiaGeneral ,
                           ref short aP29_NPacienteAnestesiaEpidural ,
                           ref short aP30_NPacienteAnestesiaRaquidea ,
                           ref String aP31_NPacienteAnestesiaOtro ,
                           ref String aP32_NPacienteAnestesiaComplica ,
                           ref short aP33_NPacienteFuma ,
                           ref short aP34_NPacienteCigarros ,
                           ref short aP35_NPacienteAlcohol ,
                           ref String aP36_NPacienteOtros ,
                           ref String aP37_UsuarioCodigo )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV10NPacienteId = aP1_NPacienteId;
         this.AV11NPacienteNombre1 = aP2_NPacienteNombre1;
         this.AV12NPacienteNombre2 = aP3_NPacienteNombre2;
         this.AV13NPacienteApellido1 = aP4_NPacienteApellido1;
         this.AV14NPacienteApellido2 = aP5_NPacienteApellido2;
         this.AV15NPacienteApellido3 = aP6_NPacienteApellido3;
         this.AV16NPacienteFechaNac = aP7_NPacienteFechaNac;
         this.AV23NPacienteSexo = aP8_NPacienteSexo;
         this.AV19NPacienteEstatura = aP9_NPacienteEstatura;
         this.AV20NPacienteEstaturaEn = aP10_NPacienteEstaturaEn;
         this.AV17NPacientePeso = aP11_NPacientePeso;
         this.AV18NPacientePesoEn = aP12_NPacientePesoEn;
         this.AV21ProfesionId = aP13_ProfesionId;
         this.AV22ReligionId = aP14_ReligionId;
         this.AV24NPacienteDireccion = aP15_NPacienteDireccion;
         this.AV25NPacienteCorreo = aP16_NPacienteCorreo;
         this.AV26NPacienteFacebook = aP17_NPacienteFacebook;
         this.AV27NPacienteTelefono = aP18_NPacienteTelefono;
         this.AV28NPacienteCelular = aP19_NPacienteCelular;
         this.AV29NPacienteEnfermedad = aP20_NPacienteEnfermedad;
         this.AV30NPacienteMedicamento = aP21_NPacienteMedicamento;
         this.AV31NPacienteOperacion = aP22_NPacienteOperacion;
         this.AV32NPacienteAlergia = aP23_NPacienteAlergia;
         this.AV34NPacienteGesta = aP24_NPacienteGesta;
         this.AV33NPacienteParto = aP25_NPacienteParto;
         this.AV35NPacienteCesarea = aP26_NPacienteCesarea;
         this.AV36NPacienteAborto = aP27_NPacienteAborto;
         this.AV37NPacienteAnestesiaGeneral = aP28_NPacienteAnestesiaGeneral;
         this.AV38NPacienteAnestesiaEpidural = aP29_NPacienteAnestesiaEpidural;
         this.AV39NPacienteAnestesiaRaquidea = aP30_NPacienteAnestesiaRaquidea;
         this.AV40NPacienteAnestesiaOtro = aP31_NPacienteAnestesiaOtro;
         this.AV41NPacienteAnestesiaComplica = aP32_NPacienteAnestesiaComplica;
         this.AV42NPacienteFuma = aP33_NPacienteFuma;
         this.AV43NPacienteCigarros = aP34_NPacienteCigarros;
         this.AV44NPacienteAlcohol = aP35_NPacienteAlcohol;
         this.AV45NPacienteOtros = aP36_NPacienteOtros;
         this.AV9UsuarioCodigo = aP37_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_NPacienteId=this.AV10NPacienteId;
         aP2_NPacienteNombre1=this.AV11NPacienteNombre1;
         aP3_NPacienteNombre2=this.AV12NPacienteNombre2;
         aP4_NPacienteApellido1=this.AV13NPacienteApellido1;
         aP5_NPacienteApellido2=this.AV14NPacienteApellido2;
         aP6_NPacienteApellido3=this.AV15NPacienteApellido3;
         aP7_NPacienteFechaNac=this.AV16NPacienteFechaNac;
         aP8_NPacienteSexo=this.AV23NPacienteSexo;
         aP9_NPacienteEstatura=this.AV19NPacienteEstatura;
         aP10_NPacienteEstaturaEn=this.AV20NPacienteEstaturaEn;
         aP11_NPacientePeso=this.AV17NPacientePeso;
         aP12_NPacientePesoEn=this.AV18NPacientePesoEn;
         aP13_ProfesionId=this.AV21ProfesionId;
         aP14_ReligionId=this.AV22ReligionId;
         aP15_NPacienteDireccion=this.AV24NPacienteDireccion;
         aP16_NPacienteCorreo=this.AV25NPacienteCorreo;
         aP17_NPacienteFacebook=this.AV26NPacienteFacebook;
         aP18_NPacienteTelefono=this.AV27NPacienteTelefono;
         aP19_NPacienteCelular=this.AV28NPacienteCelular;
         aP20_NPacienteEnfermedad=this.AV29NPacienteEnfermedad;
         aP21_NPacienteMedicamento=this.AV30NPacienteMedicamento;
         aP22_NPacienteOperacion=this.AV31NPacienteOperacion;
         aP23_NPacienteAlergia=this.AV32NPacienteAlergia;
         aP24_NPacienteGesta=this.AV34NPacienteGesta;
         aP25_NPacienteParto=this.AV33NPacienteParto;
         aP26_NPacienteCesarea=this.AV35NPacienteCesarea;
         aP27_NPacienteAborto=this.AV36NPacienteAborto;
         aP28_NPacienteAnestesiaGeneral=this.AV37NPacienteAnestesiaGeneral;
         aP29_NPacienteAnestesiaEpidural=this.AV38NPacienteAnestesiaEpidural;
         aP30_NPacienteAnestesiaRaquidea=this.AV39NPacienteAnestesiaRaquidea;
         aP31_NPacienteAnestesiaOtro=this.AV40NPacienteAnestesiaOtro;
         aP32_NPacienteAnestesiaComplica=this.AV41NPacienteAnestesiaComplica;
         aP33_NPacienteFuma=this.AV42NPacienteFuma;
         aP34_NPacienteCigarros=this.AV43NPacienteCigarros;
         aP35_NPacienteAlcohol=this.AV44NPacienteAlcohol;
         aP36_NPacienteOtros=this.AV45NPacienteOtros;
         aP37_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      public String executeUdp( ref String aP0_ClinicaCodigo ,
                                ref int aP1_NPacienteId ,
                                ref String aP2_NPacienteNombre1 ,
                                ref String aP3_NPacienteNombre2 ,
                                ref String aP4_NPacienteApellido1 ,
                                ref String aP5_NPacienteApellido2 ,
                                ref String aP6_NPacienteApellido3 ,
                                ref DateTime aP7_NPacienteFechaNac ,
                                ref String aP8_NPacienteSexo ,
                                ref decimal aP9_NPacienteEstatura ,
                                ref String aP10_NPacienteEstaturaEn ,
                                ref decimal aP11_NPacientePeso ,
                                ref String aP12_NPacientePesoEn ,
                                ref int aP13_ProfesionId ,
                                ref int aP14_ReligionId ,
                                ref String aP15_NPacienteDireccion ,
                                ref String aP16_NPacienteCorreo ,
                                ref String aP17_NPacienteFacebook ,
                                ref String aP18_NPacienteTelefono ,
                                ref String aP19_NPacienteCelular ,
                                ref String aP20_NPacienteEnfermedad ,
                                ref String aP21_NPacienteMedicamento ,
                                ref String aP22_NPacienteOperacion ,
                                ref String aP23_NPacienteAlergia ,
                                ref short aP24_NPacienteGesta ,
                                ref short aP25_NPacienteParto ,
                                ref short aP26_NPacienteCesarea ,
                                ref short aP27_NPacienteAborto ,
                                ref short aP28_NPacienteAnestesiaGeneral ,
                                ref short aP29_NPacienteAnestesiaEpidural ,
                                ref short aP30_NPacienteAnestesiaRaquidea ,
                                ref String aP31_NPacienteAnestesiaOtro ,
                                ref String aP32_NPacienteAnestesiaComplica ,
                                ref short aP33_NPacienteFuma ,
                                ref short aP34_NPacienteCigarros ,
                                ref short aP35_NPacienteAlcohol ,
                                ref String aP36_NPacienteOtros )
      {
         this.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         this.AV10NPacienteId = aP1_NPacienteId;
         this.AV11NPacienteNombre1 = aP2_NPacienteNombre1;
         this.AV12NPacienteNombre2 = aP3_NPacienteNombre2;
         this.AV13NPacienteApellido1 = aP4_NPacienteApellido1;
         this.AV14NPacienteApellido2 = aP5_NPacienteApellido2;
         this.AV15NPacienteApellido3 = aP6_NPacienteApellido3;
         this.AV16NPacienteFechaNac = aP7_NPacienteFechaNac;
         this.AV23NPacienteSexo = aP8_NPacienteSexo;
         this.AV19NPacienteEstatura = aP9_NPacienteEstatura;
         this.AV20NPacienteEstaturaEn = aP10_NPacienteEstaturaEn;
         this.AV17NPacientePeso = aP11_NPacientePeso;
         this.AV18NPacientePesoEn = aP12_NPacientePesoEn;
         this.AV21ProfesionId = aP13_ProfesionId;
         this.AV22ReligionId = aP14_ReligionId;
         this.AV24NPacienteDireccion = aP15_NPacienteDireccion;
         this.AV25NPacienteCorreo = aP16_NPacienteCorreo;
         this.AV26NPacienteFacebook = aP17_NPacienteFacebook;
         this.AV27NPacienteTelefono = aP18_NPacienteTelefono;
         this.AV28NPacienteCelular = aP19_NPacienteCelular;
         this.AV29NPacienteEnfermedad = aP20_NPacienteEnfermedad;
         this.AV30NPacienteMedicamento = aP21_NPacienteMedicamento;
         this.AV31NPacienteOperacion = aP22_NPacienteOperacion;
         this.AV32NPacienteAlergia = aP23_NPacienteAlergia;
         this.AV34NPacienteGesta = aP24_NPacienteGesta;
         this.AV33NPacienteParto = aP25_NPacienteParto;
         this.AV35NPacienteCesarea = aP26_NPacienteCesarea;
         this.AV36NPacienteAborto = aP27_NPacienteAborto;
         this.AV37NPacienteAnestesiaGeneral = aP28_NPacienteAnestesiaGeneral;
         this.AV38NPacienteAnestesiaEpidural = aP29_NPacienteAnestesiaEpidural;
         this.AV39NPacienteAnestesiaRaquidea = aP30_NPacienteAnestesiaRaquidea;
         this.AV40NPacienteAnestesiaOtro = aP31_NPacienteAnestesiaOtro;
         this.AV41NPacienteAnestesiaComplica = aP32_NPacienteAnestesiaComplica;
         this.AV42NPacienteFuma = aP33_NPacienteFuma;
         this.AV43NPacienteCigarros = aP34_NPacienteCigarros;
         this.AV44NPacienteAlcohol = aP35_NPacienteAlcohol;
         this.AV45NPacienteOtros = aP36_NPacienteOtros;
         this.AV9UsuarioCodigo = aP37_UsuarioCodigo;
         initialize();
         executePrivate();
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_NPacienteId=this.AV10NPacienteId;
         aP2_NPacienteNombre1=this.AV11NPacienteNombre1;
         aP3_NPacienteNombre2=this.AV12NPacienteNombre2;
         aP4_NPacienteApellido1=this.AV13NPacienteApellido1;
         aP5_NPacienteApellido2=this.AV14NPacienteApellido2;
         aP6_NPacienteApellido3=this.AV15NPacienteApellido3;
         aP7_NPacienteFechaNac=this.AV16NPacienteFechaNac;
         aP8_NPacienteSexo=this.AV23NPacienteSexo;
         aP9_NPacienteEstatura=this.AV19NPacienteEstatura;
         aP10_NPacienteEstaturaEn=this.AV20NPacienteEstaturaEn;
         aP11_NPacientePeso=this.AV17NPacientePeso;
         aP12_NPacientePesoEn=this.AV18NPacientePesoEn;
         aP13_ProfesionId=this.AV21ProfesionId;
         aP14_ReligionId=this.AV22ReligionId;
         aP15_NPacienteDireccion=this.AV24NPacienteDireccion;
         aP16_NPacienteCorreo=this.AV25NPacienteCorreo;
         aP17_NPacienteFacebook=this.AV26NPacienteFacebook;
         aP18_NPacienteTelefono=this.AV27NPacienteTelefono;
         aP19_NPacienteCelular=this.AV28NPacienteCelular;
         aP20_NPacienteEnfermedad=this.AV29NPacienteEnfermedad;
         aP21_NPacienteMedicamento=this.AV30NPacienteMedicamento;
         aP22_NPacienteOperacion=this.AV31NPacienteOperacion;
         aP23_NPacienteAlergia=this.AV32NPacienteAlergia;
         aP24_NPacienteGesta=this.AV34NPacienteGesta;
         aP25_NPacienteParto=this.AV33NPacienteParto;
         aP26_NPacienteCesarea=this.AV35NPacienteCesarea;
         aP27_NPacienteAborto=this.AV36NPacienteAborto;
         aP28_NPacienteAnestesiaGeneral=this.AV37NPacienteAnestesiaGeneral;
         aP29_NPacienteAnestesiaEpidural=this.AV38NPacienteAnestesiaEpidural;
         aP30_NPacienteAnestesiaRaquidea=this.AV39NPacienteAnestesiaRaquidea;
         aP31_NPacienteAnestesiaOtro=this.AV40NPacienteAnestesiaOtro;
         aP32_NPacienteAnestesiaComplica=this.AV41NPacienteAnestesiaComplica;
         aP33_NPacienteFuma=this.AV42NPacienteFuma;
         aP34_NPacienteCigarros=this.AV43NPacienteCigarros;
         aP35_NPacienteAlcohol=this.AV44NPacienteAlcohol;
         aP36_NPacienteOtros=this.AV45NPacienteOtros;
         aP37_UsuarioCodigo=this.AV9UsuarioCodigo;
         return AV9UsuarioCodigo ;
      }

      public void executeSubmit( ref String aP0_ClinicaCodigo ,
                                 ref int aP1_NPacienteId ,
                                 ref String aP2_NPacienteNombre1 ,
                                 ref String aP3_NPacienteNombre2 ,
                                 ref String aP4_NPacienteApellido1 ,
                                 ref String aP5_NPacienteApellido2 ,
                                 ref String aP6_NPacienteApellido3 ,
                                 ref DateTime aP7_NPacienteFechaNac ,
                                 ref String aP8_NPacienteSexo ,
                                 ref decimal aP9_NPacienteEstatura ,
                                 ref String aP10_NPacienteEstaturaEn ,
                                 ref decimal aP11_NPacientePeso ,
                                 ref String aP12_NPacientePesoEn ,
                                 ref int aP13_ProfesionId ,
                                 ref int aP14_ReligionId ,
                                 ref String aP15_NPacienteDireccion ,
                                 ref String aP16_NPacienteCorreo ,
                                 ref String aP17_NPacienteFacebook ,
                                 ref String aP18_NPacienteTelefono ,
                                 ref String aP19_NPacienteCelular ,
                                 ref String aP20_NPacienteEnfermedad ,
                                 ref String aP21_NPacienteMedicamento ,
                                 ref String aP22_NPacienteOperacion ,
                                 ref String aP23_NPacienteAlergia ,
                                 ref short aP24_NPacienteGesta ,
                                 ref short aP25_NPacienteParto ,
                                 ref short aP26_NPacienteCesarea ,
                                 ref short aP27_NPacienteAborto ,
                                 ref short aP28_NPacienteAnestesiaGeneral ,
                                 ref short aP29_NPacienteAnestesiaEpidural ,
                                 ref short aP30_NPacienteAnestesiaRaquidea ,
                                 ref String aP31_NPacienteAnestesiaOtro ,
                                 ref String aP32_NPacienteAnestesiaComplica ,
                                 ref short aP33_NPacienteFuma ,
                                 ref short aP34_NPacienteCigarros ,
                                 ref short aP35_NPacienteAlcohol ,
                                 ref String aP36_NPacienteOtros ,
                                 ref String aP37_UsuarioCodigo )
      {
         pregistranotapaciente objpregistranotapaciente;
         objpregistranotapaciente = new pregistranotapaciente();
         objpregistranotapaciente.AV8ClinicaCodigo = aP0_ClinicaCodigo;
         objpregistranotapaciente.AV10NPacienteId = aP1_NPacienteId;
         objpregistranotapaciente.AV11NPacienteNombre1 = aP2_NPacienteNombre1;
         objpregistranotapaciente.AV12NPacienteNombre2 = aP3_NPacienteNombre2;
         objpregistranotapaciente.AV13NPacienteApellido1 = aP4_NPacienteApellido1;
         objpregistranotapaciente.AV14NPacienteApellido2 = aP5_NPacienteApellido2;
         objpregistranotapaciente.AV15NPacienteApellido3 = aP6_NPacienteApellido3;
         objpregistranotapaciente.AV16NPacienteFechaNac = aP7_NPacienteFechaNac;
         objpregistranotapaciente.AV23NPacienteSexo = aP8_NPacienteSexo;
         objpregistranotapaciente.AV19NPacienteEstatura = aP9_NPacienteEstatura;
         objpregistranotapaciente.AV20NPacienteEstaturaEn = aP10_NPacienteEstaturaEn;
         objpregistranotapaciente.AV17NPacientePeso = aP11_NPacientePeso;
         objpregistranotapaciente.AV18NPacientePesoEn = aP12_NPacientePesoEn;
         objpregistranotapaciente.AV21ProfesionId = aP13_ProfesionId;
         objpregistranotapaciente.AV22ReligionId = aP14_ReligionId;
         objpregistranotapaciente.AV24NPacienteDireccion = aP15_NPacienteDireccion;
         objpregistranotapaciente.AV25NPacienteCorreo = aP16_NPacienteCorreo;
         objpregistranotapaciente.AV26NPacienteFacebook = aP17_NPacienteFacebook;
         objpregistranotapaciente.AV27NPacienteTelefono = aP18_NPacienteTelefono;
         objpregistranotapaciente.AV28NPacienteCelular = aP19_NPacienteCelular;
         objpregistranotapaciente.AV29NPacienteEnfermedad = aP20_NPacienteEnfermedad;
         objpregistranotapaciente.AV30NPacienteMedicamento = aP21_NPacienteMedicamento;
         objpregistranotapaciente.AV31NPacienteOperacion = aP22_NPacienteOperacion;
         objpregistranotapaciente.AV32NPacienteAlergia = aP23_NPacienteAlergia;
         objpregistranotapaciente.AV34NPacienteGesta = aP24_NPacienteGesta;
         objpregistranotapaciente.AV33NPacienteParto = aP25_NPacienteParto;
         objpregistranotapaciente.AV35NPacienteCesarea = aP26_NPacienteCesarea;
         objpregistranotapaciente.AV36NPacienteAborto = aP27_NPacienteAborto;
         objpregistranotapaciente.AV37NPacienteAnestesiaGeneral = aP28_NPacienteAnestesiaGeneral;
         objpregistranotapaciente.AV38NPacienteAnestesiaEpidural = aP29_NPacienteAnestesiaEpidural;
         objpregistranotapaciente.AV39NPacienteAnestesiaRaquidea = aP30_NPacienteAnestesiaRaquidea;
         objpregistranotapaciente.AV40NPacienteAnestesiaOtro = aP31_NPacienteAnestesiaOtro;
         objpregistranotapaciente.AV41NPacienteAnestesiaComplica = aP32_NPacienteAnestesiaComplica;
         objpregistranotapaciente.AV42NPacienteFuma = aP33_NPacienteFuma;
         objpregistranotapaciente.AV43NPacienteCigarros = aP34_NPacienteCigarros;
         objpregistranotapaciente.AV44NPacienteAlcohol = aP35_NPacienteAlcohol;
         objpregistranotapaciente.AV45NPacienteOtros = aP36_NPacienteOtros;
         objpregistranotapaciente.AV9UsuarioCodigo = aP37_UsuarioCodigo;
         objpregistranotapaciente.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objpregistranotapaciente);
         aP0_ClinicaCodigo=this.AV8ClinicaCodigo;
         aP1_NPacienteId=this.AV10NPacienteId;
         aP2_NPacienteNombre1=this.AV11NPacienteNombre1;
         aP3_NPacienteNombre2=this.AV12NPacienteNombre2;
         aP4_NPacienteApellido1=this.AV13NPacienteApellido1;
         aP5_NPacienteApellido2=this.AV14NPacienteApellido2;
         aP6_NPacienteApellido3=this.AV15NPacienteApellido3;
         aP7_NPacienteFechaNac=this.AV16NPacienteFechaNac;
         aP8_NPacienteSexo=this.AV23NPacienteSexo;
         aP9_NPacienteEstatura=this.AV19NPacienteEstatura;
         aP10_NPacienteEstaturaEn=this.AV20NPacienteEstaturaEn;
         aP11_NPacientePeso=this.AV17NPacientePeso;
         aP12_NPacientePesoEn=this.AV18NPacientePesoEn;
         aP13_ProfesionId=this.AV21ProfesionId;
         aP14_ReligionId=this.AV22ReligionId;
         aP15_NPacienteDireccion=this.AV24NPacienteDireccion;
         aP16_NPacienteCorreo=this.AV25NPacienteCorreo;
         aP17_NPacienteFacebook=this.AV26NPacienteFacebook;
         aP18_NPacienteTelefono=this.AV27NPacienteTelefono;
         aP19_NPacienteCelular=this.AV28NPacienteCelular;
         aP20_NPacienteEnfermedad=this.AV29NPacienteEnfermedad;
         aP21_NPacienteMedicamento=this.AV30NPacienteMedicamento;
         aP22_NPacienteOperacion=this.AV31NPacienteOperacion;
         aP23_NPacienteAlergia=this.AV32NPacienteAlergia;
         aP24_NPacienteGesta=this.AV34NPacienteGesta;
         aP25_NPacienteParto=this.AV33NPacienteParto;
         aP26_NPacienteCesarea=this.AV35NPacienteCesarea;
         aP27_NPacienteAborto=this.AV36NPacienteAborto;
         aP28_NPacienteAnestesiaGeneral=this.AV37NPacienteAnestesiaGeneral;
         aP29_NPacienteAnestesiaEpidural=this.AV38NPacienteAnestesiaEpidural;
         aP30_NPacienteAnestesiaRaquidea=this.AV39NPacienteAnestesiaRaquidea;
         aP31_NPacienteAnestesiaOtro=this.AV40NPacienteAnestesiaOtro;
         aP32_NPacienteAnestesiaComplica=this.AV41NPacienteAnestesiaComplica;
         aP33_NPacienteFuma=this.AV42NPacienteFuma;
         aP34_NPacienteCigarros=this.AV43NPacienteCigarros;
         aP35_NPacienteAlcohol=this.AV44NPacienteAlcohol;
         aP36_NPacienteOtros=this.AV45NPacienteOtros;
         aP37_UsuarioCodigo=this.AV9UsuarioCodigo;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((pregistranotapaciente)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         /*
            INSERT RECORD ON TABLE NotaPaciente

         */
         A41ClinicaCodigo = AV8ClinicaCodigo ;
         A327NPacienteId = AV10NPacienteId ;
         A328NPacienteNombre1 = AV11NPacienteNombre1 ;
         A329NPacienteNombre2 = AV12NPacienteNombre2 ;
         A330NPacienteApellido1 = AV13NPacienteApellido1 ;
         A331NPacienteApellido2 = AV14NPacienteApellido2 ;
         A332NPacienteApellido3 = AV15NPacienteApellido3 ;
         A333NPacienteFechaNac = AV16NPacienteFechaNac ;
         A334NPacienteSexo = AV23NPacienteSexo ;
         A335NPacienteEstatura = AV19NPacienteEstatura ;
         A336NPacienteEstaturaEn = AV20NPacienteEstaturaEn ;
         A337NPacientePeso = AV17NPacientePeso ;
         A338NPacientePesoEn = AV18NPacientePesoEn ;
         A313ProfesionId = AV21ProfesionId ;
         A315ReligionId = AV22ReligionId ;
         A339NPacienteDireccion = AV24NPacienteDireccion ;
         A340NPacienteCorreo = AV25NPacienteCorreo ;
         A341NPacienteFacebook = AV26NPacienteFacebook ;
         A342NPacienteTelefono = AV27NPacienteTelefono ;
         A343NPacienteCelular = AV28NPacienteCelular ;
         A344NPacienteEnfermedad = AV29NPacienteEnfermedad ;
         A345NPacienteMedicamento = AV30NPacienteMedicamento ;
         A346NPacienteOperacion = AV31NPacienteOperacion ;
         A347NPacienteAlergia = AV32NPacienteAlergia ;
         A348NPacienteGesta = AV34NPacienteGesta ;
         A349NPacienteParto = AV33NPacienteParto ;
         A350NPacienteCesarea = AV35NPacienteCesarea ;
         A351NPacienteAborto = AV36NPacienteAborto ;
         A352NPacienteAnestesiaGeneral = AV37NPacienteAnestesiaGeneral ;
         A353NPacienteAnestesiaEpidural = AV38NPacienteAnestesiaEpidural ;
         A354NPacienteAnestesiaRaquidea = AV39NPacienteAnestesiaRaquidea ;
         A355NPacienteAnestesiaOtro = AV40NPacienteAnestesiaOtro ;
         A356NPacienteAnestesiaComplica = AV41NPacienteAnestesiaComplica ;
         A357NPacienteFuma = AV42NPacienteFuma ;
         A358NPacienteCigarros = AV43NPacienteCigarros ;
         A359NPacienteAlcohol = AV44NPacienteAlcohol ;
         A360NPacienteOtros = AV45NPacienteOtros ;
         A361NPacienteFecha = Gx_date ;
         A362NPacienteHora = Gx_time ;
         A4UsuarioCodigo = AV9UsuarioCodigo ;
         A144TipoPacCodigo = "000" ;
         n144TipoPacCodigo = false ;
         A317VendedorCodigo = "0000" ;
         n317VendedorCodigo = false ;
         A364NPacienteEstatus = 1 ;
         /* Using cursor P001F2 */
         pr_default.execute(0, new Object[] {A41ClinicaCodigo, A327NPacienteId, A328NPacienteNombre1, A329NPacienteNombre2, A330NPacienteApellido1, A331NPacienteApellido2, A332NPacienteApellido3, A333NPacienteFechaNac, A334NPacienteSexo, A335NPacienteEstatura, A336NPacienteEstaturaEn, A337NPacientePeso, A338NPacientePesoEn, A313ProfesionId, A315ReligionId, A339NPacienteDireccion, A340NPacienteCorreo, A341NPacienteFacebook, A342NPacienteTelefono, A343NPacienteCelular, A344NPacienteEnfermedad, A345NPacienteMedicamento, A346NPacienteOperacion, A347NPacienteAlergia, A348NPacienteGesta, A349NPacienteParto, A350NPacienteCesarea, A351NPacienteAborto, A352NPacienteAnestesiaGeneral, A353NPacienteAnestesiaEpidural, A354NPacienteAnestesiaRaquidea, A355NPacienteAnestesiaOtro, A356NPacienteAnestesiaComplica, A357NPacienteFuma, A358NPacienteCigarros, A359NPacienteAlcohol, A360NPacienteOtros, A361NPacienteFecha, A362NPacienteHora, A4UsuarioCodigo, n144TipoPacCodigo, A144TipoPacCodigo, n317VendedorCodigo, A317VendedorCodigo, A364NPacienteEstatus});
         pr_default.close(0);
         if ( (pr_default.getStatus(0) == 1) )
         {
            context.Gx_err = 1 ;
            Gx_emsg = (String)(context.GetMessage( "GXM_noupdate", "")) ;
            GX_msglist.addItem("Registro ya existe");
         }
         else
         {
            context.Gx_err = 0 ;
            Gx_emsg = "" ;
         }
         /* End Insert */
         this.cleanup();
      }

      protected void cleanup( )
      {
         context.CommitDataStores("pRegistraNotaPaciente");
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         A41ClinicaCodigo = "" ;
         A328NPacienteNombre1 = "" ;
         A329NPacienteNombre2 = "" ;
         A330NPacienteApellido1 = "" ;
         A331NPacienteApellido2 = "" ;
         A332NPacienteApellido3 = "" ;
         A333NPacienteFechaNac = DateTime.MinValue ;
         A334NPacienteSexo = "" ;
         A336NPacienteEstaturaEn = "" ;
         A338NPacientePesoEn = "" ;
         A339NPacienteDireccion = "" ;
         A340NPacienteCorreo = "" ;
         A341NPacienteFacebook = "" ;
         A342NPacienteTelefono = "" ;
         A343NPacienteCelular = "" ;
         A344NPacienteEnfermedad = "" ;
         A345NPacienteMedicamento = "" ;
         A346NPacienteOperacion = "" ;
         A347NPacienteAlergia = "" ;
         A355NPacienteAnestesiaOtro = "" ;
         A356NPacienteAnestesiaComplica = "" ;
         A360NPacienteOtros = "" ;
         A361NPacienteFecha = DateTime.MinValue ;
         Gx_date = DateTime.MinValue ;
         A362NPacienteHora = "" ;
         Gx_time = "" ;
         A4UsuarioCodigo = "" ;
         A144TipoPacCodigo = "" ;
         A317VendedorCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.pregistranotapaciente__default(),
            new Object[][] {
                new Object[] {
               }
            }
         );
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         /* GeneXus formulas. */
         Gx_time = context.localUtil.Time( ) ;
         Gx_date = DateTimeUtil.Today( ) ;
         context.Gx_err = 0 ;
      }

      private short AV34NPacienteGesta ;
      private short AV33NPacienteParto ;
      private short AV35NPacienteCesarea ;
      private short AV36NPacienteAborto ;
      private short AV37NPacienteAnestesiaGeneral ;
      private short AV38NPacienteAnestesiaEpidural ;
      private short AV39NPacienteAnestesiaRaquidea ;
      private short AV42NPacienteFuma ;
      private short AV43NPacienteCigarros ;
      private short AV44NPacienteAlcohol ;
      private short A348NPacienteGesta ;
      private short A349NPacienteParto ;
      private short A350NPacienteCesarea ;
      private short A351NPacienteAborto ;
      private short A352NPacienteAnestesiaGeneral ;
      private short A353NPacienteAnestesiaEpidural ;
      private short A354NPacienteAnestesiaRaquidea ;
      private short A357NPacienteFuma ;
      private short A358NPacienteCigarros ;
      private short A359NPacienteAlcohol ;
      private short A364NPacienteEstatus ;
      private int AV10NPacienteId ;
      private int AV21ProfesionId ;
      private int AV22ReligionId ;
      private int GX_INS75 ;
      private int A327NPacienteId ;
      private int A313ProfesionId ;
      private int A315ReligionId ;
      private decimal AV19NPacienteEstatura ;
      private decimal AV17NPacientePeso ;
      private decimal A335NPacienteEstatura ;
      private decimal A337NPacientePeso ;
      private String A362NPacienteHora ;
      private String Gx_time ;
      private String Gx_emsg ;
      private DateTime AV16NPacienteFechaNac ;
      private DateTime A333NPacienteFechaNac ;
      private DateTime A361NPacienteFecha ;
      private DateTime Gx_date ;
      private bool n144TipoPacCodigo ;
      private bool n317VendedorCodigo ;
      private String AV8ClinicaCodigo ;
      private String AV11NPacienteNombre1 ;
      private String AV12NPacienteNombre2 ;
      private String AV13NPacienteApellido1 ;
      private String AV14NPacienteApellido2 ;
      private String AV15NPacienteApellido3 ;
      private String AV23NPacienteSexo ;
      private String AV20NPacienteEstaturaEn ;
      private String AV18NPacientePesoEn ;
      private String AV24NPacienteDireccion ;
      private String AV25NPacienteCorreo ;
      private String AV26NPacienteFacebook ;
      private String AV27NPacienteTelefono ;
      private String AV28NPacienteCelular ;
      private String AV29NPacienteEnfermedad ;
      private String AV30NPacienteMedicamento ;
      private String AV31NPacienteOperacion ;
      private String AV32NPacienteAlergia ;
      private String AV40NPacienteAnestesiaOtro ;
      private String AV41NPacienteAnestesiaComplica ;
      private String AV45NPacienteOtros ;
      private String AV9UsuarioCodigo ;
      private String A41ClinicaCodigo ;
      private String A328NPacienteNombre1 ;
      private String A329NPacienteNombre2 ;
      private String A330NPacienteApellido1 ;
      private String A331NPacienteApellido2 ;
      private String A332NPacienteApellido3 ;
      private String A334NPacienteSexo ;
      private String A336NPacienteEstaturaEn ;
      private String A338NPacientePesoEn ;
      private String A339NPacienteDireccion ;
      private String A340NPacienteCorreo ;
      private String A341NPacienteFacebook ;
      private String A342NPacienteTelefono ;
      private String A343NPacienteCelular ;
      private String A344NPacienteEnfermedad ;
      private String A345NPacienteMedicamento ;
      private String A346NPacienteOperacion ;
      private String A347NPacienteAlergia ;
      private String A355NPacienteAnestesiaOtro ;
      private String A356NPacienteAnestesiaComplica ;
      private String A360NPacienteOtros ;
      private String A4UsuarioCodigo ;
      private String A144TipoPacCodigo ;
      private String A317VendedorCodigo ;
      private IGxDataStore dsDefault ;
      private String aP0_ClinicaCodigo ;
      private int aP1_NPacienteId ;
      private String aP2_NPacienteNombre1 ;
      private String aP3_NPacienteNombre2 ;
      private String aP4_NPacienteApellido1 ;
      private String aP5_NPacienteApellido2 ;
      private String aP6_NPacienteApellido3 ;
      private DateTime aP7_NPacienteFechaNac ;
      private String aP8_NPacienteSexo ;
      private decimal aP9_NPacienteEstatura ;
      private String aP10_NPacienteEstaturaEn ;
      private decimal aP11_NPacientePeso ;
      private String aP12_NPacientePesoEn ;
      private int aP13_ProfesionId ;
      private int aP14_ReligionId ;
      private String aP15_NPacienteDireccion ;
      private String aP16_NPacienteCorreo ;
      private String aP17_NPacienteFacebook ;
      private String aP18_NPacienteTelefono ;
      private String aP19_NPacienteCelular ;
      private String aP20_NPacienteEnfermedad ;
      private String aP21_NPacienteMedicamento ;
      private String aP22_NPacienteOperacion ;
      private String aP23_NPacienteAlergia ;
      private short aP24_NPacienteGesta ;
      private short aP25_NPacienteParto ;
      private short aP26_NPacienteCesarea ;
      private short aP27_NPacienteAborto ;
      private short aP28_NPacienteAnestesiaGeneral ;
      private short aP29_NPacienteAnestesiaEpidural ;
      private short aP30_NPacienteAnestesiaRaquidea ;
      private String aP31_NPacienteAnestesiaOtro ;
      private String aP32_NPacienteAnestesiaComplica ;
      private short aP33_NPacienteFuma ;
      private short aP34_NPacienteCigarros ;
      private short aP35_NPacienteAlcohol ;
      private String aP36_NPacienteOtros ;
      private String aP37_UsuarioCodigo ;
      private IDataStoreProvider pr_default ;
   }

   public class pregistranotapaciente__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new UpdateCursor(def[0])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP001F2 ;
          prmP001F2 = new Object[] {
          new Object[] {"@ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@NPacienteNombre1",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteNombre2",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@NPacienteFechaNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@NPacienteEstatura",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacienteEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@NPacientePeso",SqlDbType.Decimal,17,2} ,
          new Object[] {"@NPacientePesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@ReligionId",SqlDbType.Int,9,0} ,
          new Object[] {"@NPacienteDireccion",SqlDbType.VarChar,120,0} ,
          new Object[] {"@NPacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteFacebook",SqlDbType.VarChar,80,0} ,
          new Object[] {"@NPacienteTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@NPacienteEnfermedad",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteMedicamento",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteOperacion",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteAlergia",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteGesta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteParto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteCesarea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAborto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAnestesiaGeneral",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaEpidural",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaRaquidea",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteAnestesiaOtro",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteAnestesiaComplica",SqlDbType.VarChar,600,0} ,
          new Object[] {"@NPacienteFuma",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteCigarros",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@NPacienteAlcohol",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@NPacienteOtros",SqlDbType.VarChar,70,0} ,
          new Object[] {"@NPacienteFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@NPacienteHora",SqlDbType.Char,8,0} ,
          new Object[] {"@UsuarioCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@VendedorCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@NPacienteEstatus",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P001F2", "INSERT INTO [NotaPaciente] ([ClinicaCodigo], [NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [ProfesionId], [ReligionId], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros], [NPacienteFecha], [NPacienteHora], [UsuarioCodigo], [TipoPacCodigo], [VendedorCodigo], [NPacienteEstatus]) VALUES (@ClinicaCodigo, @NPacienteId, @NPacienteNombre1, @NPacienteNombre2, @NPacienteApellido1, @NPacienteApellido2, @NPacienteApellido3, @NPacienteFechaNac, @NPacienteSexo, @NPacienteEstatura, @NPacienteEstaturaEn, @NPacientePeso, @NPacientePesoEn, @ProfesionId, @ReligionId, @NPacienteDireccion, @NPacienteCorreo, @NPacienteFacebook, @NPacienteTelefono, @NPacienteCelular, @NPacienteEnfermedad, @NPacienteMedicamento, @NPacienteOperacion, @NPacienteAlergia, @NPacienteGesta, @NPacienteParto, @NPacienteCesarea, @NPacienteAborto, @NPacienteAnestesiaGeneral, @NPacienteAnestesiaEpidural, @NPacienteAnestesiaRaquidea, @NPacienteAnestesiaOtro, @NPacienteAnestesiaComplica, @NPacienteFuma, @NPacienteCigarros, @NPacienteAlcohol, @NPacienteOtros, @NPacienteFecha, @NPacienteHora, @UsuarioCodigo, @TipoPacCodigo, @VendedorCodigo, @NPacienteEstatus)", GxErrorMask.GX_NOMASK,prmP001F2)
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
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
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (DateTime)parms[7]);
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (decimal)parms[9]);
                stmt.SetParameter(11, (String)parms[10]);
                stmt.SetParameter(12, (decimal)parms[11]);
                stmt.SetParameter(13, (String)parms[12]);
                stmt.SetParameter(14, (int)parms[13]);
                stmt.SetParameter(15, (int)parms[14]);
                stmt.SetParameter(16, (String)parms[15]);
                stmt.SetParameter(17, (String)parms[16]);
                stmt.SetParameter(18, (String)parms[17]);
                stmt.SetParameter(19, (String)parms[18]);
                stmt.SetParameter(20, (String)parms[19]);
                stmt.SetParameter(21, (String)parms[20]);
                stmt.SetParameter(22, (String)parms[21]);
                stmt.SetParameter(23, (String)parms[22]);
                stmt.SetParameter(24, (String)parms[23]);
                stmt.SetParameter(25, (short)parms[24]);
                stmt.SetParameter(26, (short)parms[25]);
                stmt.SetParameter(27, (short)parms[26]);
                stmt.SetParameter(28, (short)parms[27]);
                stmt.SetParameter(29, (short)parms[28]);
                stmt.SetParameter(30, (short)parms[29]);
                stmt.SetParameter(31, (short)parms[30]);
                stmt.SetParameter(32, (String)parms[31]);
                stmt.SetParameter(33, (String)parms[32]);
                stmt.SetParameter(34, (short)parms[33]);
                stmt.SetParameter(35, (short)parms[34]);
                stmt.SetParameter(36, (short)parms[35]);
                stmt.SetParameter(37, (String)parms[36]);
                stmt.SetParameter(38, (DateTime)parms[37]);
                stmt.SetParameter(39, (String)parms[38]);
                stmt.SetParameter(40, (String)parms[39]);
                if ( (bool)parms[40] )
                {
                   stmt.setNull( 41 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(41, (String)parms[41]);
                }
                if ( (bool)parms[42] )
                {
                   stmt.setNull( 42 , SqlDbType.VarChar );
                }
                else
                {
                   stmt.SetParameter(42, (String)parms[43]);
                }
                stmt.SetParameter(43, (short)parms[44]);
                break;
       }
    }

 }

}
