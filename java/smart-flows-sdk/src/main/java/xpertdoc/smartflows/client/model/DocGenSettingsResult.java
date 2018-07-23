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
 * DocGenSettingsResult
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class DocGenSettingsResult {
  /**
   * Gets or Sets content
   */
  @JsonAdapter(ContentEnum.Adapter.class)
  public enum ContentEnum {
    RETURNCONTENT("returnContent"),
    
    STORECONTENT("storeContent"),
    
    STOREANDRETURNCONTENT("storeAndReturnContent"),
    
    NOSTORENORETURN("noStoreNoReturn");

    private String value;

    ContentEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static ContentEnum fromValue(String text) {
      for (ContentEnum b : ContentEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<ContentEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final ContentEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public ContentEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return ContentEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("content")
  private ContentEnum content = ContentEnum.STORECONTENT;

  @SerializedName("chartData")
  private DocGenSettingsResultChartData chartData = null;

  /**
   * Gets or Sets format
   */
  @JsonAdapter(FormatEnum.Adapter.class)
  public enum FormatEnum {
    OOXML("ooxml"),
    
    PDF("pdf"),
    
    HTML("html"),
    
    TEXT("text"),
    
    XPS("xps"),
    
    ODT("odt"),
    
    RTF("rtf"),
    
    IMAGE("image");

    private String value;

    FormatEnum(String value) {
      this.value = value;
    }

    public String getValue() {
      return value;
    }

    @Override
    public String toString() {
      return String.valueOf(value);
    }

    public static FormatEnum fromValue(String text) {
      for (FormatEnum b : FormatEnum.values()) {
        if (String.valueOf(b.value).equals(text)) {
          return b;
        }
      }
      return null;
    }

    public static class Adapter extends TypeAdapter<FormatEnum> {
      @Override
      public void write(final JsonWriter jsonWriter, final FormatEnum enumeration) throws IOException {
        jsonWriter.value(enumeration.getValue());
      }

      @Override
      public FormatEnum read(final JsonReader jsonReader) throws IOException {
        String value = jsonReader.nextString();
        return FormatEnum.fromValue(String.valueOf(value));
      }
    }
  }

  @SerializedName("format")
  private FormatEnum format = FormatEnum.PDF;

  @SerializedName("ooxml")
  private DocGenSettingsResultOoxml ooxml = null;

  @SerializedName("image")
  private DocGenSettingsResultImage image = null;

  @SerializedName("pdf")
  private DocGenSettingsResultPdf pdf = null;

  @SerializedName("html")
  private DocGenSettingsResultHtml html = null;

  @SerializedName("text")
  private DocGenSettingsResultText text = null;

  @SerializedName("odt")
  private DocGenSettingsResultOdt odt = null;

  public DocGenSettingsResult content(ContentEnum content) {
    this.content = content;
    return this;
  }

   /**
   * Get content
   * @return content
  **/
  @ApiModelProperty(value = "")
  public ContentEnum getContent() {
    return content;
  }

  public void setContent(ContentEnum content) {
    this.content = content;
  }

  public DocGenSettingsResult chartData(DocGenSettingsResultChartData chartData) {
    this.chartData = chartData;
    return this;
  }

   /**
   * Get chartData
   * @return chartData
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultChartData getChartData() {
    return chartData;
  }

  public void setChartData(DocGenSettingsResultChartData chartData) {
    this.chartData = chartData;
  }

  public DocGenSettingsResult format(FormatEnum format) {
    this.format = format;
    return this;
  }

   /**
   * Get format
   * @return format
  **/
  @ApiModelProperty(value = "")
  public FormatEnum getFormat() {
    return format;
  }

  public void setFormat(FormatEnum format) {
    this.format = format;
  }

  public DocGenSettingsResult ooxml(DocGenSettingsResultOoxml ooxml) {
    this.ooxml = ooxml;
    return this;
  }

   /**
   * Get ooxml
   * @return ooxml
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultOoxml getOoxml() {
    return ooxml;
  }

  public void setOoxml(DocGenSettingsResultOoxml ooxml) {
    this.ooxml = ooxml;
  }

  public DocGenSettingsResult image(DocGenSettingsResultImage image) {
    this.image = image;
    return this;
  }

   /**
   * Get image
   * @return image
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultImage getImage() {
    return image;
  }

  public void setImage(DocGenSettingsResultImage image) {
    this.image = image;
  }

  public DocGenSettingsResult pdf(DocGenSettingsResultPdf pdf) {
    this.pdf = pdf;
    return this;
  }

   /**
   * Get pdf
   * @return pdf
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultPdf getPdf() {
    return pdf;
  }

  public void setPdf(DocGenSettingsResultPdf pdf) {
    this.pdf = pdf;
  }

  public DocGenSettingsResult html(DocGenSettingsResultHtml html) {
    this.html = html;
    return this;
  }

   /**
   * Get html
   * @return html
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultHtml getHtml() {
    return html;
  }

  public void setHtml(DocGenSettingsResultHtml html) {
    this.html = html;
  }

  public DocGenSettingsResult text(DocGenSettingsResultText text) {
    this.text = text;
    return this;
  }

   /**
   * Get text
   * @return text
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultText getText() {
    return text;
  }

  public void setText(DocGenSettingsResultText text) {
    this.text = text;
  }

  public DocGenSettingsResult odt(DocGenSettingsResultOdt odt) {
    this.odt = odt;
    return this;
  }

   /**
   * Get odt
   * @return odt
  **/
  @ApiModelProperty(value = "")
  public DocGenSettingsResultOdt getOdt() {
    return odt;
  }

  public void setOdt(DocGenSettingsResultOdt odt) {
    this.odt = odt;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    DocGenSettingsResult docGenSettingsResult = (DocGenSettingsResult) o;
    return Objects.equals(this.content, docGenSettingsResult.content) &&
        Objects.equals(this.chartData, docGenSettingsResult.chartData) &&
        Objects.equals(this.format, docGenSettingsResult.format) &&
        Objects.equals(this.ooxml, docGenSettingsResult.ooxml) &&
        Objects.equals(this.image, docGenSettingsResult.image) &&
        Objects.equals(this.pdf, docGenSettingsResult.pdf) &&
        Objects.equals(this.html, docGenSettingsResult.html) &&
        Objects.equals(this.text, docGenSettingsResult.text) &&
        Objects.equals(this.odt, docGenSettingsResult.odt);
  }

  @Override
  public int hashCode() {
    return Objects.hash(content, chartData, format, ooxml, image, pdf, html, text, odt);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class DocGenSettingsResult {\n");
    
    sb.append("    content: ").append(toIndentedString(content)).append("\n");
    sb.append("    chartData: ").append(toIndentedString(chartData)).append("\n");
    sb.append("    format: ").append(toIndentedString(format)).append("\n");
    sb.append("    ooxml: ").append(toIndentedString(ooxml)).append("\n");
    sb.append("    image: ").append(toIndentedString(image)).append("\n");
    sb.append("    pdf: ").append(toIndentedString(pdf)).append("\n");
    sb.append("    html: ").append(toIndentedString(html)).append("\n");
    sb.append("    text: ").append(toIndentedString(text)).append("\n");
    sb.append("    odt: ").append(toIndentedString(odt)).append("\n");
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

