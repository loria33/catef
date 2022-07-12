//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

[assembly: PureLiveAssembly]
[assembly:ModelsBuilderAssembly(PureLive = true, SourceHash = "4f25ff273c19a850")]
[assembly:System.Reflection.AssemblyVersion("0.0.0.1")]

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Home</summary>
	[PublishedContentModel("home")]
	public partial class Home : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "home";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Home(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Home, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AnatIntro
		///</summary>
		[ImplementPropertyType("anatIntro")]
		public string AnatIntro
		{
			get { return this.GetPropertyValue<string>("anatIntro"); }
		}

		///<summary>
		/// AnatIntroMore
		///</summary>
		[ImplementPropertyType("anatIntroMore")]
		public string AnatIntroMore
		{
			get { return this.GetPropertyValue<string>("anatIntroMore"); }
		}

		///<summary>
		/// AviIntro
		///</summary>
		[ImplementPropertyType("aviIntro")]
		public string AviIntro
		{
			get { return this.GetPropertyValue<string>("aviIntro"); }
		}

		///<summary>
		/// AviIntroMore
		///</summary>
		[ImplementPropertyType("aviIntroMore")]
		public string AviIntroMore
		{
			get { return this.GetPropertyValue<string>("aviIntroMore"); }
		}

		///<summary>
		/// imageofavi
		///</summary>
		[ImplementPropertyType("imageofavi")]
		public IPublishedContent Imageofavi
		{
			get { return this.GetPropertyValue<IPublishedContent>("imageofavi"); }
		}

		///<summary>
		/// ImageToShow
		///</summary>
		[ImplementPropertyType("imageToShow")]
		public IPublishedContent ImageToShow
		{
			get { return this.GetPropertyValue<IPublishedContent>("imageToShow"); }
		}

		///<summary>
		/// linkfromAviImage
		///</summary>
		[ImplementPropertyType("linkfromAviImage")]
		public IPublishedContent LinkfromAviImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("linkfromAviImage"); }
		}

		///<summary>
		/// LinkFromImage
		///</summary>
		[ImplementPropertyType("linkFromImage")]
		public IPublishedContent LinkFromImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("linkFromImage"); }
		}

		///<summary>
		/// randomBricks
		///</summary>
		[ImplementPropertyType("randomBricks")]
		public IEnumerable<IPublishedContent> RandomBricks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("randomBricks"); }
		}

		///<summary>
		/// SlidesPicker: Get Slides from contentData
		///</summary>
		[ImplementPropertyType("slidesPicker")]
		public IEnumerable<IPublishedContent> SlidesPicker
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("slidesPicker"); }
		}

		///<summary>
		/// Title
		///</summary>
		[ImplementPropertyType("title")]
		public string Title
		{
			get { return this.GetPropertyValue<string>("title"); }
		}

		///<summary>
		/// videoImage
		///</summary>
		[ImplementPropertyType("videoImage")]
		public IPublishedContent VideoImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("videoImage"); }
		}

		///<summary>
		/// videoLink
		///</summary>
		[ImplementPropertyType("videoLink")]
		public string VideoLink
		{
			get { return this.GetPropertyValue<string>("videoLink"); }
		}
	}

	/// <summary>Category</summary>
	[PublishedContentModel("surgery")]
	public partial class Surgery : Home
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "surgery";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Surgery(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Surgery, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MainGrid
		///</summary>
		[ImplementPropertyType("mainGrid")]
		public Skybrud.Umbraco.GridData.GridDataModel MainGrid
		{
			get { return this.GetPropertyValue<Skybrud.Umbraco.GridData.GridDataModel>("mainGrid"); }
		}
	}

	/// <summary>InnerPage</summary>
	[PublishedContentModel("innerPage")]
	public partial class InnerPage : Surgery
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "innerPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public InnerPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<InnerPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// BrickImages
		///</summary>
		[ImplementPropertyType("brickImages")]
		public IEnumerable<IPublishedContent> BrickImages
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("brickImages"); }
		}

		///<summary>
		/// categoryTags: Separate with commas
		///</summary>
		[ImplementPropertyType("categoryTags")]
		public IEnumerable<string> CategoryTags
		{
			get { return this.GetPropertyValue<IEnumerable<string>>("categoryTags"); }
		}

		///<summary>
		/// DateofUpdate
		///</summary>
		[ImplementPropertyType("dateofUpdate")]
		public string DateofUpdate
		{
			get { return this.GetPropertyValue<string>("dateofUpdate"); }
		}

		///<summary>
		/// EnglishHeader: שם הניתוח או פציעה באנגלית
		///</summary>
		[ImplementPropertyType("englishHeader")]
		public string EnglishHeader
		{
			get { return this.GetPropertyValue<string>("englishHeader"); }
		}

		///<summary>
		/// FirstParagraph
		///</summary>
		[ImplementPropertyType("firstParagraph")]
		public IHtmlString FirstParagraph
		{
			get { return this.GetPropertyValue<IHtmlString>("firstParagraph"); }
		}

		///<summary>
		/// tags: Separate with commas
		///</summary>
		[ImplementPropertyType("tags")]
		public string Tags
		{
			get { return this.GetPropertyValue<string>("tags"); }
		}

		///<summary>
		/// topImage
		///</summary>
		[ImplementPropertyType("topImage")]
		public IPublishedContent TopImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("topImage"); }
		}
	}

	/// <summary>ContactDocType</summary>
	[PublishedContentModel("contactDocType")]
	public partial class ContactDocType : Home
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contactDocType";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContactDocType(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContactDocType, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>About</summary>
	[PublishedContentModel("about")]
	public partial class About : Home
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "about";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public About(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<About, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AboutPageBricks: Pick up to 3 images for about page
		///</summary>
		[ImplementPropertyType("aboutPageBricks")]
		public IEnumerable<IPublishedContent> AboutPageBricks
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("aboutPageBricks"); }
		}

		///<summary>
		/// First Text
		///</summary>
		[ImplementPropertyType("firstText")]
		public IHtmlString FirstText
		{
			get { return this.GetPropertyValue<IHtmlString>("firstText"); }
		}

		///<summary>
		/// MedicalAccrids
		///</summary>
		[ImplementPropertyType("medicalAccrids")]
		public IHtmlString MedicalAccrids
		{
			get { return this.GetPropertyValue<IHtmlString>("medicalAccrids"); }
		}

		///<summary>
		/// MedicalAccridsTitle
		///</summary>
		[ImplementPropertyType("medicalAccridsTitle")]
		public IHtmlString MedicalAccridsTitle
		{
			get { return this.GetPropertyValue<IHtmlString>("medicalAccridsTitle"); }
		}

		///<summary>
		/// quoteofDay
		///</summary>
		[ImplementPropertyType("quoteofDay")]
		public string QuoteofDay
		{
			get { return this.GetPropertyValue<string>("quoteofDay"); }
		}

		///<summary>
		/// topAboutImg
		///</summary>
		[ImplementPropertyType("topAboutImg")]
		public IPublishedContent TopAboutImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("topAboutImg"); }
		}

		///<summary>
		/// workToday
		///</summary>
		[ImplementPropertyType("workToday")]
		public IHtmlString WorkToday
		{
			get { return this.GetPropertyValue<IHtmlString>("workToday"); }
		}

		///<summary>
		/// workTodayTitle
		///</summary>
		[ImplementPropertyType("workTodayTitle")]
		public string WorkTodayTitle
		{
			get { return this.GetPropertyValue<string>("workTodayTitle"); }
		}
	}

	/// <summary>ContenData</summary>
	[PublishedContentModel("contenData")]
	public partial class ContenData : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "contenData";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ContenData(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ContenData, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}
	}

	/// <summary>QuestionsAndAnswers</summary>
	[PublishedContentModel("questionsAndAnswers")]
	public partial class QuestionsAndAnswers : ContenData
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "questionsAndAnswers";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public QuestionsAndAnswers(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<QuestionsAndAnswers, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Answer
		///</summary>
		[ImplementPropertyType("answer")]
		public string Answer
		{
			get { return this.GetPropertyValue<string>("answer"); }
		}

		///<summary>
		/// dateofquestion
		///</summary>
		[ImplementPropertyType("dateofquestion")]
		public DateTime Dateofquestion
		{
			get { return this.GetPropertyValue<DateTime>("dateofquestion"); }
		}

		///<summary>
		/// question
		///</summary>
		[ImplementPropertyType("question")]
		public string Question
		{
			get { return this.GetPropertyValue<string>("question"); }
		}
	}

	/// <summary>ShowGridofData</summary>
	[PublishedContentModel("showGridofData")]
	public partial class ShowGridofData : Home
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "showGridofData";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public ShowGridofData(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<ShowGridofData, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// MultiPicker: Add from ContentData folder
		///</summary>
		[ImplementPropertyType("multiPicker")]
		public IEnumerable<IPublishedContent> MultiPicker
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("multiPicker"); }
		}
	}

	/// <summary>Definitions</summary>
	[PublishedContentModel("definitions")]
	public partial class Definitions : ContenData
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "definitions";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Definitions(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Definitions, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// definition_text
		///</summary>
		[ImplementPropertyType("definition_text")]
		public IHtmlString Definition_text
		{
			get { return this.GetPropertyValue<IHtmlString>("definition_text"); }
		}

		///<summary>
		/// definitionlbl
		///</summary>
		[ImplementPropertyType("definitionlbl")]
		public string Definitionlbl
		{
			get { return this.GetPropertyValue<string>("definitionlbl"); }
		}

		///<summary>
		/// definitionlbl_eng
		///</summary>
		[ImplementPropertyType("definitionlbl_eng")]
		public string Definitionlbl_eng
		{
			get { return this.GetPropertyValue<string>("definitionlbl_eng"); }
		}
	}

	/// <summary>Slides</summary>
	[PublishedContentModel("slides")]
	public partial class Slides : ContenData
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "slides";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Slides(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Slides, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// featureSlide Picture: Slide picture
		///</summary>
		[ImplementPropertyType("featureSlidePicture")]
		public IPublishedContent FeatureSlidePicture
		{
			get { return this.GetPropertyValue<IPublishedContent>("featureSlidePicture"); }
		}

		///<summary>
		/// LinktoPageofSlide
		///</summary>
		[ImplementPropertyType("linktoPageofSlide")]
		public IPublishedContent LinktoPageofSlide
		{
			get { return this.GetPropertyValue<IPublishedContent>("linktoPageofSlide"); }
		}

		///<summary>
		/// MainTextOverImage
		///</summary>
		[ImplementPropertyType("mainTextOverImage")]
		public string MainTextOverImage
		{
			get { return this.GetPropertyValue<string>("mainTextOverImage"); }
		}

		///<summary>
		/// smallText
		///</summary>
		[ImplementPropertyType("smallText")]
		public string SmallText
		{
			get { return this.GetPropertyValue<string>("smallText"); }
		}
	}

	/// <summary>anatPage</summary>
	[PublishedContentModel("anatPage")]
	public partial class AnatPage : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "anatPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AnatPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AnatPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AnatomyContentList: Add Anatomy blocks
		///</summary>
		[ImplementPropertyType("anatomyContentList")]
		public IEnumerable<IPublishedContent> AnatomyContentList
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("anatomyContentList"); }
		}
	}

	/// <summary>AnatomyBlocksContent</summary>
	[PublishedContentModel("anatomyBlocksContent")]
	public partial class AnatomyBlocksContent : ContenData
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "anatomyBlocksContent";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public AnatomyBlocksContent(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<AnatomyBlocksContent, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// AnatomyLink: Add a link to an external website only
		///</summary>
		[ImplementPropertyType("anatomyLink")]
		public string AnatomyLink
		{
			get { return this.GetPropertyValue<string>("anatomyLink"); }
		}

		///<summary>
		/// AnatomyParagraph
		///</summary>
		[ImplementPropertyType("anatomyParagraph")]
		public IHtmlString AnatomyParagraph
		{
			get { return this.GetPropertyValue<IHtmlString>("anatomyParagraph"); }
		}

		///<summary>
		/// ImageAnatomy: Enter The Image for Anatomy
		///</summary>
		[ImplementPropertyType("imageAnatomy")]
		public IPublishedContent ImageAnatomy
		{
			get { return this.GetPropertyValue<IPublishedContent>("imageAnatomy"); }
		}
	}

	/// <summary>HomeBricks</summary>
	[PublishedContentModel("homeBricks_t")]
	public partial class HomeBricks_t : ContenData
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "homeBricks_t";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public HomeBricks_t(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomeBricks_t, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// brickImage
		///</summary>
		[ImplementPropertyType("brickImage")]
		public IPublishedContent BrickImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("brickImage"); }
		}

		///<summary>
		/// brickLink: link to youtube or other page
		///</summary>
		[ImplementPropertyType("brickLink")]
		public string BrickLink
		{
			get { return this.GetPropertyValue<string>("brickLink"); }
		}

		///<summary>
		/// brickParagraph
		///</summary>
		[ImplementPropertyType("brickParagraph")]
		public IHtmlString BrickParagraph
		{
			get { return this.GetPropertyValue<IHtmlString>("brickParagraph"); }
		}

		///<summary>
		/// brickTitle: Title of brick under image
		///</summary>
		[ImplementPropertyType("brickTitle")]
		public string BrickTitle
		{
			get { return this.GetPropertyValue<string>("brickTitle"); }
		}

		///<summary>
		/// isVideo: is this a video or regular brick
		///</summary>
		[ImplementPropertyType("isVideo")]
		public bool IsVideo
		{
			get { return this.GetPropertyValue<bool>("isVideo"); }
		}
	}

	/// <summary>Folder</summary>
	[PublishedContentModel("Folder")]
	public partial class Folder : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Folder";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Folder(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Folder, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Contents:
		///</summary>
		[ImplementPropertyType("contents")]
		public object Contents
		{
			get { return this.GetPropertyValue("contents"); }
		}
	}

	/// <summary>Image</summary>
	[PublishedContentModel("Image")]
	public partial class Image : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Image";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public Image(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Image, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Link
		///</summary>
		[ImplementPropertyType("link")]
		public string Link
		{
			get { return this.GetPropertyValue<string>("link"); }
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload image
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public Umbraco.Web.Models.ImageCropDataSet UmbracoFile
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.ImageCropDataSet>("umbracoFile"); }
		}

		///<summary>
		/// Height
		///</summary>
		[ImplementPropertyType("umbracoHeight")]
		public string UmbracoHeight
		{
			get { return this.GetPropertyValue<string>("umbracoHeight"); }
		}

		///<summary>
		/// Width
		///</summary>
		[ImplementPropertyType("umbracoWidth")]
		public string UmbracoWidth
		{
			get { return this.GetPropertyValue<string>("umbracoWidth"); }
		}
	}

	/// <summary>File</summary>
	[PublishedContentModel("File")]
	public partial class File : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "File";
		public new const PublishedItemType ModelItemType = PublishedItemType.Media;
