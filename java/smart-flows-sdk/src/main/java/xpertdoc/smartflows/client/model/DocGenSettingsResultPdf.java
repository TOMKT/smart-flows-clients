/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.TypeAdapter;
import com.google.gson.annotations.JsonAdapter;
import com.google.gson.annotations.SerializedName;
import com.google.gson.stream.JsonReader;
import com.google.gson.stream.JsonWriter;
import io.swagger.annotations.ApiModelProperty;

import java.io.IOException;
import java.util.Objects;

/**
 * DocGenSettingsResultPdf
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettingsResultPdf {
  /**
   * Specifies the PDF standards compliance level. Pdf15: The output file will comply with the PDF 1.5 standard. PdfA1a: The output file will comply with the PDF/A-1a standard. This level includes all the requirements of PDF/A-1b and additionally requires that document structure be included (also known as being tagged), with the objective of ensuring that document content can be searched and repurposed. PdfA1b: The output file will comply with the PDF/A-1b standard. PDF/A-1b has the objective of ensuring reliable reproduction of the visual appearance of the document
   */
  @JsonAdapter(ComplianceEnum.Adapter.class)
  public enum ComplianceEnum {
    PDF15("pdf15"),
    
    PDFA1B("pdfA1b"),
    
    PDFA1A("pdfA1a");

    private String value;

    ComplianceEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ComplianceEnum fromValue(String text) {
      for (ComplianceEnum b : ComplianceEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ComplianceEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ComplianceEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ComplianceEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ComplianceEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("compliance")
  private ComplianceEnum compliance = ComplianceEnum.PDF15;

  @SerializedName("preserveFormFields")
  private Boolean preserveFormFields = false;

  /**
   * Controls how fonts are embedded into the resulting PDF documents. All: Embed all fonts. Non Standard: embed all fonts except standard Windows fonts Arial and Times New Roman. None: no fonts are embedded
   */
  @JsonAdapter(FontEmbeddingModeEnum.Adapter.class)
  public enum FontEmbeddingModeEnum {
    ALL("all"),
    
    NONSTANDARD("nonStandard"),
    
    NONE("none");

    private String value;

    FontEmbeddingModeEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static FontEmbeddingModeEnum fromValue(String text) {
      for (FontEmbeddingModeEnum b : FontEmbeddingModeEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<FontEmbeddingModeEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final FontEmbeddingModeEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public FontEmbeddingModeEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return FontEmbeddingModeEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("fontEmbeddingMode")
  private FontEmbeddingModeEnum fontEmbeddingMode = FontEmbeddingModeEnum.NONE;

  @SerializedName("encryption")
  private DocGenSettingsResultPdfEncryption encryption = null;

  public DocGenSettingsResultPdf compliance(ComplianceEnum compliance) {
    this.compliance = compliance;
    return this;
  }

   /**
   * Specifies the PDF standards compliance level. Pdf15: The output file will comply with the PDF 1.5 standard. PdfA1a: The output file will comply with the PDF/A-1a standard. This level includes all the requirements of PDF/A-1b and additionally requires that document structure be included (also known as being tagged), with the objective of ensuring that document content can be searched and repurposed. PdfA1b: The output file will comply with the PDF/A-1b standard. PDF/A-1b has the objective of ensuring reliable reproduction of the visual appearance of the document
   * @return compliance
  **/
  @ApiModelProperty(value = "Specifies the PDF standards compliance level. Pdf15: The output file will comply with the PDF 1.5 standard. PdfA1a: The output file will comply with the PDF/A-1a standard. This level includes all the requirements of PDF/A-1b and additionally requires that document structure be included (also known as being tagged), with the objective of ensuring that document content can be searched and repurposed. PdfA1b: The output file will comply with the PDF/A-1b standard. PDF/A-1b has the objective of ensuring reliable reproduction of the visual appearance of the document")
  public ComplianceEnum getCompliance() {
    return compliance;
  }

  public void setCompliance(ComplianceEnum compliance) {
    this.compliance = compliance;
  }

  public DocGenSettingsResultPdf preserveFormFields(Boolean preserveFormFields) {
    this.preserveFormFields = preserveFormFields;
    return this;
  }

   /**
   * Specifies whether to preserve form fields in PDF or convert them to text. Microsoft Word form fields include text input, drop down and check box controls. When set to false, these fields will be exported as text. When set to true, these fields will be exported as PDF form fields. When exporting form fields to PDF as form fields, some formatting loss might occur because PDF form fields do not support all features of Microsoft Word form fields
   * @return preserveFormFields
  **/
  @ApiModelProperty(value = "Specifies whether to preserve form fields in PDF or convert them to text. Microsoft Word form fields include text input, drop down and check box controls. When set to false, these fields will be exported as text. When set to true, these fields will be exported as PDF form fields. When exporting form fields to PDF as form fields, some formatting loss might occur because PDF form fields do not support all features of Microsoft Word form fields")
  public Boolean isPreserveFormFields() {
    return preserveFormFields;
  }

  public void setPreserveFormFields(Boolean preserveFormFields) {
    this.preserveFormFields = preserveFormFields;
  }

  public DocGenSettingsResultPdf fontEmbeddingMode(FontEmbeddingModeEnum fontEmbeddingMode) {
    this.fontEmbeddingMode = fontEmbeddingMode;
    return this;
  }

   /**
   * Controls how fonts are embedded into the resulting PDF documents. All: Embed all fonts. Non Standard: embed all fonts except standard Windows fonts Arial and Times New Roman. None: no fonts are embedded
   * @return fontEmbeddingMode
  **/
  @ApiModelProperty(value = "Controls how fonts are embedded into the resulting PDF documents. All: Embed all fonts. Non Standard: embed all fonts except standard Windows fonts Arial and Times New Roman. None: no fonts are embedded")
  public FontEmbeddingModeEnum getFontEmbeddingMode() {
    return fontEmbeddingMode;
  }

  public void setFontEmbeddingMode(FontEmbeddingModeEnum fontEmbeddingMode) {
    this.fontEmbeddingMode = fontEmbeddingMode;
  }

  public DocGenSettingsResultPdf encryption(DocGenSettingsResultPdfEncryption encryption) {
    this.encryption = encryption;
    return this;
  }

   /**
   * Get encryption
   * @return encryption
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultPdfEncryption getEncryption() {
    return encryption;
  }

  public void setEncryption(DocGenSettingsResultPdfEncryption encryption) {
    this.encryption = encryption;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettingsResultPdf docGenSettingsResultPdf = (DocGenSettingsResultPdf) o;
    return Objects.equals(this.compliance, docGenSettingsResultPdf.compliance) &&
        Objects.equals(this.preserveFormFields, docGenSettingsResultPdf.preserveFormFields) &&
        Objects.equals(this.fontEmbeddingMode, docGenSettingsResultPdf.fontEmbeddingMode) &&
        Objects.equals(this.encryption, docGenSettingsResultPdf.encryption);
  }

  @Override
  public int hashCode() {
    return Objects.hash(compliance, preserveFormFields, fontEmbeddingMode, encryption);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettingsResultPdf {\n");
    
    sb.append("    compliance: ").append(toIndentedString(compliance)).append("\n");
    sb.append("    preserveFormFields: ").append(toIndentedString(preserveFormFields)).append("\n");
    sb.append("    fontEmbeddingMode: ").append(toIndentedString(fontEmbeddingMode)).append("\n");
    sb.append("    encryption: ").append(toIndentedString(encryption)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

