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
 * FlatArchive
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class FlatArchive {
  @SerializedName("archive")
  private Archive archive = null;

  @SerializedName("items")
  private List<ArchivableItem> items = null;

  public FlatArchive archive(Archive archive) {
    this.archive = archive;
    return this;
  }

   /**
   * Get archive
   * @return archive
  **/
  @ApiModelProperty(value = "")
  public Archive getArchive() {
    return archive;
  }

  public void setArchive(Archive archive) {
    this.archive = archive;
  }

  public FlatArchive items(List<ArchivableItem> items) {
    this.items = items;
    return this;
  }

  public FlatArchive addItemsItem(ArchivableItem itemsItem) {
    if (this.items == null) {
      this.items = new ArrayList<ArchivableItem>();
    }
    this.items.add(itemsItem);
    return this;
  }

   /**
   * Get items
   * @return items
  **/
  @ApiModelProperty(value = "")
  public List<ArchivableItem> getItems() {
    return items;
  }

  public void setItems(List<ArchivableItem> items) {
    this.items = items;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlatArchive flatArchive = (FlatArchive) o;
    return Objects.equals(this.archive, flatArchive.archive) &&
        Objects.equals(this.items, flatArchive.items);
  }

  @Override
  public int hashCode() {
    return Objects.hash(archive, items);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlatArchive {\n");
    
    sb.append("    archive: ").append(toIndentedString(archive)).append("\n");
    sb.append("    items: ").append(toIndentedString(items)).append("\n");
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