#pragma warning restore 0109

		public File(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<File, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Size
		///</summary>
		[ImplementPropertyType("umbracoBytes")]
		public string UmbracoBytes
		{
			get { return this.GetPropertyValue<string>("umbracoBytes"); }
		}

		///<summary>
		/// Type
		///</summary>
		[ImplementPropertyType("umbracoExtension")]
		public string UmbracoExtension
		{
			get { return this.GetPropertyValue<string>("umbracoExtension"); }
		}

		///<summary>
		/// Upload file
		///</summary>
		[ImplementPropertyType("umbracoFile")]
		public string UmbracoFile
		{
			get { return this.GetPropertyValue<string>("umbracoFile"); }
		}
	}

	/// <summary>Member</summary>
	[PublishedContentModel("Member")]
	public partial class Member : PublishedContentModel
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "Member";
		public new const PublishedItemType ModelItemType = PublishedItemType.Member;
#pragma warning restore 0109

		public Member(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Member, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Is Approved
		///</summary>
		[ImplementPropertyType("umbracoMemberApproved")]
		public bool UmbracoMemberApproved
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberApproved"); }
		}

		///<summary>
		/// Comments
		///</summary>
		[ImplementPropertyType("umbracoMemberComments")]
		public string UmbracoMemberComments
		{
			get { return this.GetPropertyValue<string>("umbracoMemberComments"); }
		}

		///<summary>
		/// Failed Password Attempts
		///</summary>
		[ImplementPropertyType("umbracoMemberFailedPasswordAttempts")]
		public string UmbracoMemberFailedPasswordAttempts
		{
			get { return this.GetPropertyValue<string>("umbracoMemberFailedPasswordAttempts"); }
		}

		///<summary>
		/// Last Lockout Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLockoutDate")]
		public string UmbracoMemberLastLockoutDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLockoutDate"); }
		}

		///<summary>
		/// Last Login Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastLogin")]
		public string UmbracoMemberLastLogin
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastLogin"); }
		}

		///<summary>
		/// Last Password Change Date
		///</summary>
		[ImplementPropertyType("umbracoMemberLastPasswordChangeDate")]
		public string UmbracoMemberLastPasswordChangeDate
		{
			get { return this.GetPropertyValue<string>("umbracoMemberLastPasswordChangeDate"); }
		}

		///<summary>
		/// Is Locked Out
		///</summary>
		[ImplementPropertyType("umbracoMemberLockedOut")]
		public bool UmbracoMemberLockedOut
		{
			get { return this.GetPropertyValue<bool>("umbracoMemberLockedOut"); }
		}

		///<summary>
		/// Password Answer
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalAnswer")]
		public string UmbracoMemberPasswordRetrievalAnswer
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalAnswer"); }
		}

		///<summary>
		/// Password Question
		///</summary>
		[ImplementPropertyType("umbracoMemberPasswordRetrievalQuestion")]
		public string UmbracoMemberPasswordRetrievalQuestion
		{
			get { return this.GetPropertyValue<string>("umbracoMemberPasswordRetrievalQuestion"); }
		}
	}

}
