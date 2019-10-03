/*
               File: TipoMovInventarioConversion
        Description: Conversion for table TipoMovInventario
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.44
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
   public class tipomovinventarioconversion : GXProcedure
   {
      public tipomovinventarioconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipomovinventarioconversion( IGxContext context )
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
         tipomovinventarioconversion objtipomovinventarioconversion;
         objtipomovinventarioconversion = new tipomovinventarioconversion();
         objtipomovinventarioconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipomovinventarioconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipomovinventarioconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOMOVINV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A118TipoMIEstado = TIPOMOVINV2_A118TipoMIEstado[0] ;
            A117TipoMIAfectaCosto = TIPOMOVINV2_A117TipoMIAfectaCosto[0] ;
            A116TipoMIOperacion = TIPOMOVINV2_A116TipoMIOperacion[0] ;
            A115TipoMIDescripcion = TIPOMOVINV2_A115TipoMIDescripcion[0] ;
            A114TipoMICodigo = TIPOMOVINV2_A114TipoMICodigo[0] ;
            A41ClinicaCodigo = TIPOMOVINV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOMOVINV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0028

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoMICodigo = A114TipoMICodigo ;
            AV4TipoMIDescripcion = A115TipoMIDescripcion ;
            AV5TipoMIOperacion = A116TipoMIOperacion ;
            AV6TipoMIAfectaCosto = A117TipoMIAfectaCosto ;
            AV7TipoMIEstado = A118TipoMIEstado ;
            /* Using cursor TIPOMOVINV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoMICodigo, AV4TipoMIDescripcion, AV5TipoMIOperacion, AV6TipoMIAfectaCosto, AV7TipoMIEstado});
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
         TIPOMOVINV2_A118TipoMIEstado = new short[1] ;
         TIPOMOVINV2_A117TipoMIAfectaCosto = new short[1] ;
         TIPOMOVINV2_A116TipoMIOperacion = new short[1] ;
         TIPOMOVINV2_A115TipoMIDescripcion = new String[] {""} ;
         TIPOMOVINV2_A114TipoMICodigo = new String[] {""} ;
         TIPOMOVINV2_A41ClinicaCodigo = new String[] {""} ;
         TIPOMOVINV2_A40000GXC1 = new int[1] ;
         A115TipoMIDescripcion = "" ;
         A114TipoMICodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoMICodigo = "" ;
         AV4TipoMIDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipomovinventarioconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOMOVINV2_A118TipoMIEstado, TIPOMOVINV2_A117TipoMIAfectaCosto, TIPOMOVINV2_A116TipoMIOperacion, TIPOMOVINV2_A115TipoMIDescripcion, TIPOMOVINV2_A114TipoMICodigo, TIPOMOVINV2_A41ClinicaCodigo, TIPOMOVINV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A118TipoMIEstado ;
      private short A117TipoMIAfectaCosto ;
      private short A116TipoMIOperacion ;
      private short AV5TipoMIOperacion ;
      private short AV6TipoMIAfectaCosto ;
      private short AV7TipoMIEstado ;
      private int A40000GXC1 ;
      private int GIGXA0028 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A115TipoMIDescripcion ;
      private String A114TipoMICodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoMICodigo ;
      private String AV4TipoMIDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOMOVINV2_A118TipoMIEstado ;
      private short[] TIPOMOVINV2_A117TipoMIAfectaCosto ;
      private short[] TIPOMOVINV2_A116TipoMIOperacion ;
      private String[] TIPOMOVINV2_A115TipoMIDescripcion ;
      private String[] TIPOMOVINV2_A114TipoMICodigo ;
      private String[] TIPOMOVINV2_A41ClinicaCodigo ;
      private int[] TIPOMOVINV2_A40000GXC1 ;
   }

   public class tipomovinventarioconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOMOVINV2 ;
          prmTIPOMOVINV2 = new Object[] {
          } ;
          Object[] prmTIPOMOVINV3 ;
          prmTIPOMOVINV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoMICodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoMIDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5TipoMIOperacion",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV6TipoMIAfectaCosto",SqlDbType.SmallInt,1,0} ,
          new Object[] {"@AV7TipoMIEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOMOVINV2", "SELECT [TipoMIEstado], [TipoMIAfectaCosto], [TipoMIOperacion], [TipoMIDescripcion], [TipoMICodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoMovInventario] ORDER BY [ClinicaCodigo], [TipoMICodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOMOVINV2,100,0,true,false )
             ,new CursorDef("TIPOMOVINV3", "INSERT INTO [GXA0028] ([ClinicaCodigo], [TipoMICodigo], [TipoMIDescripcion], [TipoMIOperacion], [TipoMIAfectaCosto], [TipoMIEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoMICodigo, @AV4TipoMIDescripcion, @AV5TipoMIOperacion, @AV6TipoMIAfectaCosto, @AV7TipoMIEstado)", GxErrorMask.GX_NOMASK,prmTIPOMOVINV3)
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
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((int[]) buf[6])[0] = rslt.getInt(7) ;
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
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
       }
    }

 }

}
