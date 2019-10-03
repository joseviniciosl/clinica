/*
               File: TipoMovInventarioDetConversion
        Description: Conversion for table TipoMovInventarioDet
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.50
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
   public class tipomovinventariodetconversion : GXProcedure
   {
      public tipomovinventariodetconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipomovinventariodetconversion( IGxContext context )
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
         tipomovinventariodetconversion objtipomovinventariodetconversion;
         objtipomovinventariodetconversion = new tipomovinventariodetconversion();
         objtipomovinventariodetconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipomovinventariodetconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipomovinventariodetconversion)stateInfo).executePrivate();
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
            A120TipoMICorrelativo = TIPOMOVINV2_A120TipoMICorrelativo[0] ;
            A119TipoMIAnio = TIPOMOVINV2_A119TipoMIAnio[0] ;
            A114TipoMICodigo = TIPOMOVINV2_A114TipoMICodigo[0] ;
            A41ClinicaCodigo = TIPOMOVINV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOMOVINV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0029

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoMICodigo = A114TipoMICodigo ;
            AV4TipoMIAnio = A119TipoMIAnio ;
            AV5TipoMICorrelativo = A120TipoMICorrelativo ;
            /* Using cursor TIPOMOVINV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoMICodigo, AV4TipoMIAnio, AV5TipoMICorrelativo});
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
         TIPOMOVINV2_A120TipoMICorrelativo = new int[1] ;
         TIPOMOVINV2_A119TipoMIAnio = new short[1] ;
         TIPOMOVINV2_A114TipoMICodigo = new String[] {""} ;
         TIPOMOVINV2_A41ClinicaCodigo = new String[] {""} ;
         TIPOMOVINV2_A40000GXC1 = new int[1] ;
         A114TipoMICodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoMICodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipomovinventariodetconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOMOVINV2_A120TipoMICorrelativo, TIPOMOVINV2_A119TipoMIAnio, TIPOMOVINV2_A114TipoMICodigo, TIPOMOVINV2_A41ClinicaCodigo, TIPOMOVINV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A119TipoMIAnio ;
      private short AV4TipoMIAnio ;
      private int A120TipoMICorrelativo ;
      private int A40000GXC1 ;
      private int GIGXA0029 ;
      private int AV2ClinicaCodigo ;
      private int AV5TipoMICorrelativo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A114TipoMICodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoMICodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] TIPOMOVINV2_A120TipoMICorrelativo ;
      private short[] TIPOMOVINV2_A119TipoMIAnio ;
      private String[] TIPOMOVINV2_A114TipoMICodigo ;
      private String[] TIPOMOVINV2_A41ClinicaCodigo ;
      private int[] TIPOMOVINV2_A40000GXC1 ;
   }

   public class tipomovinventariodetconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          new Object[] {"@AV4TipoMIAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5TipoMICorrelativo",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOMOVINV2", "SELECT [TipoMICorrelativo], [TipoMIAnio], [TipoMICodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoMovInventarioDet] ORDER BY [ClinicaCodigo], [TipoMICodigo], [TipoMIAnio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOMOVINV2,100,0,true,false )
             ,new CursorDef("TIPOMOVINV3", "INSERT INTO [GXA0029] ([ClinicaCodigo], [TipoMICodigo], [TipoMIAnio], [TipoMICorrelativo]) VALUES (@AV2ClinicaCodigo, @AV3TipoMICodigo, @AV4TipoMIAnio, @AV5TipoMICorrelativo)", GxErrorMask.GX_NOMASK,prmTIPOMOVINV3)
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
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
