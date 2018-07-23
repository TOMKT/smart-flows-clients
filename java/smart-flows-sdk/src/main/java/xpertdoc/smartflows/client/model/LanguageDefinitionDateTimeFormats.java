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

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * LanguageDefinitionDateTimeFormats
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class LanguageDefinitionDateTimeFormats {
  @SerializedName("date")
  private List<FormatDefinition> date = null;

  @SerializedName("time")
  private List<FormatDefinition> time = null;

  @SerializedName("dateTime")
  private List<FormatDefinition> dateTime = null;

  public LanguageDefinitionDateTimeFormats date(List<FormatDefinition> date) {
    this.date = date;
    return this;
  }

  public LanguageDefinitionDateTimeFormats addDateItem(FormatDefinition dateItem) {
    if (this.date == null) {
      this.date = new ArrayList<FormatDefinition>();
    }
    this.date.add(dateItem);
    return this;
  }

   /**
   * Get date
   * @return date
  **/
  @ApiModelProperty(value = "")
  public List<FormatDefinition> getDate() {
    return date;
  }

  public void setDate(List<FormatDefinition> date) {
    this.date = date;
  }

  public LanguageDefinitionDateTimeFormats time(List<FormatDefinition> time) {
    this.time = time;
    return this;
  }

  public LanguageDefinitionDateTimeFormats addTimeItem(FormatDefinition timeItem) {
    if (this.time == null) {
      this.time = new ArrayList<FormatDefinition>();
    }
    this.time.add(timeItem);
    return this;
  }

   /**
   * Get time
   * @return time
  **/
  @ApiModelProperty(value = "")
  public List<FormatDefinition> getTime() {
    return time;
  }

  public void setTime(List<FormatDefinition> time) {
    this.time = time;
  }

  public LanguageDefinitionDateTimeFormats dateTime(List<FormatDefinition> dateTime) {
    this.dateTime = dateTime;
    return this;
  }

  public LanguageDefinitionDateTimeFormats addDateTimeItem(FormatDefinition dateTimeItem) {
    if (this.dateTime == null) {
      this.dateTime = new ArrayList<FormatDefinition>();
    }
    this.dateTime.add(dateTimeItem);
    return this;
  }

   /**
   * Get dateTime
   * @return dateTime
  **/
  @ApiModelProperty(value = "")
  public List<FormatDefinition> getDateTime() {
    return dateTime;
  }

  public void setDateTime(List<FormatDefinition> dateTime) {
    this.dateTime = dateTime;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    LanguageDefinitionDateTimeFormats languageDefinitionDateTimeFormats = (LanguageDefinitionDateTimeFormats) o;
    return Objects.equals(this.date, languageDefinitionDateTimeFormats.date) &&
        Objects.equals(this.time, languageDefinitionDateTimeFormats.time) &&
        Objects.equals(this.dateTime, languageDefinitionDateTimeFormats.dateTime);
  }

  @Override
  public int hashCode() {
    return Objects.hash(date, time, dateTime);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class LanguageDefinitionDateTimeFormats {\n");
    
    sb.append("    date: ").append(toIndentedString(date)).append("\n");
    sb.append("    time: ").append(toIndentedString(time)).append("\n");
    sb.append("    dateTime: ").append(toIndentedString(dateTime)).append("\n");
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
