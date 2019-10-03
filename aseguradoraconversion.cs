/*
               File: AseguradoraConversion
        Description: Conversion for table Aseguradora
             Author: GeneXus C# Generator version 10_1_8-58720
       Generated on: 4/1/2019 14:43:23.18
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
   public class aseguradoraconversion : GXProcedure
   {
      public aseguradoraconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public aseguradoraconversion( IGxContext context )
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
         aseguradoraconversion objaseguradoraconversion;
         objaseguradoraconversion = new aseguradoraconversion();
         objaseguradoraconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( executePrivateCatch ),objaseguradoraconversion);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((aseguradoraconversion)stateInfo).executePrivate();
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
         /* Using cursor ASEGURADOR2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A90AsegEstado = ASEGURADOR2_A90AsegEstado[0] ;
            A88AsegContacto = ASEGURADOR2_A88AsegContacto[0] ;
            A87AsegNit = ASEGURADOR2_A87AsegNit[0] ;
            A89AsegCorreo = ASEGURADOR2_A89AsegCorreo[0] ;
            A86AsegTelefono2 = ASEGURADOR2_A86AsegTelefono2[0] ;
            A85AsegTelefono1 = ASEGURADOR2_A85AsegTelefono1[0] ;
            A84AsegDireccion = ASEGURADOR2_A84AsegDireccion[0] ;
            A83AsegNombre = ASEGURADOR2_A83AsegNombre[0] ;
            A82AsegCodigo = ASEGURADOR2_A82AsegCodigo[0] ;
            A41ClinicaCodigo = ASEGURADOR2_A41ClinicaCodigo[0] ;
            A40000GXC1 = ASEGURADOR2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0033

            */
            AV2ClinicaCodigo = A40000GXC1 ;
            AV3AsegCodigo = A82AsegCodigo ;
            AV4AsegNombre = A83AsegNombre ;
            AV5AsegDireccion = A84AsegDireccion ;
            AV6AsegTelefono1 = A85AsegTelefono1 ;
            AV7AsegTelefono2 = A86AsegTelefono2 ;
            AV8AsegCorreo = A89AsegCorreo ;
            AV9AsegNit = A87AsegNit ;
            AV10AsegContacto = A88AsegContacto ;
            AV11AsegEstado = A90AsegEstado ;
            /* Using cursor ASEGURADOR3 */
            pr_default.execute(1, new Object[] {AV2ClinicaCodigo, AV3AsegCodigo, AV4AsegNombre, AV5AsegDireccion, AV6AsegTelefono1, AV7AsegTelefono2, AV8AsegCorreo, AV9AsegNit, AV10AsegContacto, AV11AsegEstado});
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
         ASEGURADOR2_A90AsegEstado = new short[1] ;
         ASEGURADOR2_A88AsegContacto = new String[] {""} ;
         ASEGURADOR2_A87AsegNit = new String[] {""} ;
         ASEGURADOR2_A89AsegCorreo = new String[] {""} ;
         ASEGURADOR2_A86AsegTelefono2 = new String[] {""} ;
         ASEGURADOR2_A85AsegTelefono1 = new String[] {""} ;
         ASEGURADOR2_A84AsegDireccion = new String[] {""} ;
         ASEGURADOR2_A83AsegNombre = new String[] {""} ;
         ASEGURADOR2_A82AsegCodigo = new String[] {""} ;
         ASEGURADOR2_A41ClinicaCodigo = new String[] {""} ;
         ASEGURADOR2_A40000GXC1 = new int[1] ;
         A88AsegContacto = "" ;
         A87AsegNit = "" ;
         A89AsegCorreo = "" ;
         A86AsegTelefono2 = "" ;
         A85AsegTelefono1 = "" ;
         A84AsegDireccion = "" ;
         A83AsegNombre = "" ;
         A82AsegCodigo = "" ;
         A41ClinicaCodigo = "" ;
         AV3AsegCodigo = "" ;
         AV4AsegNombre = "" ;
         AV5AsegDireccion = "" ;
         AV6AsegTelefono1 = "" ;
         AV7AsegTelefono2 = "" ;
         AV8AsegCorreo = "" ;
         AV9AsegNit = "" ;
         AV10AsegContacto = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.aseguradoraconversion__default(),
            new Object[][] {
                new Object[] {
               ASEGURADOR2_A90AsegEstado, ASEGURADOR2_A88AsegContacto, ASEGURADOR2_A87AsegNit, ASEGURADOR2_A89AsegCorreo, ASEGURADOR2_A86AsegTelefono2, ASEGURADOR2_A85AsegTelefono1, ASEGURADOR2_A84AsegDireccion, ASEGURADOR2_A83AsegNombre, ASEGURADOR2_A82AsegCodigo, ASEGURADOR2_A41ClinicaCodigo,
               ASEGURADOR2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A90AsegEstado ;
      private short AV11AsegEstado ;
      private int A40000GXC1 ;
      private int GIGXA0033 ;
      private int AV2ClinicaCodigo ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A88AsegContacto ;
      private String A87AsegNit ;
      private String A89AsegCorreo ;
      private String A86AsegTelefono2 ;
      private String A85AsegTelefono1 ;
      private String A84AsegDireccion ;
      private String A83AsegNombre ;
      private String A82AsegCodigo ;
      private String A41ClinicaCodigo ;
      private String AV3AsegCodigo ;
      private String AV4AsegNombre ;
      private String AV5AsegDireccion ;
      private String AV6AsegTelefono1 ;
      private String AV7AsegTelefono2 ;
      private String AV8AsegCorreo ;
      private String AV9AsegNit ;
      private String AV10AsegContacto ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] ASEGURADOR2_A90AsegEstado ;
      private String[] ASEGURADOR2_A88AsegContacto ;
      private String[] ASEGURADOR2_A87AsegNit ;
      private String[] ASEGURADOR2_A89AsegCorreo ;
      private String[] ASEGURADOR2_A86AsegTelefono2 ;
      private String[] ASEGURADOR2_A85AsegTelefono1 ;
      private String[] ASEGURADOR2_A84AsegDireccion ;
      private String[] ASEGURADOR2_A83AsegNombre ;
      private String[] ASEGURADOR2_A82AsegCodigo ;
      private String[] ASEGURADOR2_A41ClinicaCodigo ;
      private int[] ASEGURADOR2_A40000GXC1 ;
   }

   public class aseguradoraconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmASEGURADOR2 ;
          prmASEGURADOR2 = new Object[] {
          } ;
          Object[] prmASEGURADOR3 ;
          prmASEGURADOR3 = new Object[] {
          new Object[] {"@AV2ClinicaCodigo",SqlDbType.Int,9,0} ,
          new Object[] {"@AV3AsegCodigo",SqlDbType.VarChar,10,0} ,
          new Object[] {"@AV4AsegNombre",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV5AsegDireccion",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV6AsegTelefono1",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV7AsegTelefono2",SqlDbType.VarChar,9,0} ,
          new Object[] {"@AV8AsegCorreo",SqlDbType.VarChar,80,0} ,
          new Object[] {"@AV9AsegNit",SqlDbType.VarChar,20,0} ,
          new Object[] {"@AV10AsegContacto",SqlDbType.VarChar,50,0} ,
          new Object[] {"@AV11AsegEstado",SqlDbType.SmallInt,1,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("ASEGURADOR2", "SELECT [AsegEstado], [AsegContacto], [AsegNit], [AsegCorreo], [AsegTelefono2], [AsegTelefono1], [AsegDireccion], [AsegNombre], [AsegCodigo], [ClinicaCodigo], CASE  WHEN ISNUMERIC([ClinicaCodigo])=0 THEN 0 ELSE CONVERT( DECIMAL(28,14), [ClinicaCodigo]) END AS GXC1 FROM [Aseguradora] ORDER BY [ClinicaCodigo], [AsegCodigo] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmASEGURADOR2,100,0,true,false )
             ,new CursorDef("ASEGURADOR3", "INSERT INTO [GXA0033] ([ClinicaCodigo], [AsegCodigo], [AsegNombre], [AsegDireccion], [AsegTelefono1], [AsegTelefono2], [AsegCorreo], [AsegNit], [AsegContacto], [AsegEstado]) VALUES (@AV2ClinicaCodigo, @AV3AsegCodigo, @AV4AsegNombre, @AV5AsegDireccion, @AV6AsegTelefono1, @AV7AsegTelefono2, @AV8AsegCorreo, @AV9AsegNit, @AV10AsegContacto, @AV11AsegEstado)", GxErrorMask.GX_NOMASK,prmASEGURADOR3)
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
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((int[]) buf[10])[0] = rslt.getInt(11) ;
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
                stmt.SetParameter(9, (String)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                break;
       }
    }

 }

}
