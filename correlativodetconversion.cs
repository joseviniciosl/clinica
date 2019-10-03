/*
               File: CorrelativoDetConversion
        Description: Conversion for table CorrelativoDet
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:24.48
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
   public class correlativodetconversion : GXProcedure
   {
      public correlativodetconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public correlativodetconversion( IGxContext context )
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
         correlativodetconversion objcorrelativodetconversion;
         objcorrelativodetconversion = new correlativodetconversion();
         objcorrelativodetconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcorrelativodetconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((correlativodetconversion)stateInfo).executePrivate();
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
         /* Using cursor CORRELATIV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A64CorrelativoSiguiente = CORRELATIV2_A64CorrelativoSiguiente[0] ;
            A63CorrelativoAnio = CORRELATIV2_A63CorrelativoAnio[0] ;
            A61CorrelativoId = CORRELATIV2_A61CorrelativoId[0] ;
            A41ClinicaCodigo = CORRELATIV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CORRELATIV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0021

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CorrelativoId = A61CorrelativoId ;
            AV4CorrelativoAnio = A63CorrelativoAnio ;
            AV5CorrelativoSiguiente = A64CorrelativoSiguiente ;
            /* Using cursor CORRELATIV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CorrelativoId, AV4CorrelativoAnio, AV5CorrelativoSiguiente});
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
         CORRELATIV2_A64CorrelativoSiguiente = new int[1] ;
         CORRELATIV2_A63CorrelativoAnio = new short[1] ;
         CORRELATIV2_A61CorrelativoId = new int[1] ;
         CORRELATIV2_A41ClinicaCodigo = new String[] {""} ;
         CORRELATIV2_A40000GXC1 = new int[1] ;
         A41ClinicaCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.correlativodetconversion__default(),
            new Object[][] {
                new Object[] {
               CORRELATIV2_A64CorrelativoSiguiente, CORRELATIV2_A63CorrelativoAnio, CORRELATIV2_A61CorrelativoId, CORRELATIV2_A41ClinicaCodigo, CORRELATIV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A63CorrelativoAnio ;
      private short AV4CorrelativoAnio ;
      private int A64CorrelativoSiguiente ;
      private int A61CorrelativoId ;
      private int A40000GXC1 ;
      private int GIGXA0021 ;
      private int AV2ClinicaCodigo ;
      private int AV3CorrelativoId ;
      private int AV5CorrelativoSiguiente ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A41ClinicaCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] CORRELATIV2_A64CorrelativoSiguiente ;
      private short[] CORRELATIV2_A63CorrelativoAnio ;
      private int[] CORRELATIV2_A61CorrelativoId ;
      private String[] CORRELATIV2_A41ClinicaCodigo ;
      private int[] CORRELATIV2_A40000GXC1 ;
   }

   public class correlativodetconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCORRELATIV2 ;
          prmCORRELATIV2 = new Object[] {
          } ;
          Object[] prmCORRELATIV3 ;
          prmCORRELATIV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CorrelativoId",SqlDbType.Int,9,0} ,
          new Object[] {"@AV4CorrelativoAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5CorrelativoSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CORRELATIV2", "SELECT [CorrelativoSiguiente], [CorrelativoAnio], [CorrelativoId], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CorrelativoDet] ORDER BY [ClinicaCodigo], [CorrelativoId], [CorrelativoAnio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCORRELATIV2,100,0,true,false )
             ,new CursorDef("CORRELATIV3", "INSERT INTO [GXA0021] ([ClinicaCodigo], [CorrelativoId], [CorrelativoAnio], [CorrelativoSiguiente]) VALUES (@AV2ClinicaCodigo, @AV3CorrelativoId, @AV4CorrelativoAnio, @AV5CorrelativoSiguiente)", GxErrorMask.GX_NOMASK,prmCORRELATIV3)
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
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
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
                stmt.SetParameter(2, (int)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (int)parms[3]);
                break;
       }
    }

 }

}
