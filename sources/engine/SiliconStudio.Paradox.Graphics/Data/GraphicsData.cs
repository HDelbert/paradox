// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Paradox Data Code Generator.
// To generate it yourself, please install SiliconStudio.Paradox.VisualStudio.Package .vsix
// and re-save the associated .pdxdata.
// </auto-generated>

namespace SiliconStudio.Paradox.Graphics.Data
{
    /// <summary>
    /// Module initializer for data types of assembly SiliconStudio.Paradox.Graphics.
    /// </summary>
    class DataInitializer
    {
        [SiliconStudio.Core.ModuleInitializer]
        internal static void Initialize()
        {
            // Register type ImageFragmentData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.ImageFragmentDataConverter());
            // Register type SpriteData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.SpriteDataConverter());
            // Register type SpriteGroupData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.SpriteGroupDataConverter());
            // Register type BufferData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.BufferDataConverter());
            // Register type IndexBufferBindingData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.IndexBufferBindingDataConverter());
            // Register type VertexBufferBindingData
            SiliconStudio.Core.Serialization.Converters.ConverterContext.RegisterConverter(new SiliconStudio.Paradox.Graphics.Data.VertexBufferBindingDataConverter());
        }
    }
}

namespace SiliconStudio.Paradox.Graphics.Data
{
    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("ImageFragmentData")]
    public partial class ImageFragmentData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.Name"/>.
        /// </summary>
        public System.String Name;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.Texture"/>.
        /// </summary>
        public SiliconStudio.Core.Serialization.ContentReference<SiliconStudio.Paradox.Graphics.Texture2D> Texture;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.TextureAlpha"/>.
        /// </summary>
        public SiliconStudio.Core.Serialization.ContentReference<SiliconStudio.Paradox.Graphics.Texture2D> TextureAlpha;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.Region"/>.
        /// </summary>
        public SiliconStudio.Core.Mathematics.RectangleF Region;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.IsTransparent"/>.
        /// </summary>
        public System.Boolean IsTransparent;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment.Orientation"/>.
        /// </summary>
        public SiliconStudio.Paradox.Graphics.ImageOrientation Orientation;
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.Sprite"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("SpriteData")]
    public partial class SpriteData : SiliconStudio.Paradox.Graphics.Data.ImageFragmentData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.Sprite.Center"/>.
        /// </summary>
        public SiliconStudio.Core.Mathematics.Vector2 Center;
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.SpriteGroup"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("SpriteGroupData")]
    [SiliconStudio.Core.Serialization.Contents.ContentSerializer(typeof(SiliconStudio.Core.Serialization.Contents.DataContentSerializer<SpriteGroupData>))]
    [SiliconStudio.Core.Serialization.Contents.ContentSerializer(typeof(SiliconStudio.Core.Serialization.Converters.DataContentConverterSerializer<SiliconStudio.Paradox.Graphics.SpriteGroup>))]
    public partial class SpriteGroupData
    {
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.Buffer"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("BufferData")]
    [SiliconStudio.Core.Serialization.Contents.ContentSerializer(typeof(SiliconStudio.Core.Serialization.Contents.DataContentSerializer<BufferData>))]
    [SiliconStudio.Core.Serialization.Contents.ContentSerializer(typeof(SiliconStudio.Core.Serialization.Converters.DataContentConverterSerializer<SiliconStudio.Paradox.Graphics.Buffer>))]
    public partial class BufferData
    {
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("IndexBufferBindingData")]
    public partial class IndexBufferBindingData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding.Buffer"/>.
        /// </summary>
        public SiliconStudio.Core.Serialization.ContentReference<SiliconStudio.Paradox.Graphics.Data.BufferData> Buffer;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding.Is32Bit"/>.
        /// </summary>
        public System.Boolean Is32Bit;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding.Offset"/>.
        /// </summary>
        public System.Int32 Offset;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding.Count"/>.
        /// </summary>
        public System.Int32 Count;
    }

    /// <summary>
    /// Data type for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding"/>.
    /// </summary>
    [SiliconStudio.Core.DataContract("VertexBufferBindingData")]
    public partial class VertexBufferBindingData
    {
        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding.Buffer"/>.
        /// </summary>
        public SiliconStudio.Core.Serialization.ContentReference<SiliconStudio.Paradox.Graphics.Data.BufferData> Buffer;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding.Offset"/>.
        /// </summary>
        public System.Int32 Offset;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding.Stride"/>.
        /// </summary>
        public System.Int32 Stride;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding.Count"/>.
        /// </summary>
        public System.Int32 Count;

        /// <summary>
        /// Data field for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding.Declaration"/>.
        /// </summary>
        public SiliconStudio.Paradox.Graphics.VertexDeclaration Declaration;
    }



    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Graphics.ImageFragment"/>.
    /// </summary>
    public partial class ImageFragmentDataConverter : SiliconStudio.Core.Serialization.Converters.DataConverter<SiliconStudio.Paradox.Graphics.Data.ImageFragmentData, SiliconStudio.Paradox.Graphics.ImageFragment>	
	{
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Graphics.Data.ImageFragmentData target, SiliconStudio.Paradox.Graphics.ImageFragment source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Graphics.Data.ImageFragmentData();
				
            target.Name = source.Name;
            context.ConvertToData(ref target.Texture, source.Texture);
            context.ConvertToData(ref target.TextureAlpha, source.TextureAlpha);
            target.Region = source.Region;
            target.IsTransparent = source.IsTransparent;
            target.Orientation = source.Orientation;
        }

        /// <inheritdoc/>
        public override void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Graphics.Data.ImageFragmentData target, ref SiliconStudio.Paradox.Graphics.ImageFragment source)
        {
            if(source == null)
                source = new SiliconStudio.Paradox.Graphics.ImageFragment();

            source.Name = target.Name;
            {
                var temp = source.Texture;
                context.ConvertFromData(target.Texture, ref temp);
                source.Texture = temp;
            }
            {
                var temp = source.TextureAlpha;
                context.ConvertFromData(target.TextureAlpha, ref temp);
                source.TextureAlpha = temp;
            }
            source.Region = target.Region;
            source.IsTransparent = target.IsTransparent;
            source.Orientation = target.Orientation;
        }
    }

    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Graphics.Sprite"/>.
    /// </summary>
    public partial class SpriteDataConverter : SiliconStudio.Paradox.Graphics.Data.ImageFragmentDataConverter	
	{
		/// <inheritdoc/>
		public override System.Type DataType
		{
			get { return typeof(SiliconStudio.Paradox.Graphics.Data.SpriteData); }
		}

		/// <inheritdoc/>
		public override System.Type ObjectType
		{
			get { return typeof(SiliconStudio.Paradox.Graphics.Sprite); }
		}
				
        /// <inheritdoc/>
        public override void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, object data, ref object obj)
        {
            var dataT = (SiliconStudio.Paradox.Graphics.Data.SpriteData)data;
            var objT = (SiliconStudio.Paradox.Graphics.Sprite)obj;
            ConvertFromData(converterContext, dataT, ref objT);
            obj = objT;
        }
		
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext converterContext, ref object data, object obj)
        {
            var dataT = (SiliconStudio.Paradox.Graphics.Data.SpriteData)data;
            var objT = (SiliconStudio.Paradox.Graphics.Sprite)obj;
            ConvertToData(converterContext, ref dataT, objT);
            data = dataT;
        }

		        /// <inheritdoc/>
        public void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Graphics.Data.SpriteData target, SiliconStudio.Paradox.Graphics.Sprite source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Graphics.Data.SpriteData();
				
			{
				var targetBase = (SiliconStudio.Paradox.Graphics.Data.ImageFragmentData)target;
				var sourceBase = (SiliconStudio.Paradox.Graphics.ImageFragment)source;
				ConvertToData(context, ref targetBase, sourceBase);
			}

            target.Center = source.Center;
        }

        /// <inheritdoc/>
        public void ConvertFromData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, SiliconStudio.Paradox.Graphics.Data.SpriteData target, ref SiliconStudio.Paradox.Graphics.Sprite source)
        {
            if(source == null)
                source = new SiliconStudio.Paradox.Graphics.Sprite();

			{
				var targetBase = (SiliconStudio.Paradox.Graphics.Data.ImageFragmentData)target;
				var sourceBase = (SiliconStudio.Paradox.Graphics.ImageFragment)source;
				ConvertFromData(context, targetBase, ref sourceBase);
			}

            source.Center = target.Center;
        }
    }



    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Graphics.IndexBufferBinding"/>.
    /// </summary>
    public partial class IndexBufferBindingDataConverter : SiliconStudio.Core.Serialization.Converters.DataConverter<SiliconStudio.Paradox.Graphics.Data.IndexBufferBindingData, SiliconStudio.Paradox.Graphics.IndexBufferBinding>	
	{
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Graphics.Data.IndexBufferBindingData target, SiliconStudio.Paradox.Graphics.IndexBufferBinding source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Graphics.Data.IndexBufferBindingData();
				
            context.ConvertToData(ref target.Buffer, source.Buffer);
            target.Is32Bit = source.Is32Bit;
            target.Offset = source.Offset;
            target.Count = source.Count;
        }

    }

    /// <summary>
    /// Converter type for <see cref="SiliconStudio.Paradox.Graphics.VertexBufferBinding"/>.
    /// </summary>
    public partial class VertexBufferBindingDataConverter : SiliconStudio.Core.Serialization.Converters.DataConverter<SiliconStudio.Paradox.Graphics.Data.VertexBufferBindingData, SiliconStudio.Paradox.Graphics.VertexBufferBinding>	
	{
        /// <inheritdoc/>
        public override void ConvertToData(SiliconStudio.Core.Serialization.Converters.ConverterContext context, ref SiliconStudio.Paradox.Graphics.Data.VertexBufferBindingData target, SiliconStudio.Paradox.Graphics.VertexBufferBinding source)
        {
			if(target == null)
                target = new SiliconStudio.Paradox.Graphics.Data.VertexBufferBindingData();
				
            context.ConvertToData(ref target.Buffer, source.Buffer);
            target.Offset = source.Offset;
            target.Stride = source.Stride;
            target.Count = source.Count;
            target.Declaration = source.Declaration;
        }

    }

}

