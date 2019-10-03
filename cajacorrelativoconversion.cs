/*
               File: CajaCorrelativoConversion
        Description: Conversion for table CajaCorrelativo
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.49
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
   public class cajacorrelativoconversion : GXProcedure
   {
      public cajacorrelativoconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cajacorrelativoconversion( IGxContext context )
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
         cajacorrelativoconversion objcajacorrelativoconversion;
         objcajacorrelativoconversion = new cajacorrelativoconversion();
         objcajacorrelativoconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcajacorrelativoconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cajacorrelativoconversion)stateInfo).executePrivate();
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
         /* Using cursor CAJACORREL2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A136CajaSiguiente = CAJACORREL2_A136CajaSiguiente[0] ;
            A135CajaAnio = CAJACORREL2_A135CajaAnio[0] ;
            A132CajaCodigo = CAJACORREL2_A132CajaCodigo[0] ;
            A41ClinicaCodigo = CAJACORREL2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CAJACORREL2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0037

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CajaCodigo = A132CajaCodigo ;
            AV4CajaAnio = A135CajaAnio ;
            AV5CajaSiguiente = A136CajaSiguiente ;
            /* Using cursor CAJACORREL3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CajaCodigo, AV4CajaAnio, AV5CajaSiguiente});
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
         CAJACORREL2_A136CajaSiguiente = new int[1] ;
         CAJACORREL2_A135CajaAnio = new short[1] ;
         CAJACORREL2_A132CajaCodigo = new String[] {""} ;
         CAJACORREL2_A41ClinicaCodigo = new String[] {""} ;
         CAJACORREL2_A40000GXC1 = new int[1] ;
         A132CajaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CajaCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cajacorrelativoconversion__default(),
            new Object[][] {
                new Object[] {
               CAJACORREL2_A136CajaSiguiente, CAJACORREL2_A135CajaAnio, CAJACORREL2_A132CajaCodigo, CAJACORREL2_A41ClinicaCodigo, CAJACORREL2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A135CajaAnio ;
      private short AV4CajaAnio ;
      private int A136CajaSiguiente ;
      private int A40000GXC1 ;
      private int GIGXA0037 ;
      private int AV2ClinicaCodigo ;
      private int AV5CajaSiguiente ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A132CajaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CajaCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private int[] CAJACORREL2_A136CajaSiguiente ;
      private short[] CAJACORREL2_A135CajaAnio ;
      private String[] CAJACORREL2_A132CajaCodigo ;
      private String[] CAJACORREL2_A41ClinicaCodigo ;
      private int[] CAJACORREL2_A40000GXC1 ;
   }

   public class cajacorrelativoconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCAJACORREL2 ;
          prmCAJACORREL2 = new Object[] {
          } ;
          Object[] prmCAJACORREL3 ;
          prmCAJACORREL3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CajaAnio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV5CajaSiguiente",SqlDbType.Int,9,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CAJACORREL2", "SELECT [CajaSiguiente], [CajaAnio], [CajaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [CajaCorrelativo] ORDER BY [ClinicaCodigo], [CajaCodigo], [CajaAnio] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCAJACORREL2,100,0,true,false )
             ,new CursorDef("CAJACORREL3", "INSERT INTO [GXA0037] ([ClinicaCodigo], [CajaCodigo], [CajaAnio], [CajaSiguiente]) VALUES (@AV2ClinicaCodigo, @AV3CajaCodigo, @AV4CajaAnio, @AV5CajaSiguiente)", GxErrorMask.GX_NOMASK,prmCAJACORREL3)
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
