/*
               File: TipoPacienteConversion
        Description: Conversion for table TipoPaciente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.65
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
   public class tipopacienteconversion : GXProcedure
   {
      public tipopacienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipopacienteconversion( IGxContext context )
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
         tipopacienteconversion objtipopacienteconversion;
         objtipopacienteconversion = new tipopacienteconversion();
         objtipopacienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipopacienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipopacienteconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOPACIEN2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A146TipoPacEstado = TIPOPACIEN2_A146TipoPacEstado[0] ;
            A145TipoPacDescripcion = TIPOPACIEN2_A145TipoPacDescripcion[0] ;
            A144TipoPacCodigo = TIPOPACIEN2_A144TipoPacCodigo[0] ;
            A41ClinicaCodigo = TIPOPACIEN2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOPACIEN2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0040

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoPacCodigo = A144TipoPacCodigo ;
            AV4TipoPacDescripcion = A145TipoPacDescripcion ;
            AV5TipoPacEstado = A146TipoPacEstado ;
            /* Using cursor TIPOPACIEN3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoPacCodigo, AV4TipoPacDescripcion, AV5TipoPacEstado});
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
         TIPOPACIEN2_A146TipoPacEstado = new short[1] ;
         TIPOPACIEN2_A145TipoPacDescripcion = new String[] {""} ;
         TIPOPACIEN2_A144TipoPacCodigo = new String[] {""} ;
         TIPOPACIEN2_A41ClinicaCodigo = new String[] {""} ;
         TIPOPACIEN2_A40000GXC1 = new int[1] ;
         A145TipoPacDescripcion = "" ;
         A144TipoPacCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoPacCodigo = "" ;
         AV4TipoPacDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipopacienteconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOPACIEN2_A146TipoPacEstado, TIPOPACIEN2_A145TipoPacDescripcion, TIPOPACIEN2_A144TipoPacCodigo, TIPOPACIEN2_A41ClinicaCodigo, TIPOPACIEN2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A146TipoPacEstado ;
      private short AV5TipoPacEstado ;
      private int A40000GXC1 ;
      private int GIGXA0040 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A145TipoPacDescripcion ;
      private String A144TipoPacCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoPacCodigo ;
      private String AV4TipoPacDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOPACIEN2_A146TipoPacEstado ;
      private String[] TIPOPACIEN2_A145TipoPacDescripcion ;
      private String[] TIPOPACIEN2_A144TipoPacCodigo ;
      private String[] TIPOPACIEN2_A41ClinicaCodigo ;
      private int[] TIPOPACIEN2_A40000GXC1 ;
   }

   public class tipopacienteconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOPACIEN2 ;
          prmTIPOPACIEN2 = new Object[] {
          } ;
          Object[] prmTIPOPACIEN3 ;
          prmTIPOPACIEN3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoPacCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoPacDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5TipoPacEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOPACIEN2", "SELECT [TipoPacEstado], [TipoPacDescripcion], [TipoPacCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoPaciente] ORDER BY [ClinicaCodigo], [TipoPacCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOPACIEN2,100,0,true,false )
             ,new CursorDef("TIPOPACIEN3", "INSERT INTO [GXA0040] ([ClinicaCodigo], [TipoPacCodigo], [TipoPacDescripcion], [TipoPacEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoPacCodigo, @AV4TipoPacDescripcion, @AV5TipoPacEstado)", GxErrorMask.GX_NOMASK,prmTIPOPACIEN3)
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((int[]) buf[4])[0] = rslt.getInt(5) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                break;
       }
    }

 }

}
