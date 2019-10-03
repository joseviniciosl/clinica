/*
               File: BodegaConversion
        Description: Conversion for table Bodega
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.35
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
   public class bodegaconversion : GXProcedure
   {
      public bodegaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public bodegaconversion( IGxContext context )
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
         bodegaconversion objbodegaconversion;
         objbodegaconversion = new bodegaconversion();
         objbodegaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objbodegaconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((bodegaconversion)stateInfo).executePrivate();
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
         /* Using cursor BODEGACONV2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A123BodegaEstado = BODEGACONV2_A123BodegaEstado[0] ;
            A122BodegaDescripcion = BODEGACONV2_A122BodegaDescripcion[0] ;
            A121BodegaCodigo = BODEGACONV2_A121BodegaCodigo[0] ;
            A41ClinicaCodigo = BODEGACONV2_A41ClinicaCodigo[0] ;
            A40000GXC1 = BODEGACONV2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0030

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3BodegaCodigo = A121BodegaCodigo ;
            AV4BodegaDescripcion = A122BodegaDescripcion ;
            AV5BodegaEstado = A123BodegaEstado ;
            /* Using cursor BODEGACONV3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3BodegaCodigo, AV4BodegaDescripcion, AV5BodegaEstado});
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
         BODEGACONV2_A123BodegaEstado = new short[1] ;
         BODEGACONV2_A122BodegaDescripcion = new String[] {""} ;
         BODEGACONV2_A121BodegaCodigo = new String[] {""} ;
         BODEGACONV2_A41ClinicaCodigo = new String[] {""} ;
         BODEGACONV2_A40000GXC1 = new int[1] ;
         A122BodegaDescripcion = "" ;
         A121BodegaCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3BodegaCodigo = "" ;
         AV4BodegaDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.bodegaconversion__default(),
            new Object[][] {
                new Object[] {
               BODEGACONV2_A123BodegaEstado, BODEGACONV2_A122BodegaDescripcion, BODEGACONV2_A121BodegaCodigo, BODEGACONV2_A41ClinicaCodigo, BODEGACONV2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A123BodegaEstado ;
      private short AV5BodegaEstado ;
      private int A40000GXC1 ;
      private int GIGXA0030 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A122BodegaDescripcion ;
      private String A121BodegaCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3BodegaCodigo ;
      private String AV4BodegaDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BODEGACONV2_A123BodegaEstado ;
      private String[] BODEGACONV2_A122BodegaDescripcion ;
      private String[] BODEGACONV2_A121BodegaCodigo ;
      private String[] BODEGACONV2_A41ClinicaCodigo ;
      private int[] BODEGACONV2_A40000GXC1 ;
   }

   public class bodegaconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBODEGACONV2 ;
          prmBODEGACONV2 = new Object[] {
          } ;
          Object[] prmBODEGACONV3 ;
          prmBODEGACONV3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3BodegaCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4BodegaDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5BodegaEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BODEGACONV2", "SELECT [BodegaEstado], [BodegaDescripcion], [BodegaCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Bodega] ORDER BY [ClinicaCodigo], [BodegaCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmBODEGACONV2,100,0,true,false )
             ,new CursorDef("BODEGACONV3", "INSERT INTO [GXA0030] ([ClinicaCodigo], [BodegaCodigo], [BodegaDescripcion], [BodegaEstado]) VALUES (@AV2ClinicaCodigo, @AV3BodegaCodigo, @AV4BodegaDescripcion, @AV5BodegaEstado)", GxErrorMask.GX_NOMASK,prmBODEGACONV3)
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
