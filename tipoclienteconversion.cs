/*
               File: TipoClienteConversion
        Description: Conversion for table TipoCliente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:26.37
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
   public class tipoclienteconversion : GXProcedure
   {
      public tipoclienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public tipoclienteconversion( IGxContext context )
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
         tipoclienteconversion objtipoclienteconversion;
         objtipoclienteconversion = new tipoclienteconversion();
         objtipoclienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objtipoclienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((tipoclienteconversion)stateInfo).executePrivate();
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
         /* Using cursor TIPOCLIENT2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A140TipoCliEstado = TIPOCLIENT2_A140TipoCliEstado[0] ;
            A139TipoCliDescripcion = TIPOCLIENT2_A139TipoCliDescripcion[0] ;
            A138TipoCliCodigo = TIPOCLIENT2_A138TipoCliCodigo[0] ;
            A41ClinicaCodigo = TIPOCLIENT2_A41ClinicaCodigo[0] ;
            A40000GXC1 = TIPOCLIENT2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0038

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3TipoCliCodigo = A138TipoCliCodigo ;
            AV4TipoCliDescripcion = A139TipoCliDescripcion ;
            AV5TipoCliEstado = A140TipoCliEstado ;
            /* Using cursor TIPOCLIENT3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3TipoCliCodigo, AV4TipoCliDescripcion, AV5TipoCliEstado});
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
         TIPOCLIENT2_A140TipoCliEstado = new short[1] ;
         TIPOCLIENT2_A139TipoCliDescripcion = new String[] {""} ;
         TIPOCLIENT2_A138TipoCliCodigo = new String[] {""} ;
         TIPOCLIENT2_A41ClinicaCodigo = new String[] {""} ;
         TIPOCLIENT2_A40000GXC1 = new int[1] ;
         A139TipoCliDescripcion = "" ;
         A138TipoCliCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3TipoCliCodigo = "" ;
         AV4TipoCliDescripcion = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.tipoclienteconversion__default(),
            new Object[][] {
                new Object[] {
               TIPOCLIENT2_A140TipoCliEstado, TIPOCLIENT2_A139TipoCliDescripcion, TIPOCLIENT2_A138TipoCliCodigo, TIPOCLIENT2_A41ClinicaCodigo, TIPOCLIENT2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A140TipoCliEstado ;
      private short AV5TipoCliEstado ;
      private int A40000GXC1 ;
      private int GIGXA0038 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A139TipoCliDescripcion ;
      private String A138TipoCliCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3TipoCliCodigo ;
      private String AV4TipoCliDescripcion ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] TIPOCLIENT2_A140TipoCliEstado ;
      private String[] TIPOCLIENT2_A139TipoCliDescripcion ;
      private String[] TIPOCLIENT2_A138TipoCliCodigo ;
      private String[] TIPOCLIENT2_A41ClinicaCodigo ;
      private int[] TIPOCLIENT2_A40000GXC1 ;
   }

   public class tipoclienteconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmTIPOCLIENT2 ;
          prmTIPOCLIENT2 = new Object[] {
          } ;
          Object[] prmTIPOCLIENT3 ;
          prmTIPOCLIENT3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3TipoCliCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4TipoCliDescripcion",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5TipoCliEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("TIPOCLIENT2", "SELECT [TipoCliEstado], [TipoCliDescripcion], [TipoCliCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [TipoCliente] ORDER BY [ClinicaCodigo], [TipoCliCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmTIPOCLIENT2,100,0,true,false )
             ,new CursorDef("TIPOCLIENT3", "INSERT INTO [GXA0038] ([ClinicaCodigo], [TipoCliCodigo], [TipoCliDescripcion], [TipoCliEstado]) VALUES (@AV2ClinicaCodigo, @AV3TipoCliCodigo, @AV4TipoCliDescripcion, @AV5TipoCliEstado)", GxErrorMask.GX_NOMASK,prmTIPOCLIENT3)
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
