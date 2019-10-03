/*
               File: ClienteConversion
        Description: Conversion for table Cliente
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.87
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
   public class clienteconversion : GXProcedure
   {
      public clienteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public clienteconversion( IGxContext context )
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
         clienteconversion objclienteconversion;
         objclienteconversion = new clienteconversion();
         objclienteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objclienteconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((clienteconversion)stateInfo).executePrivate();
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
         /* Using cursor CLIENTECON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A184ClienteEstado = CLIENTECON2_A184ClienteEstado[0] ;
            A138TipoCliCodigo = CLIENTECON2_A138TipoCliCodigo[0] ;
            A183ClienteCorreo = CLIENTECON2_A183ClienteCorreo[0] ;
            A182ClienteDireccion = CLIENTECON2_A182ClienteDireccion[0] ;
            A181ClienteTelefono2 = CLIENTECON2_A181ClienteTelefono2[0] ;
            A180ClienteTelefono1 = CLIENTECON2_A180ClienteTelefono1[0] ;
            A179ClienteNombre = CLIENTECON2_A179ClienteNombre[0] ;
            A178ClienteCodigo = CLIENTECON2_A178ClienteCodigo[0] ;
            A41ClinicaCodigo = CLIENTECON2_A41ClinicaCodigo[0] ;
            A40000GXC1 = CLIENTECON2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0048

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3ClienteCodigo = A178ClienteCodigo ;
            AV4ClienteNombre = A179ClienteNombre ;
            AV5ClienteTelefono1 = A180ClienteTelefono1 ;
            AV6ClienteTelefono2 = A181ClienteTelefono2 ;
            AV7ClienteDireccion = A182ClienteDireccion ;
            AV8ClienteCorreo = A183ClienteCorreo ;
            AV9TipoCliCodigo = A138TipoCliCodigo ;
            AV10ClienteEstado = A184ClienteEstado ;
            /* Using cursor CLIENTECON3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3ClienteCodigo, AV4ClienteNombre, AV5ClienteTelefono1, AV6ClienteTelefono2, AV7ClienteDireccion, AV8ClienteCorreo, AV9TipoCliCodigo, AV10ClienteEstado});
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
         CLIENTECON2_A184ClienteEstado = new short[1] ;
         CLIENTECON2_A138TipoCliCodigo = new String[] {""} ;
         CLIENTECON2_A183ClienteCorreo = new String[] {""} ;
         CLIENTECON2_A182ClienteDireccion = new String[] {""} ;
         CLIENTECON2_A181ClienteTelefono2 = new String[] {""} ;
         CLIENTECON2_A180ClienteTelefono1 = new String[] {""} ;
         CLIENTECON2_A179ClienteNombre = new String[] {""} ;
         CLIENTECON2_A178ClienteCodigo = new String[] {""} ;
         CLIENTECON2_A41ClinicaCodigo = new String[] {""} ;
         CLIENTECON2_A40000GXC1 = new int[1] ;
         A138TipoCliCodigo = "" ;
         A183ClienteCorreo = "" ;
         A182ClienteDireccion = "" ;
         A181ClienteTelefono2 = "" ;
         A180ClienteTelefono1 = "" ;
         A179ClienteNombre = "" ;
         A178ClienteCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3ClienteCodigo = "" ;
         AV4ClienteNombre = "" ;
         AV5ClienteTelefono1 = "" ;
         AV6ClienteTelefono2 = "" ;
         AV7ClienteDireccion = "" ;
         AV8ClienteCorreo = "" ;
         AV9TipoCliCodigo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clienteconversion__default(),
            new Object[][] {
                new Object[] {
               CLIENTECON2_A184ClienteEstado, CLIENTECON2_A138TipoCliCodigo, CLIENTECON2_A183ClienteCorreo, CLIENTECON2_A182ClienteDireccion, CLIENTECON2_A181ClienteTelefono2, CLIENTECON2_A180ClienteTelefono1, CLIENTECON2_A179ClienteNombre, CLIENTECON2_A178ClienteCodigo, CLIENTECON2_A41ClinicaCodigo, CLIENTECON2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A184ClienteEstado ;
      private short AV10ClienteEstado ;
      private int A40000GXC1 ;
      private int GIGXA0048 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A138TipoCliCodigo ;
      private String A183ClienteCorreo ;
      private String A182ClienteDireccion ;
      private String A181ClienteTelefono2 ;
      private String A180ClienteTelefono1 ;
      private String A179ClienteNombre ;
      private String A178ClienteCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3ClienteCodigo ;
      private String AV4ClienteNombre ;
      private String AV5ClienteTelefono1 ;
      private String AV6ClienteTelefono2 ;
      private String AV7ClienteDireccion ;
      private String AV8ClienteCorreo ;
      private String AV9TipoCliCodigo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CLIENTECON2_A184ClienteEstado ;
      private String[] CLIENTECON2_A138TipoCliCodigo ;
      private String[] CLIENTECON2_A183ClienteCorreo ;
      private String[] CLIENTECON2_A182ClienteDireccion ;
      private String[] CLIENTECON2_A181ClienteTelefono2 ;
      private String[] CLIENTECON2_A180ClienteTelefono1 ;
      private String[] CLIENTECON2_A179ClienteNombre ;
      private String[] CLIENTECON2_A178ClienteCodigo ;
      private String[] CLIENTECON2_A41ClinicaCodigo ;
      private int[] CLIENTECON2_A40000GXC1 ;
   }

   public class clienteconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCLIENTECON2 ;
          prmCLIENTECON2 = new Object[] {
          } ;
          Object[] prmCLIENTECON3 ;
          prmCLIENTECON3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3ClienteCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4ClienteNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5ClienteTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV6ClienteTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV7ClienteDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV8ClienteCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV9TipoCliCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV10ClienteEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CLIENTECON2", "SELECT [ClienteEstado], [TipoCliCodigo], [ClienteCorreo], [ClienteDireccion], [ClienteTelefono2], [ClienteTelefono1], [ClienteNombre], [ClienteCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Cliente] ORDER BY [ClinicaCodigo], [ClienteCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCLIENTECON2,100,0,true,false )
             ,new CursorDef("CLIENTECON3", "INSERT INTO [GXA0048] ([ClinicaCodigo], [ClienteCodigo], [ClienteNombre], [ClienteTelefono1], [ClienteTelefono2], [ClienteDireccion], [ClienteCorreo], [TipoCliCodigo], [ClienteEstado]) VALUES (@AV2ClinicaCodigo, @AV3ClienteCodigo, @AV4ClienteNombre, @AV5ClienteTelefono1, @AV6ClienteTelefono2, @AV7ClienteDireccion, @AV8ClienteCorreo, @AV9TipoCliCodigo, @AV10ClienteEstado)", GxErrorMask.GX_NOMASK,prmCLIENTECON3)
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
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((String[]) buf[7])[0] = rslt.getVarchar(8) ;
                ((String[]) buf[8])[0] = rslt.getVarchar(9) ;
                ((int[]) buf[9])[0] = rslt.getInt(10) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                break;
       }
    }

 }

}
