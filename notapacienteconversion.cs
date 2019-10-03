/*
               File: NotaPacienteConversion
        Description: Conversion for table NotaPaciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 8/14/2019 14:35:37.3
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class notapacienteconversion : GXProcedure
   {
      public notapacienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public notapacienteconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         notapacienteconversion objnotapacienteconversion;
         objnotapacienteconversion = new notapacienteconversion();
         objnotapacienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objnotapacienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((notapacienteconversion)stateInfo).executePrivate();
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
         /* Using cursor NOTAPACIEN2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A359NPacienteAlcohol = NOTAPACIEN2_A359NPacienteAlcohol[0] ;
            A358NPacienteCigarros = NOTAPACIEN2_A358NPacienteCigarros[0] ;
            A357NPacienteFuma = NOTAPACIEN2_A357NPacienteFuma[0] ;
            A356NPacienteAnestesiaComplica = NOTAPACIEN2_A356NPacienteAnestesiaComplica[0] ;
            A355NPacienteAnestesiaOtro = NOTAPACIEN2_A355NPacienteAnestesiaOtro[0] ;
            A354NPacienteAnestesiaRaquidea = NOTAPACIEN2_A354NPacienteAnestesiaRaquidea[0] ;
            A353NPacienteAnestesiaEpidural = NOTAPACIEN2_A353NPacienteAnestesiaEpidural[0] ;
            A352NPacienteAnestesiaGeneral = NOTAPACIEN2_A352NPacienteAnestesiaGeneral[0] ;
            A351NPacienteAborto = NOTAPACIEN2_A351NPacienteAborto[0] ;
            A350NPacienteCesarea = NOTAPACIEN2_A350NPacienteCesarea[0] ;
            A349NPacienteParto = NOTAPACIEN2_A349NPacienteParto[0] ;
            A348NPacienteGesta = NOTAPACIEN2_A348NPacienteGesta[0] ;
            A347NPacienteAlergia = NOTAPACIEN2_A347NPacienteAlergia[0] ;
            A346NPacienteOperacion = NOTAPACIEN2_A346NPacienteOperacion[0] ;
            A345NPacienteMedicamento = NOTAPACIEN2_A345NPacienteMedicamento[0] ;
            A344NPacienteEnfermedad = NOTAPACIEN2_A344NPacienteEnfermedad[0] ;
            A343NPacienteCelular = NOTAPACIEN2_A343NPacienteCelular[0] ;
            A342NPacienteTelefono = NOTAPACIEN2_A342NPacienteTelefono[0] ;
            A341NPacienteFacebook = NOTAPACIEN2_A341NPacienteFacebook[0] ;
            A340NPacienteCorreo = NOTAPACIEN2_A340NPacienteCorreo[0] ;
            A339NPacienteDireccion = NOTAPACIEN2_A339NPacienteDireccion[0] ;
            A315ReligionId = NOTAPACIEN2_A315ReligionId[0] ;
            A313ProfesionId = NOTAPACIEN2_A313ProfesionId[0] ;
            A338NPacientePesoEn = NOTAPACIEN2_A338NPacientePesoEn[0] ;
            A337NPacientePeso = NOTAPACIEN2_A337NPacientePeso[0] ;
            A336NPacienteEstaturaEn = NOTAPACIEN2_A336NPacienteEstaturaEn[0] ;
            A335NPacienteEstatura = NOTAPACIEN2_A335NPacienteEstatura[0] ;
            A334NPacienteSexo = NOTAPACIEN2_A334NPacienteSexo[0] ;
            A333NPacienteFechaNac = NOTAPACIEN2_A333NPacienteFechaNac[0] ;
            A332NPacienteApellido3 = NOTAPACIEN2_A332NPacienteApellido3[0] ;
            A331NPacienteApellido2 = NOTAPACIEN2_A331NPacienteApellido2[0] ;
            A330NPacienteApellido1 = NOTAPACIEN2_A330NPacienteApellido1[0] ;
            A329NPacienteNombre2 = NOTAPACIEN2_A329NPacienteNombre2[0] ;
            A328NPacienteNombre1 = NOTAPACIEN2_A328NPacienteNombre1[0] ;
            A327NPacienteId = NOTAPACIEN2_A327NPacienteId[0] ;
            A41ClinicaCodigo = NOTAPACIEN2_A41ClinicaCodigo[0] ;
            A360NPacienteOtros = NOTAPACIEN2_A360NPacienteOtros[0] ;
            A40000GXC1 = StringUtil.Substring( A360NPacienteOtros, 1, 30) ;
            /*
               INSERT RECORD ON TABLE GXA0075

            */
            AV2ClinicaCodigo = A41ClinicaCodigo ;
            AV3NPacienteId = A327NPacienteId ;
            AV4NPacienteNombre1 = A328NPacienteNombre1 ;
            AV5NPacienteNombre2 = A329NPacienteNombre2 ;
            AV6NPacienteApellido1 = A330NPacienteApellido1 ;
            AV7NPacienteApellido2 = A331NPacienteApellido2 ;
            AV8NPacienteApellido3 = A332NPacienteApellido3 ;
            AV9NPacienteFechaNac = A333NPacienteFechaNac ;
            AV10NPacienteSexo = A334NPacienteSexo ;
            AV11NPacienteEstatura = A335NPacienteEstatura ;
            AV12NPacienteEstaturaEn = A336NPacienteEstaturaEn ;
            AV13NPacientePeso = A337NPacientePeso ;
            AV14NPacientePesoEn = A338NPacientePesoEn ;
            AV15ProfesionId = A313ProfesionId ;
            AV16ReligionId = A315ReligionId ;
            AV17NPacienteDireccion = A339NPacienteDireccion ;
            AV18NPacienteCorreo = A340NPacienteCorreo ;
            AV19NPacienteFacebook = A341NPacienteFacebook ;
            AV20NPacienteTelefono = A342NPacienteTelefono ;
            AV21NPacienteCelular = A343NPacienteCelular ;
            AV22NPacienteEnfermedad = A344NPacienteEnfermedad ;
            AV23NPacienteMedicamento = A345NPacienteMedicamento ;
            AV24NPacienteOperacion = A346NPacienteOperacion ;
            AV25NPacienteAlergia = A347NPacienteAlergia ;
            AV26NPacienteGesta = A348NPacienteGesta ;
            AV27NPacienteParto = A349NPacienteParto ;
            AV28NPacienteCesarea = A350NPacienteCesarea ;
            AV29NPacienteAborto = A351NPacienteAborto ;
            AV30NPacienteAnestesiaGeneral = A352NPacienteAnestesiaGeneral ;
            AV31NPacienteAnestesiaEpidural = A353NPacienteAnestesiaEpidural ;
            AV32NPacienteAnestesiaRaquidea = A354NPacienteAnestesiaRaquidea ;
            AV33NPacienteAnestesiaOtro = A355NPacienteAnestesiaOtro ;
            AV34NPacienteAnestesiaComplica = A356NPacienteAnestesiaComplica ;
            AV35NPacienteFuma = A357NPacienteFuma ;
            AV36NPacienteCigarros = A358NPacienteCigarros ;
            AV37NPacienteAlcohol = A359NPacienteAlcohol ;
            AV38NPacienteOtros = A40000GXC1 ;
            /* Using cursor NOTAPACIEN3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3NPacienteId, AV4NPacienteNombre1, AV5NPacienteNombre2, AV6NPacienteApellido1, AV7NPacienteApellido2, AV8NPacienteApellido3, AV9NPacienteFechaNac, AV10NPacienteSexo, AV11NPacienteEstatura, AV12NPacienteEstaturaEn, AV13NPacientePeso, AV14NPacientePesoEn, AV15ProfesionId, AV16ReligionId, AV17NPacienteDireccion, AV18NPacienteCorreo, AV19NPacienteFacebook, AV20NPacienteTelefono, AV21NPacienteCelular, AV22NPacienteEnfermedad, AV23NPacienteMedicamento, AV24NPacienteOperacion, AV25NPacienteAlergia, AV26NPacienteGesta, AV27NPacienteParto, AV28NPacienteCesarea, AV29NPacienteAborto, AV30NPacienteAnestesiaGeneral, AV31NPacienteAnestesiaEpidural, AV32NPacienteAnestesiaRaquidea, AV33NPacienteAnestesiaOtro, AV34NPacienteAnestesiaComplica, AV35NPacienteFuma, AV36NPacienteCigarros, AV37NPacienteAlcohol, AV38NPacienteOtros});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
         this.cleanup();
      }

      protected void cleanup( )
      {
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
         scmdbuf = "" ;
         NOTAPACIEN2_A359NPacienteAlcohol = new short[1] ;
         NOTAPACIEN2_A358NPacienteCigarros = new short[1] ;
         NOTAPACIEN2_A357NPacienteFuma = new short[1] ;
         NOTAPACIEN2_A356NPacienteAnestesiaComplica = new String[] {""} ;
         NOTAPACIEN2_A355NPacienteAnestesiaOtro = new String[] {""} ;
         NOTAPACIEN2_A354NPacienteAnestesiaRaquidea = new short[1] ;
         NOTAPACIEN2_A353NPacienteAnestesiaEpidural = new short[1] ;
         NOTAPACIEN2_A352NPacienteAnestesiaGeneral = new short[1] ;
         NOTAPACIEN2_A351NPacienteAborto = new short[1] ;
         NOTAPACIEN2_A350NPacienteCesarea = new short[1] ;
         NOTAPACIEN2_A349NPacienteParto = new short[1] ;
         NOTAPACIEN2_A348NPacienteGesta = new short[1] ;
         NOTAPACIEN2_A347NPacienteAlergia = new String[] {""} ;
         NOTAPACIEN2_A346NPacienteOperacion = new String[] {""} ;
         NOTAPACIEN2_A345NPacienteMedicamento = new String[] {""} ;
         NOTAPACIEN2_A344NPacienteEnfermedad = new String[] {""} ;
         NOTAPACIEN2_A343NPacienteCelular = new String[] {""} ;
         NOTAPACIEN2_A342NPacienteTelefono = new String[] {""} ;
         NOTAPACIEN2_A341NPacienteFacebook = new String[] {""} ;
         NOTAPACIEN2_A340NPacienteCorreo = new String[] {""} ;
         NOTAPACIEN2_A339NPacienteDireccion = new String[] {""} ;
         NOTAPACIEN2_A315ReligionId = new int[1] ;
         NOTAPACIEN2_A313ProfesionId = new int[1] ;
         NOTAPACIEN2_A338NPacientePesoEn = new String[] {""} ;
         NOTAPACIEN2_A337NPacientePeso = new decimal[1] ;
         NOTAPACIEN2_A336NPacienteEstaturaEn = new String[] {""} ;
         NOTAPACIEN2_A335NPacienteEstatura = new decimal[1] ;
         NOTAPACIEN2_A334NPacienteSexo = new String[] {""} ;
         NOTAPACIEN2_A333NPacienteFechaNac = new DateTime[] {DateTime.MinValue} ;
         NOTAPACIEN2_A332NPacienteApellido3 = new String[] {""} ;
         NOTAPACIEN2_A331NPacienteApellido2 = new String[] {""} ;
         NOTAPACIEN2_A330NPacienteApellido1 = new String[] {""} ;
         NOTAPACIEN2_A329NPacienteNombre2 = new String[] {""} ;
         NOTAPACIEN2_A328NPacienteNombre1 = new String[] {""} ;
         NOTAPACIEN2_A327NPacienteId = new int[1] ;
         NOTAPACIEN2_A41ClinicaCodigo = new String[] {""} ;
         NOTAPACIEN2_A360NPacienteOtros = new String[] {""} ;
         A356NPacienteAnestesiaComplica = "" ;
         A355NPacienteAnestesiaOtro = "" ;
         A347NPacienteAlergia = "" ;
         A346NPacienteOperacion = "" ;
         A345NPacienteMedicamento = "" ;
         A344NPacienteEnfermedad = "" ;
         A343NPacienteCelular = "" ;
         A342NPacienteTelefono = "" ;
         A341NPacienteFacebook = "" ;
         A340NPacienteCorreo = "" ;
         A339NPacienteDireccion = "" ;
         A338NPacientePesoEn = "" ;
         A336NPacienteEstaturaEn = "" ;
         A334NPacienteSexo = "" ;
         A333NPacienteFechaNac = DateTime.MinValue ;
         A332NPacienteApellido3 = "" ;
         A331NPacienteApellido2 = "" ;
         A330NPacienteApellido1 = "" ;
         A329NPacienteNombre2 = "" ;
         A328NPacienteNombre1 = "" ;
         A41ClinicaCodigo = "" ;
         A360NPacienteOtros = "" ;
         A40000GXC1 = "" ;
         AV2ClinicaCodigo = "" ;
         AV4NPacienteNombre1 = "" ;
         AV5NPacienteNombre2 = "" ;
         AV6NPacienteApellido1 = "" ;
         AV7NPacienteApellido2 = "" ;
         AV8NPacienteApellido3 = "" ;
         AV9NPacienteFechaNac = DateTime.MinValue ;
         AV10NPacienteSexo = "" ;
         AV12NPacienteEstaturaEn = "" ;
         AV14NPacientePesoEn = "" ;
         AV17NPacienteDireccion = "" ;
         AV18NPacienteCorreo = "" ;
         AV19NPacienteFacebook = "" ;
         AV20NPacienteTelefono = "" ;
         AV21NPacienteCelular = "" ;
         AV22NPacienteEnfermedad = "" ;
         AV23NPacienteMedicamento = "" ;
         AV24NPacienteOperacion = "" ;
         AV25NPacienteAlergia = "" ;
         AV33NPacienteAnestesiaOtro = "" ;
         AV34NPacienteAnestesiaComplica = "" ;
         AV38NPacienteOtros = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.notapacienteconversion__default(),
            new Object[][] {
                new Object[] {
               NOTAPACIEN2_A359NPacienteAlcohol, NOTAPACIEN2_A358NPacienteCigarros, NOTAPACIEN2_A357NPacienteFuma, NOTAPACIEN2_A356NPacienteAnestesiaComplica, NOTAPACIEN2_A355NPacienteAnestesiaOtro, NOTAPACIEN2_A354NPacienteAnestesiaRaquidea, NOTAPACIEN2_A353NPacienteAnestesiaEpidural, NOTAPACIEN2_A352NPacienteAnestesiaGeneral, NOTAPACIEN2_A351NPacienteAborto, NOTAPACIEN2_A350NPacienteCesarea,
               NOTAPACIEN2_A349NPacienteParto, NOTAPACIEN2_A348NPacienteGesta, NOTAPACIEN2_A347NPacienteAlergia, NOTAPACIEN2_A346NPacienteOperacion, NOTAPACIEN2_A345NPacienteMedicamento, NOTAPACIEN2_A344NPacienteEnfermedad, NOTAPACIEN2_A343NPacienteCelular, NOTAPACIEN2_A342NPacienteTelefono, NOTAPACIEN2_A341NPacienteFacebook, NOTAPACIEN2_A340NPacienteCorreo,
               NOTAPACIEN2_A339NPacienteDireccion, NOTAPACIEN2_A315ReligionId, NOTAPACIEN2_A313ProfesionId, NOTAPACIEN2_A338NPacientePesoEn, NOTAPACIEN2_A337NPacientePeso, NOTAPACIEN2_A336NPacienteEstaturaEn, NOTAPACIEN2_A335NPacienteEstatura, NOTAPACIEN2_A334NPacienteSexo, NOTAPACIEN2_A333NPacienteFechaNac, NOTAPACIEN2_A332NPacienteApellido3,
               NOTAPACIEN2_A331NPacienteApellido2, NOTAPACIEN2_A330NPacienteApellido1, NOTAPACIEN2_A329NPacienteNombre2, NOTAPACIEN2_A328NPacienteNombre1, NOTAPACIEN2_A327NPacienteId, NOTAPACIEN2_A41ClinicaCodigo, NOTAPACIEN2_A360NPacienteOtros
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A359NPacienteAlcohol ;
      private short A358NPacienteCigarros ;
      private short A357NPacienteFuma ;
      private short A354NPacienteAnestesiaRaquidea ;
      private short A353NPacienteAnestesiaEpidural ;
      private short A352NPacienteAnestesiaGeneral ;
      private short A351NPacienteAborto ;
      private short A350NPacienteCesarea ;
      private short A349NPacienteParto ;
      private short A348NPacienteGesta ;
      private short AV26NPacienteGesta ;
      private short AV27NPacienteParto ;
      private short AV28NPacienteCesarea ;
      private short AV29NPacienteAborto ;
      private short AV30NPacienteAnestesiaGeneral ;
      private short AV31NPacienteAnestesiaEpidural ;
      private short AV32NPacienteAnestesiaRaquidea ;
      private short AV35NPacienteFuma ;
      private short AV36NPacienteCigarros ;
      private short AV37NPacienteAlcohol ;
      private int A315ReligionId ;
      private int A313ProfesionId ;
      private int A327NPacienteId ;
      private int GIGXA0075 ;
      private int AV3NPacienteId ;
      private int AV15ProfesionId ;
      private int AV16ReligionId ;
      private decimal A337NPacientePeso ;
      private decimal A335NPacienteEstatura ;
      private decimal AV11NPacienteEstatura ;
      private decimal AV13NPacientePeso ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A333NPacienteFechaNac ;
      private DateTime AV9NPacienteFechaNac ;
      private String A356NPacienteAnestesiaComplica ;
      private String A355NPacienteAnestesiaOtro ;
      private String A347NPacienteAlergia ;
      private String A346NPacienteOperacion ;
      private String A345NPacienteMedicamento ;
      private String A344NPacienteEnfermedad ;
      private String A343NPacienteCelular ;
      private String A342NPacienteTelefono ;
      private String A341NPacienteFacebook ;
      private String A340NPacienteCorreo ;
      private String A339NPacienteDireccion ;
      private String A338NPacientePesoEn ;
      private String A336NPacienteEstaturaEn ;
      private String A334NPacienteSexo ;
      private String A332NPacienteApellido3 ;
      private String A331NPacienteApellido2 ;
      private String A330NPacienteApellido1 ;
      private String A329NPacienteNombre2 ;
      private String A328NPacienteNombre1 ;
      private String A41ClinicaCodigo ;
      private String A360NPacienteOtros ;
      private String A40000GXC1 ;
      private String AV2ClinicaCodigo ;
      private String AV4NPacienteNombre1 ;
      private String AV5NPacienteNombre2 ;
      private String AV6NPacienteApellido1 ;
      private String AV7NPacienteApellido2 ;
      private String AV8NPacienteApellido3 ;
      private String AV10NPacienteSexo ;
      private String AV12NPacienteEstaturaEn ;
      private String AV14NPacientePesoEn ;
      private String AV17NPacienteDireccion ;
      private String AV18NPacienteCorreo ;
      private String AV19NPacienteFacebook ;
      private String AV20NPacienteTelefono ;
      private String AV21NPacienteCelular ;
      private String AV22NPacienteEnfermedad ;
      private String AV23NPacienteMedicamento ;
      private String AV24NPacienteOperacion ;
      private String AV25NPacienteAlergia ;
      private String AV33NPacienteAnestesiaOtro ;
      private String AV34NPacienteAnestesiaComplica ;
      private String AV38NPacienteOtros ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] NOTAPACIEN2_A359NPacienteAlcohol ;
      private short[] NOTAPACIEN2_A358NPacienteCigarros ;
      private short[] NOTAPACIEN2_A357NPacienteFuma ;
      private String[] NOTAPACIEN2_A356NPacienteAnestesiaComplica ;
      private String[] NOTAPACIEN2_A355NPacienteAnestesiaOtro ;
      private short[] NOTAPACIEN2_A354NPacienteAnestesiaRaquidea ;
      private short[] NOTAPACIEN2_A353NPacienteAnestesiaEpidural ;
      private short[] NOTAPACIEN2_A352NPacienteAnestesiaGeneral ;
      private short[] NOTAPACIEN2_A351NPacienteAborto ;
      private short[] NOTAPACIEN2_A350NPacienteCesarea ;
      private short[] NOTAPACIEN2_A349NPacienteParto ;
      private short[] NOTAPACIEN2_A348NPacienteGesta ;
      private String[] NOTAPACIEN2_A347NPacienteAlergia ;
      private String[] NOTAPACIEN2_A346NPacienteOperacion ;
      private String[] NOTAPACIEN2_A345NPacienteMedicamento ;
      private String[] NOTAPACIEN2_A344NPacienteEnfermedad ;
      private String[] NOTAPACIEN2_A343NPacienteCelular ;
      private String[] NOTAPACIEN2_A342NPacienteTelefono ;
      private String[] NOTAPACIEN2_A341NPacienteFacebook ;
      private String[] NOTAPACIEN2_A340NPacienteCorreo ;
      private String[] NOTAPACIEN2_A339NPacienteDireccion ;
      private int[] NOTAPACIEN2_A315ReligionId ;
      private int[] NOTAPACIEN2_A313ProfesionId ;
      private String[] NOTAPACIEN2_A338NPacientePesoEn ;
      private decimal[] NOTAPACIEN2_A337NPacientePeso ;
      private String[] NOTAPACIEN2_A336NPacienteEstaturaEn ;
      private decimal[] NOTAPACIEN2_A335NPacienteEstatura ;
      private String[] NOTAPACIEN2_A334NPacienteSexo ;
      private DateTime[] NOTAPACIEN2_A333NPacienteFechaNac ;
      private String[] NOTAPACIEN2_A332NPacienteApellido3 ;
      private String[] NOTAPACIEN2_A331NPacienteApellido2 ;
      private String[] NOTAPACIEN2_A330NPacienteApellido1 ;
      private String[] NOTAPACIEN2_A329NPacienteNombre2 ;
      private String[] NOTAPACIEN2_A328NPacienteNombre1 ;
      private int[] NOTAPACIEN2_A327NPacienteId ;
      private String[] NOTAPACIEN2_A41ClinicaCodigo ;
      private String[] NOTAPACIEN2_A360NPacienteOtros ;
   }

   public class notapacienteconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmNOTAPACIEN2 ;
          prmNOTAPACIEN2 = new Object[] {
          } ;
          Object[] prmNOTAPACIEN3 ;
          prmNOTAPACIEN3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV3NPacienteId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4NPacienteNombre1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV5NPacienteNombre2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV6NPacienteApellido1",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV7NPacienteApellido2",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV8NPacienteApellido3",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV9NPacienteFechaNac",SqlDbType.DateTime,8,0} ,
          new Object[] {"@AV10NPacienteSexo",SqlDbType.VarChar,1,0} ,
          new Object[] {"@AV11NPacienteEstatura",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV12NPacienteEstaturaEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV13NPacientePeso",SqlDbType.Decimal,17,2} ,
          new Object[] {"@AV14NPacientePesoEn",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV15ProfesionId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV16ReligionId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV17NPacienteDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV18NPacienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV19NPacienteFacebook",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV20NPacienteTelefono",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV21NPacienteCelular",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV22NPacienteEnfermedad",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV23NPacienteMedicamento",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV24NPacienteOperacion",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV25NPacienteAlergia",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV26NPacienteGesta",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV27NPacienteParto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV28NPacienteCesarea",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV29NPacienteAborto",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV30NPacienteAnestesiaGeneral",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV31NPacienteAnestesiaEpidural",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV32NPacienteAnestesiaRaquidea",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV33NPacienteAnestesiaOtro",SqlDbType.VarChar,30,0} ,
          new Object[] {"@AV34NPacienteAnestesiaComplica",SqlDbType.VarChar,600,0} ,
          new Object[] {"@AV35NPacienteFuma",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV36NPacienteCigarros",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV37NPacienteAlcohol",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV38NPacienteOtros",SqlDbType.VarChar,30,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("NOTAPACIEN2", "SELECT [NPacienteAlcohol], [NPacienteCigarros], [NPacienteFuma], [NPacienteAnestesiaComplica], [NPacienteAnestesiaOtro], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaGeneral], [NPacienteAborto], [NPacienteCesarea], [NPacienteParto], [NPacienteGesta], [NPacienteAlergia], [NPacienteOperacion], [NPacienteMedicamento], [NPacienteEnfermedad], [NPacienteCelular], [NPacienteTelefono], [NPacienteFacebook], [NPacienteCorreo], [NPacienteDireccion], [ReligionId], [ProfesionId], [NPacientePesoEn], [NPacientePeso], [NPacienteEstaturaEn], [NPacienteEstatura], [NPacienteSexo], [NPacienteFechaNac], [NPacienteApellido3], [NPacienteApellido2], [NPacienteApellido1], [NPacienteNombre2], [NPacienteNombre1], [NPacienteId], [ClinicaCodigo], [NPacienteOtros] FROM [NotaPaciente] ORDER BY [ClinicaCodigo], [NPacienteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmNOTAPACIEN2,100,0,true,false )
             ,new CursorDef("NOTAPACIEN3", "INSERT INTO [GXA0075] ([ClinicaCodigo], [NPacienteId], [NPacienteNombre1], [NPacienteNombre2], [NPacienteApellido1], [NPacienteApellido2], [NPacienteApellido3], [NPacienteFechaNac], [NPacienteSexo], [NPacienteEstatura], [NPacienteEstaturaEn], [NPacientePeso], [NPacientePesoEn], [ProfesionId], [ReligionId], [NPacienteDireccion], [NPacienteCorreo], [NPacienteFacebook], [NPacienteTelefono], [NPacienteCelular], [NPacienteEnfermedad], [NPacienteMedicamento], [NPacienteOperacion], [NPacienteAlergia], [NPacienteGesta], [NPacienteParto], [NPacienteCesarea], [NPacienteAborto], [NPacienteAnestesiaGeneral], [NPacienteAnestesiaEpidural], [NPacienteAnestesiaRaquidea], [NPacienteAnestesiaOtro], [NPacienteAnestesiaComplica], [NPacienteFuma], [NPacienteCigarros], [NPacienteAlcohol], [NPacienteOtros]) VALUES (@AV2ClinicaCodigo, @AV3NPacienteId, @AV4NPacienteNombre1, @AV5NPacienteNombre2, @AV6NPacienteApellido1, @AV7NPacienteApellido2, @AV8NPacienteApellido3, @AV9NPacienteFechaNac, @AV10NPacienteSexo, @AV11NPacienteEstatura, @AV12NPacienteEstaturaEn, @AV13NPacientePeso, @AV14NPacientePesoEn, @AV15ProfesionId, @AV16ReligionId, @AV17NPacienteDireccion, @AV18NPacienteCorreo, @AV19NPacienteFacebook, @AV20NPacienteTelefono, @AV21NPacienteCelular, @AV22NPacienteEnfermedad, @AV23NPacienteMedicamento, @AV24NPacienteOperacion, @AV25NPacienteAlergia, @AV26NPacienteGesta, @AV27NPacienteParto, @AV28NPacienteCesarea, @AV29NPacienteAborto, @AV30NPacienteAnestesiaGeneral, @AV31NPacienteAnestesiaEpidural, @AV32NPacienteAnestesiaRaquidea, @AV33NPacienteAnestesiaOtro, @AV34NPacienteAnestesiaComplica, @AV35NPacienteFuma, @AV36NPacienteCigarros, @AV37NPacienteAlcohol, @AV38NPacienteOtros)", GxErrorMask.GX_NOMASK,prmNOTAPACIEN3)
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((String[]) buf[12])[0] = rslt.getVarchar(13) ;
                ((String[]) buf[13])[0] = rslt.getVarchar(14) ;
                ((String[]) buf[14])[0] = rslt.getVarchar(15) ;
                ((String[]) buf[15])[0] = rslt.getVarchar(16) ;
                ((String[]) buf[16])[0] = rslt.getVarchar(17) ;
                ((String[]) buf[17])[0] = rslt.getVarchar(18) ;
                ((String[]) buf[18])[0] = rslt.getVarchar(19) ;
                ((String[]) buf[19])[0] = rslt.getVarchar(20) ;
                ((String[]) buf[20])[0] = rslt.getVarchar(21) ;
                ((int[]) buf[21])[0] = rslt.getInt(22) ;
                ((int[]) buf[22])[0] = rslt.getInt(23) ;
                ((String[]) buf[23])[0] = rslt.getVarchar(24) ;
                ((decimal[]) buf[24])[0] = rslt.getDecimal(25) ;
                ((String[]) buf[25])[0] = rslt.getVarchar(26) ;
                ((decimal[]) buf[26])[0] = rslt.getDecimal(27) ;
                ((String[]) buf[27])[0] = rslt.getVarchar(28) ;
                ((DateTime[]) buf[28])[0] = rslt.getGXDate(29) ;
                ((String[]) buf[29])[0] = rslt.getVarchar(30) ;
                ((String[]) buf[30])[0] = rslt.getVarchar(31) ;
                ((String[]) buf[31])[0] = rslt.getVarchar(32) ;
                ((String[]) buf[32])[0] = rslt.getVarchar(33) ;
                ((String[]) buf[33])[0] = rslt.getVarchar(34) ;
                ((int[]) buf[34])[0] = rslt.getInt(35) ;
                ((String[]) buf[35])[0] = rslt.getVarchar(36) ;
                ((String[]) buf[36])[0] = rslt.getVarchar(37) ;
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
                break;
       }
    }

 }

}
