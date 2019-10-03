/*
               File: CajaConversion
        Description: Conversion for table Caja
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.42
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
   public class cajaconversion : GXProcedure
   {
      public cajaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cajaconversion( IGxContext context )
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
         cajaconversion objcajaconversion;
         objcajaconversion = new cajaconversion();
         objcajaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objcajaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((cajaconversion)stateInfo).executePrivate();
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
         /* Using cursor CAJACONVER2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A134CajaEstado = CAJACONVER2_A134CajaEstado[0] ;
            A133CajaDescripcion = CAJACONVER2_A133CajaDescripcion[0] ;
            A132CajaCodigo = CAJACONVER2_A132CajaCodigo[0] ;
            A41ClinicaCodigo = CAJACONVER2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CAJACONVER2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0036

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3CajaCodigo = A132CajaCodigo ;
            AV4CajaDescripcion = A133CajaDescripcion ;
            AV5CajaEstado = A134CajaEstado ;
            /* Using cursor CAJACONVER3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3CajaCodigo, AV4CajaDescripcion, AV5CajaEstado});
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
         CAJACONVER2_A134CajaEstado = new short[1] ;
         CAJACONVER2_A133CajaDescripcion = new String[] {""} ;
         CAJACONVER2_A132CajaCodigo = new String[] {""} ;
         CAJACONVER2_A41ClinicaCodigo = new String[] {""} ;
         CAJACONVER2_A40000GXC1 = new int[1] ;
         A133CajaDescripcion = "" ;
         A132CajaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3CajaCodigo = "" ;
         AV4CajaDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cajaconversion__default(),
            new Object[][] {
                new Object[] {
               CAJACONVER2_A134CajaEstado, CAJACONVER2_A133CajaDescripcion, CAJACONVER2_A132CajaCodigo, CAJACONVER2_A41ClinicaCodigo, CAJACONVER2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A134CajaEstado ;
      private short AV5CajaEstado ;
      private int A40000GXC1 ;
      private int GIGXA0036 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A133CajaDescripcion ;
      private String A132CajaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3CajaCodigo ;
      private String AV4CajaDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CAJACONVER2_A134CajaEstado ;
      private String[] CAJACONVER2_A133CajaDescripcion ;
      private String[] CAJACONVER2_A132CajaCodigo ;
      private String[] CAJACONVER2_A41ClinicaCodigo ;
      private int[] CAJACONVER2_A40000GXC1 ;
   }

   public class cajaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCAJACONVER2 ;
          prmCAJACONVER2 = new Object[] {
          } ;
          Object[] prmCAJACONVER3 ;
          prmCAJACONVER3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3CajaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4CajaDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5CajaEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CAJACONVER2", "SELECT [CajaEstado], [CajaDescripcion], [CajaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Caja] ORDER BY [ClinicaCodigo], [CajaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCAJACONVER2,100,0,true,false )
             ,new CursorDef("CAJACONVER3", "INSERT INTO [GXA0036] ([ClinicaCodigo], [CajaCodigo], [CajaDescripcion], [CajaEstado]) VALUES (@AV2ClinicaCodigo, @AV3CajaCodigo, @AV4CajaDescripcion, @AV5CajaEstado)", GxErrorMask.GX_NOMASK,prmCAJACONVER3)
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
